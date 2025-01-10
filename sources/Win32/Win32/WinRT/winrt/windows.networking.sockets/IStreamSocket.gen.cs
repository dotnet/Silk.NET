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

[Guid("69A22CF3-FC7B-4857-AF38-F6E7DE6A5B49")]
[NativeTypeName("struct IStreamSocket : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocket : IStreamSocket.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamSocket));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStreamSocket, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStreamSocket, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStreamSocket, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStreamSocket, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStreamSocket, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStreamSocket, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Control(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketControl **")]
            IStreamSocketControl* value
    )
    {
        return ((delegate* unmanaged<IStreamSocket, IStreamSocketControl*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Information(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketInformation **")]
            IStreamSocketInformation* value
    )
    {
        return ((delegate* unmanaged<IStreamSocket, IStreamSocketInformation*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_InputStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream* value
    )
    {
        return ((delegate* unmanaged<IStreamSocket, IInputStream*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_OutputStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")] IOutputStream* value
    )
    {
        return ((delegate* unmanaged<IStreamSocket, IOutputStream*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ConnectWithEndpointPairAsync(
        [NativeTypeName("ABI::Windows::Networking::IEndpointPair *")] IEndpointPair endpointPair,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IStreamSocket, IEndpointPair, IAsyncAction*, int>)((*lpVtbl)[10])
        )(this, endpointPair, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT ConnectAsync(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName remoteHostName,
        HSTRING remoteServiceName,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<IStreamSocket, IHostName, HSTRING, IAsyncAction*, int>)(
                (*lpVtbl)[11]
            )
        )(this, remoteHostName, remoteServiceName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ConnectWithEndpointPairAndProtectionLevelAsync(
        [NativeTypeName("ABI::Windows::Networking::IEndpointPair *")] IEndpointPair endpointPair,
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")]
            SocketProtectionLevel protectionLevel,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IStreamSocket,
                IEndpointPair,
                SocketProtectionLevel,
                IAsyncAction*,
                int>)((*lpVtbl)[12])
        )(this, endpointPair, protectionLevel, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT ConnectWithProtectionLevelAsync(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName remoteHostName,
        HSTRING remoteServiceName,
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")]
            SocketProtectionLevel protectionLevel,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IStreamSocket,
                IHostName,
                HSTRING,
                SocketProtectionLevel,
                IAsyncAction*,
                int>)((*lpVtbl)[13])
        )(this, remoteHostName, remoteServiceName, protectionLevel, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT UpgradeToSslAsync(
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")]
            SocketProtectionLevel protectionLevel,
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName validationHostName,
        [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
    )
    {
        return (
            (delegate* unmanaged<
                IStreamSocket,
                SocketProtectionLevel,
                IHostName,
                IAsyncAction*,
                int>)((*lpVtbl)[14])
        )(this, protectionLevel, validationHostName, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Control(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketControl **")]
                IStreamSocketControl* value
        );

        [VtblIndex(7)]
        HRESULT get_Information(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketInformation **")]
                IStreamSocketInformation* value
        );

        [VtblIndex(8)]
        HRESULT get_InputStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")] IInputStream* value
        );

        [VtblIndex(9)]
        HRESULT get_OutputStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream **")]
                IOutputStream* value
        );

        [VtblIndex(10)]
        HRESULT ConnectWithEndpointPairAsync(
            [NativeTypeName("ABI::Windows::Networking::IEndpointPair *")]
                IEndpointPair endpointPair,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(11)]
        HRESULT ConnectAsync(
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName remoteHostName,
            HSTRING remoteServiceName,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(12)]
        HRESULT ConnectWithEndpointPairAndProtectionLevelAsync(
            [NativeTypeName("ABI::Windows::Networking::IEndpointPair *")]
                IEndpointPair endpointPair,
            [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")]
                SocketProtectionLevel protectionLevel,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(13)]
        HRESULT ConnectWithProtectionLevelAsync(
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName remoteHostName,
            HSTRING remoteServiceName,
            [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")]
                SocketProtectionLevel protectionLevel,
            [NativeTypeName("ABI::Windows::Foundation::IAsyncAction **")] IAsyncAction* operation
        );

        [VtblIndex(14)]
        HRESULT UpgradeToSslAsync(
            [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel")]
                SocketProtectionLevel protectionLevel,
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName validationHostName,
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
            "HRESULT (ABI::Windows::Networking::Sockets::IStreamSocketControl **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStreamSocketControl*, int> get_Control;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::IStreamSocketInformation **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStreamSocketInformation*, int> get_Information;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IInputStream*, int> get_InputStream;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IOutputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IOutputStream*, int> get_OutputStream;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IEndpointPair *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEndpointPair,
            IAsyncAction*,
            int> ConnectWithEndpointPairAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHostName, HSTRING, IAsyncAction*, int> ConnectAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IEndpointPair *, ABI::Windows::Networking::Sockets::SocketProtectionLevel, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IEndpointPair,
            SocketProtectionLevel,
            IAsyncAction*,
            int> ConnectWithEndpointPairAndProtectionLevelAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName *, HSTRING, ABI::Windows::Networking::Sockets::SocketProtectionLevel, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHostName,
            HSTRING,
            SocketProtectionLevel,
            IAsyncAction*,
            int> ConnectWithProtectionLevelAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::SocketProtectionLevel, ABI::Windows::Networking::IHostName *, ABI::Windows::Foundation::IAsyncAction **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            SocketProtectionLevel,
            IHostName,
            IAsyncAction*,
            int> UpgradeToSslAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStreamSocket"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStreamSocket(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStreamSocket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStreamSocket(Silk.NET.WinRT.IInspectable value)
    {
        return new IStreamSocket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamSocket"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamSocket"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStreamSocket value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStreamSocket"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStreamSocket(Silk.NET.Windows.IUnknown value)
    {
        return new IStreamSocket(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamSocket"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamSocket"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStreamSocket value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
