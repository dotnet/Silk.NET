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

[Guid("C79B63D0-F8EC-4CEB-953A-C8876157DD33")]
[NativeTypeName("struct IPrintWorkflowForegroundSession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPrintWorkflowForegroundSession
    : IPrintWorkflowForegroundSession.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPrintWorkflowForegroundSession));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowForegroundSession, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPrintWorkflowForegroundSession, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPrintWorkflowForegroundSession, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IPrintWorkflowForegroundSession, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowForegroundSession, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowForegroundSession, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_SetupRequested(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSetupRequestedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* setupEventHandler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowForegroundSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, setupEventHandler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_SetupRequested(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowForegroundSession, EventRegistrationToken, int>)(
                (*lpVtbl)[7]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_XpsDataAvailable(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowXpsDataAvailableEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* xpsDataAvailableEventHandler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowForegroundSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, xpsDataAvailableEventHandler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_XpsDataAvailable(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IPrintWorkflowForegroundSession, EventRegistrationToken, int>)(
                (*lpVtbl)[9]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Status(
        [NativeTypeName("ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *")]
            PrintWorkflowSessionStatus* value
    )
    {
        return (
            (delegate* unmanaged<
                IPrintWorkflowForegroundSession,
                PrintWorkflowSessionStatus*,
                int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Start()
    {
        return ((delegate* unmanaged<IPrintWorkflowForegroundSession, int>)((*lpVtbl)[11]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_SetupRequested(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSetupRequestedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* setupEventHandler,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_SetupRequested(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT add_XpsDataAvailable(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowXpsDataAvailableEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* xpsDataAvailableEventHandler,
            EventRegistrationToken* token
        );

        [VtblIndex(9)]
        HRESULT remove_XpsDataAvailable(EventRegistrationToken token);

        [VtblIndex(10)]
        HRESULT get_Status(
            [NativeTypeName(
                "ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *"
            )]
                PrintWorkflowSessionStatus* value
        );

        [VtblIndex(11)]
        HRESULT Start();
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSetupRequestedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_SetupRequested;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_SetupRequested;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowForegroundSession_Windows__CGraphics__CPrinting__CWorkflow__CPrintWorkflowXpsDataAvailableEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_XpsDataAvailable;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_XpsDataAvailable;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Graphics::Printing::Workflow::PrintWorkflowSessionStatus *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PrintWorkflowSessionStatus*, int> get_Status;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Start;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPrintWorkflowForegroundSession"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPrintWorkflowForegroundSession(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPrintWorkflowForegroundSession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowForegroundSession(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPrintWorkflowForegroundSession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowForegroundSession"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowForegroundSession"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPrintWorkflowForegroundSession value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPrintWorkflowForegroundSession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPrintWorkflowForegroundSession(Silk.NET.Windows.IUnknown value)
    {
        return new IPrintWorkflowForegroundSession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPrintWorkflowForegroundSession"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPrintWorkflowForegroundSession"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPrintWorkflowForegroundSession value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
