// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("69476A01-9ADA-490F-9549-D31CB14C9E95")]
[NativeTypeName("struct IRemoteSystemSession : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemSession : IRemoteSystemSession.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemSession));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRemoteSystemSession, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRemoteSystemSession, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRemoteSystemSession, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IRemoteSystemSession, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRemoteSystemSession, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRemoteSystemSession, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<IRemoteSystemSession, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_DisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IRemoteSystemSession, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ControllerDisplayName(HSTRING* value)
    {
        return ((delegate* unmanaged<IRemoteSystemSession, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Disconnected(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSession_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionDisconnectedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* handler,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteSystemSession,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, handler, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Disconnected(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IRemoteSystemSession, EventRegistrationToken, int>)((*lpVtbl)[10])
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CreateParticipantWatcher(
        [NativeTypeName(
            "ABI::Windows::System::RemoteSystems::IRemoteSystemSessionParticipantWatcher **"
        )]
            IRemoteSystemSessionParticipantWatcher* result
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteSystemSession,
                IRemoteSystemSessionParticipantWatcher*,
                int>)((*lpVtbl)[11])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SendInvitationAsync(
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystem *")]
            IRemoteSystem invitee,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteSystemSession,
                IRemoteSystem,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[12])
        )(this, invitee, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(7)]
        HRESULT get_DisplayName(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_ControllerDisplayName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT add_Disconnected(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSession_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionDisconnectedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* handler,
            EventRegistrationToken* token
        );

        [VtblIndex(10)]
        HRESULT remove_Disconnected(EventRegistrationToken token);

        [VtblIndex(11)]
        HRESULT CreateParticipantWatcher(
            [NativeTypeName(
                "ABI::Windows::System::RemoteSystems::IRemoteSystemSessionParticipantWatcher **"
            )]
                IRemoteSystemSessionParticipantWatcher* result
        );

        [VtblIndex(12)]
        HRESULT SendInvitationAsync(
            [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystem *")]
                IRemoteSystem invitee,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_DisplayName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ControllerDisplayName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CSystem__CRemoteSystems__CRemoteSystemSession_Windows__CSystem__CRemoteSystems__CRemoteSystemSessionDisconnectedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Disconnected;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Disconnected;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemSessionParticipantWatcher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRemoteSystemSessionParticipantWatcher*,
            int> CreateParticipantWatcher;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystem *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRemoteSystem,
            IAsyncOperation<byte>**,
            int> SendInvitationAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRemoteSystemSession"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRemoteSystemSession(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRemoteSystemSession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRemoteSystemSession(Silk.NET.WinRT.IInspectable value)
    {
        return new IRemoteSystemSession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemSession"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemSession"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRemoteSystemSession value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRemoteSystemSession"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRemoteSystemSession(Silk.NET.Windows.IUnknown value)
    {
        return new IRemoteSystemSession(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemSession"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemSession"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRemoteSystemSession value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
