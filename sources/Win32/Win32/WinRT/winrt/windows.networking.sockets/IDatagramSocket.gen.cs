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

[Guid("7FE25BBB-C3BC-4677-8446-CA28A465A3AF")]
[NativeTypeName("struct IDatagramSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDatagramSocket : IDatagramSocket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDatagramSocket));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDatagramSocket, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDatagramSocket, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDatagramSocket, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDatagramSocket, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDatagramSocket, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDatagramSocket, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Control(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IDatagramSocketControl **")]
            IDatagramSocketControl* value
    )
    {
        return ((delegate* unmanaged<IDatagramSocket, IDatagramSocketControl*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Information(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IDatagramSocketInformation **")]
            IDatagramSocketInformation* value
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocket, IDatagramSocketInformation*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutputStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream* value
    )
    {
        return ((delegate* unmanaged<IDatagramSocket, IOutputStream*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT ConnectAsync(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName remoteHostName,
        HSTRING remoteServiceName,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocket, IHostName, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[9]
            )
        )(this, remoteHostName, remoteServiceName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ConnectWithEndpointPairAsync(
        [NativeTypeName("ABI::Windows::Networking::IEndpointPair *")] IEndpointPair endpointPair,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocket, IEndpointPair, IAsyncAction*, int>)((*lpVtbl)[10])
        )(this, endpointPair, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT BindServiceNameAsync(
        HSTRING localServiceName,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return ((delegate* unmanaged<IDatagramSocket, HSTRING, IAsyncAction*, int>)((*lpVtbl)[11]))(
            this,
            localServiceName,
            operation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT BindEndpointAsync(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName localHostName,
        HSTRING localServiceName,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocket, IHostName, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[12]
            )
        )(this, localHostName, localServiceName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT JoinMulticastGroup(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName host
    )
    {
        return ((delegate* unmanaged<IDatagramSocket, IHostName, int>)((*lpVtbl)[13]))(this, host);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetOutputStreamAsync(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName remoteHostName,
        HSTRING remoteServiceName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIOutputStream_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<
                IDatagramSocket,
                IHostName,
                HSTRING,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[14])
        )(this, remoteHostName, remoteServiceName, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetOutputStreamWithEndpointPairAsync(
        [NativeTypeName("ABI::Windows::Networking::IEndpointPair *")] IEndpointPair endpointPair,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIOutputStream_t **"
        )]
            IAsyncOperation<IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocket, IEndpointPair, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[15]
            )
        )(this, endpointPair, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT add_MessageReceived(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CDatagramSocket_Windows__CNetworking__CSockets__CDatagramSocketMessageReceivedEventArgs_t *"
        )]
            ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
        EventRegistrationToken* eventCookie
    )
    {
        return (
            (delegate* unmanaged<
                IDatagramSocket,
                ITypedEventHandler<IntPtr, IntPtr>*,
                EventRegistrationToken*,
                int>)((*lpVtbl)[16])
        )(this, eventHandler, eventCookie);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT remove_MessageReceived(EventRegistrationToken eventCookie)
    {
        return ((delegate* unmanaged<IDatagramSocket, EventRegistrationToken, int>)((*lpVtbl)[17]))(
            this,
            eventCookie
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Control(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IDatagramSocketControl **")]
                IDatagramSocketControl* value
        );

        [VtblIndex(7)]
        HRESULT get_Information(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IDatagramSocketInformation **")]
                IDatagramSocketInformation* value
        );

        [VtblIndex(8)]
        HRESULT get_OutputStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")]
                IOutputStream* value
        );

        [VtblIndex(9)]
        HRESULT ConnectAsync(
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName remoteHostName,
            HSTRING remoteServiceName,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(10)]
        HRESULT ConnectWithEndpointPairAsync(
            [NativeTypeName("ABI::Windows::Networking::IEndpointPair *")]
                IEndpointPair endpointPair,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(11)]
        HRESULT BindServiceNameAsync(
            HSTRING localServiceName,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(12)]
        HRESULT BindEndpointAsync(
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName localHostName,
            HSTRING localServiceName,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(13)]
        HRESULT JoinMulticastGroup(
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName host
        );

        [VtblIndex(14)]
        HRESULT GetOutputStreamAsync(
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName remoteHostName,
            HSTRING remoteServiceName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIOutputStream_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(15)]
        HRESULT GetOutputStreamWithEndpointPairAsync(
            [NativeTypeName("ABI::Windows::Networking::IEndpointPair *")]
                IEndpointPair endpointPair,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIOutputStream_t **"
            )]
                IAsyncOperation<IntPtr>** value
        );

        [VtblIndex(16)]
        HRESULT add_MessageReceived(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CDatagramSocket_Windows__CNetworking__CSockets__CDatagramSocketMessageReceivedEventArgs_t *"
            )]
                ITypedEventHandler<IntPtr, IntPtr>* eventHandler,
            EventRegistrationToken* eventCookie
        );

        [VtblIndex(17)]
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
            "HRESULT (ABI::Windows::Networking::Sockets::IDatagramSocketControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDatagramSocketControl*, int> get_Control;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::IDatagramSocketInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDatagramSocketInformation*, int> get_Information;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IOutputStream*, int> get_OutputStream;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHostName, HSTRING, IAsyncAction*, int> ConnectAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IEndpointPair *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEndpointPair,
            IAsyncAction*,
            int> ConnectWithEndpointPairAsync;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, IAsyncAction*, int> BindServiceNameAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHostName,
            HSTRING,
            IAsyncAction*,
            int> BindEndpointAsync;

        [NativeTypeName("HRESULT (ABI::Windows::Networking::IHostName *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHostName, int> JoinMulticastGroup;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIOutputStream_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHostName,
            HSTRING,
            IAsyncOperation<IntPtr>**,
            int> GetOutputStreamAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IEndpointPair *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CStorage__CStreams__CIOutputStream_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEndpointPair,
            IAsyncOperation<IntPtr>**,
            int> GetOutputStreamWithEndpointPairAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FITypedEventHandler_2_Windows__CNetworking__CSockets__CDatagramSocket_Windows__CNetworking__CSockets__CDatagramSocketMessageReceivedEventArgs_t *, EventRegistrationToken *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ITypedEventHandler<IntPtr, IntPtr>*,
            EventRegistrationToken*,
            int> add_MessageReceived;

        [NativeTypeName("HRESULT (EventRegistrationToken) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, EventRegistrationToken, int> remove_MessageReceived;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDatagramSocket"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDatagramSocket(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDatagramSocket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDatagramSocket(Silk.NET.WinRT.IInspectable value)
    {
        return new IDatagramSocket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDatagramSocket"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDatagramSocket"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDatagramSocket value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDatagramSocket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDatagramSocket(Silk.NET.Windows.IUnknown value)
    {
        return new IDatagramSocket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDatagramSocket"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDatagramSocket"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDatagramSocket value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
