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

[Guid("F877396F-99B1-4E18-BC08-850C9ADF156E")]
[NativeTypeName("struct IWebSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IWebSocket : IWebSocket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWebSocket));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWebSocket, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWebSocket, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWebSocket, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IWebSocket, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IWebSocket, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IWebSocket, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_OutputStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream* value
    )
    {
        return ((delegate* unmanaged<IWebSocket, IOutputStream*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ConnectAsync(
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IWebSocket, IUriRuntimeClass, IAsyncAction*, int>)((*lpVtbl)[7])
        )(this, uri, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetRequestHeader(HSTRING headerName, HSTRING headerValue)
    {
        return ((delegate* unmanaged<IWebSocket, HSTRING, HSTRING, int>)((*lpVtbl)[8]))(
            this,
            headerName,
            headerValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT add_Closed(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CIWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                IWebSocket,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[9])
        )(this, eventHandler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT remove_Closed(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged<IWebSocket, EventRegistrationToken, int>)((*lpVtbl)[10]))(
            this,
            eventCookie
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT CloseWithStatus([NativeTypeName("UINT16")] ushort code, HSTRING reason)
    {
        return ((delegate* unmanaged<IWebSocket, ushort, HSTRING, int>)((*lpVtbl)[11]))(
            this,
            code,
            reason
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_OutputStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")]
                IOutputStream* value
        );

        [VtblIndex(7)]
        HRESULT ConnectAsync(
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(8)]
        HRESULT SetRequestHeader(HSTRING headerName, HSTRING headerValue);

        [VtblIndex(9)]
        HRESULT add_Closed(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CIWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(10)]
        HRESULT remove_Closed(EventRegistrationToken eventCookie);

        [VtblIndex(11)]
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
            "HRESULT (ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IOutputStream*, int> get_OutputStream;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IUriRuntimeClass, IAsyncAction*, int> ConnectAsync;

        [NativeTypeName("HRESULT (HSTRING, HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, HSTRING, int> SetRequestHeader;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CIWebSocket_Windows__CNetworking__CSockets__CWebSocketClosedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
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

    /// <summary>Initializes a new instance of the <see cref = "IWebSocket"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWebSocket(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IWebSocket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IWebSocket(Silk.NET.WinRT.IInspectable value)
    {
        return new IWebSocket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebSocket"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IWebSocket"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IWebSocket value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWebSocket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWebSocket(Silk.NET.Windows.IUnknown value)
    {
        return new IWebSocket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWebSocket"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWebSocket"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWebSocket value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
