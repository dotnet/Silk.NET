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

[Guid("9E2DDCA2-1712-4CE4-B179-8C652C6D107E")]
[NativeTypeName("struct IDatagramSocketMessageReceivedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDatagramSocketMessageReceivedEventArgs
    : IDatagramSocketMessageReceivedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDatagramSocketMessageReceivedEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IDatagramSocketMessageReceivedEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDatagramSocketMessageReceivedEventArgs, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDatagramSocketMessageReceivedEventArgs, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IDatagramSocketMessageReceivedEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IDatagramSocketMessageReceivedEventArgs, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IDatagramSocketMessageReceivedEventArgs, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_RemoteAddress(
        [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocketMessageReceivedEventArgs, IHostName*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_RemotePort(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IDatagramSocketMessageReceivedEventArgs, HSTRING*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_LocalAddress(
        [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocketMessageReceivedEventArgs, IHostName*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDataReader(
        [NativeTypeName("ABI::Windows::Storage::Streams::IDataReader **")] IDataReader* dataReader
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocketMessageReceivedEventArgs, IDataReader*, int>)(
                (*lpVtbl)[9]
            )
        )(this, dataReader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDataStream(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")]
            IInputStream* inputStream
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocketMessageReceivedEventArgs, IInputStream*, int>)(
                (*lpVtbl)[10]
            )
        )(this, inputStream);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_RemoteAddress(
            [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
        );

        [VtblIndex(7)]
        HRESULT get_RemotePort(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_LocalAddress(
            [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
        );

        [VtblIndex(9)]
        HRESULT GetDataReader(
            [NativeTypeName("ABI::Windows::Storage::Streams::IDataReader **")]
                IDataReader* dataReader
        );

        [VtblIndex(10)]
        HRESULT GetDataStream(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream **")]
                IInputStream* inputStream
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
            "HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHostName*, int> get_RemoteAddress;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RemotePort;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHostName*, int> get_LocalAddress;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IDataReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDataReader*, int> GetDataReader;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IInputStream*, int> GetDataStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDatagramSocketMessageReceivedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDatagramSocketMessageReceivedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDatagramSocketMessageReceivedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDatagramSocketMessageReceivedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IDatagramSocketMessageReceivedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDatagramSocketMessageReceivedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDatagramSocketMessageReceivedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IDatagramSocketMessageReceivedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDatagramSocketMessageReceivedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDatagramSocketMessageReceivedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IDatagramSocketMessageReceivedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDatagramSocketMessageReceivedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDatagramSocketMessageReceivedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IDatagramSocketMessageReceivedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
