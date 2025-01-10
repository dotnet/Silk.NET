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

[Guid("33727D08-34D5-4746-AD7B-8DDE5BC2EF88")]
[NativeTypeName("struct IMessageWebSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMessageWebSocket : IMessageWebSocket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMessageWebSocket));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMessageWebSocket, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMessageWebSocket, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMessageWebSocket, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMessageWebSocket, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMessageWebSocket, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMessageWebSocket, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Control(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IMessageWebSocketControl **")]
            IMessageWebSocketControl* value
    )
    {
        return (
            (delegate* unmanaged<IMessageWebSocket, IMessageWebSocketControl*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Information(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IWebSocketInformation **")]
            IWebSocketInformation* value
    )
    {
        return (
            (delegate* unmanaged<IMessageWebSocket, IWebSocketInformation*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add_MessageReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CMessageWebSocket_Windows__CNetworking__CSockets__CMessageWebSocketMessageReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                IMessageWebSocket,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[8])
        )(this, eventHandler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove_MessageReceived(EventRegistrationToken eventCookie)
    {
        return (
            (delegate* unmanaged<IMessageWebSocket, EventRegistrationToken, int>)((*lpVtbl)[9])
        )(this, eventCookie);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Control(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IMessageWebSocketControl **")]
                IMessageWebSocketControl* value
        );

        [VtblIndex(7)]
        HRESULT get_Information(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IWebSocketInformation **")]
                IWebSocketInformation* value
        );

        [VtblIndex(8)]
        HRESULT add_MessageReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CMessageWebSocket_Windows__CNetworking__CSockets__CMessageWebSocketMessageReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(9)]
        HRESULT remove_MessageReceived(EventRegistrationToken eventCookie);
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
            "HRESULT (ABI::Windows::Networking::Sockets::IMessageWebSocketControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMessageWebSocketControl*, int> get_Control;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::IWebSocketInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IWebSocketInformation*, int> get_Information;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CMessageWebSocket_Windows__CNetworking__CSockets__CMessageWebSocketMessageReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_MessageReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_MessageReceived;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMessageWebSocket"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMessageWebSocket(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMessageWebSocket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMessageWebSocket(Silk.NET.WinRT.IInspectable value)
    {
        return new IMessageWebSocket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMessageWebSocket"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMessageWebSocket"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMessageWebSocket value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMessageWebSocket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMessageWebSocket(Silk.NET.Windows.IUnknown value)
    {
        return new IMessageWebSocket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMessageWebSocket"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMessageWebSocket"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMessageWebSocket value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
