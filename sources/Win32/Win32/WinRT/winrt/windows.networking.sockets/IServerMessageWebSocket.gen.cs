// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.sockets.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("E3AC9240-813B-5EFD-7E11-AE2305FC77F1")]
[NativeTypeName("struct IServerMessageWebSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IServerMessageWebSocket
    : IServerMessageWebSocket.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IServerMessageWebSocket));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IServerMessageWebSocket, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IServerMessageWebSocket, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IServerMessageWebSocket, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IServerMessageWebSocket, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IServerMessageWebSocket, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IServerMessageWebSocket, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT add_MessageReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerMessageWebSocket_Windows__CNetworking__CSockets__CMessageWebSocketMessageReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IServerMessageWebSocket,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[6])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT remove_MessageReceived(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IServerMessageWebSocket, EventRegistrationToken, int>)(
                (*lpVtbl)[7]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Control(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IServerMessageWebSocketControl **")]
            IServerMessageWebSocketControl* value
    )
    {
        return (
            (delegate* unmanaged<IServerMessageWebSocket, IServerMessageWebSocketControl*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Information(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IServerMessageWebSocketInformation **")]
            IServerMessageWebSocketInformation* value
    )
    {
        return (
            (delegate* unmanaged<
                IServerMessageWebSocket,
                IServerMessageWebSocketInformation*,
                int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_OutputStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream* value
    )
    {
        return ((delegate* unmanaged<IServerMessageWebSocket, IOutputStream*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT add_Closed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerMessageWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* value,
        EventRegistrationToken* token
    )
    {
        return (
            (delegate* unmanaged<
                IServerMessageWebSocket,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[11])
        )(this, value, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT remove_Closed(EventRegistrationToken token)
    {
        return (
            (delegate* unmanaged<IServerMessageWebSocket, EventRegistrationToken, int>)(
                (*lpVtbl)[12]
            )
        )(this, token);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CloseWithStatus([NativeTypeName("UINT16")] ushort code, HSTRING reason)
    {
        return (
            (delegate* unmanaged<IServerMessageWebSocket, ushort, HSTRING, int>)((*lpVtbl)[13])
        )(this, code, reason);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT add_MessageReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerMessageWebSocket_Windows__CNetworking__CSockets__CMessageWebSocketMessageReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(7)]
        HRESULT remove_MessageReceived(EventRegistrationToken token);

        [VtblIndex(8)]
        HRESULT get_Control(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IServerMessageWebSocketControl **")]
                IServerMessageWebSocketControl* value
        );

        [VtblIndex(9)]
        HRESULT get_Information(
            [NativeTypeName(
                "ABI::Windows::Networking::Sockets::IServerMessageWebSocketInformation **"
            )]
                IServerMessageWebSocketInformation* value
        );

        [VtblIndex(10)]
        HRESULT get_OutputStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")]
                IOutputStream* value
        );

        [VtblIndex(11)]
        HRESULT add_Closed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerMessageWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* value,
            EventRegistrationToken* token
        );

        [VtblIndex(12)]
        HRESULT remove_Closed(EventRegistrationToken token);

        [VtblIndex(13)]
        HRESULT CloseWithStatus([NativeTypeName("UINT16")] ushort code, HSTRING reason);
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
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerMessageWebSocket_Windows__CNetworking__CSockets__CMessageWebSocketMessageReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_MessageReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_MessageReceived;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::IServerMessageWebSocketControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IServerMessageWebSocketControl*, int> get_Control;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::IServerMessageWebSocketInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IServerMessageWebSocketInformation*,
            int> get_Information;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IOutputStream*, int> get_OutputStream;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CServerMessageWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_Closed;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_Closed;

        [NativeTypeName("HRESULT (UINT16, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, HSTRING, int> CloseWithStatus;
    }

    /// <summary>Initializes a new instance of the <see cref = "IServerMessageWebSocket"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IServerMessageWebSocket(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IServerMessageWebSocket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IServerMessageWebSocket(Silk.NET.WinRT.IInspectable value)
    {
        return new IServerMessageWebSocket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IServerMessageWebSocket"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IServerMessageWebSocket"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IServerMessageWebSocket value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IServerMessageWebSocket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IServerMessageWebSocket(Silk.NET.Windows.IUnknown value)
    {
        return new IServerMessageWebSocket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IServerMessageWebSocket"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IServerMessageWebSocket"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IServerMessageWebSocket value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
