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

[Guid("8D8A42E4-A87E-4B74-9968-185B2511DEFE")]
[NativeTypeName("struct ISocketActivityInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISocketActivityInformation
    : ISocketActivityInformation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISocketActivityInformation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISocketActivityInformation, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISocketActivityInformation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISocketActivityInformation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<ISocketActivityInformation, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISocketActivityInformation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISocketActivityInformation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_TaskId(Guid* value)
    {
        return ((delegate* unmanaged<ISocketActivityInformation, Guid*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Id(HSTRING* value)
    {
        return ((delegate* unmanaged<ISocketActivityInformation, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_SocketKind(
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketActivityKind *")]
            SocketActivityKind* value
    )
    {
        return (
            (delegate* unmanaged<ISocketActivityInformation, SocketActivityKind*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Context(
        [NativeTypeName("ABI::Windows::Networking::Sockets::ISocketActivityContext **")]
            ISocketActivityContext* value
    )
    {
        return (
            (delegate* unmanaged<ISocketActivityInformation, ISocketActivityContext*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_DatagramSocket(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IDatagramSocket **")]
            IDatagramSocket* value
    )
    {
        return (
            (delegate* unmanaged<ISocketActivityInformation, IDatagramSocket*, int>)((*lpVtbl)[10])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_StreamSocket(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocket **")] IStreamSocket* value
    )
    {
        return (
            (delegate* unmanaged<ISocketActivityInformation, IStreamSocket*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_StreamSocketListener(
        [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListener **")]
            IStreamSocketListener* value
    )
    {
        return (
            (delegate* unmanaged<ISocketActivityInformation, IStreamSocketListener*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_TaskId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_Id(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_SocketKind(
            [NativeTypeName("ABI::Windows::Networking::Sockets::SocketActivityKind *")]
                SocketActivityKind* value
        );

        [VtblIndex(9)]
        HRESULT get_Context(
            [NativeTypeName("ABI::Windows::Networking::Sockets::ISocketActivityContext **")]
                ISocketActivityContext* value
        );

        [VtblIndex(10)]
        HRESULT get_DatagramSocket(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IDatagramSocket **")]
                IDatagramSocket* value
        );

        [VtblIndex(11)]
        HRESULT get_StreamSocket(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocket **")]
                IStreamSocket* value
        );

        [VtblIndex(12)]
        HRESULT get_StreamSocketListener(
            [NativeTypeName("ABI::Windows::Networking::Sockets::IStreamSocketListener **")]
                IStreamSocketListener* value
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_TaskId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Id;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::SocketActivityKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SocketActivityKind*, int> get_SocketKind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::ISocketActivityContext **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ISocketActivityContext*, int> get_Context;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::IDatagramSocket **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDatagramSocket*, int> get_DatagramSocket;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::IStreamSocket **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStreamSocket*, int> get_StreamSocket;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::IStreamSocketListener **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStreamSocketListener*, int> get_StreamSocketListener;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISocketActivityInformation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISocketActivityInformation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISocketActivityInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISocketActivityInformation(Silk.NET.WinRT.IInspectable value)
    {
        return new ISocketActivityInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISocketActivityInformation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISocketActivityInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISocketActivityInformation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISocketActivityInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISocketActivityInformation(Silk.NET.Windows.IUnknown value)
    {
        return new ISocketActivityInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISocketActivityInformation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISocketActivityInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISocketActivityInformation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
