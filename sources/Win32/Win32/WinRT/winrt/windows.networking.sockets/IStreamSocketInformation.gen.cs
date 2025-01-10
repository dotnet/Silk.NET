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

[Guid("3B80AE30-5E68-4205-88F0-DC85D2E25DED")]
[NativeTypeName("struct IStreamSocketInformation : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocketInformation
    : IStreamSocketInformation.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamSocketInformation));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStreamSocketInformation, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStreamSocketInformation, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStreamSocketInformation, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStreamSocketInformation, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStreamSocketInformation, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStreamSocketInformation, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_LocalAddress(
        [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
    )
    {
        return ((delegate* unmanaged<IStreamSocketInformation, IHostName*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_LocalPort(HSTRING* value)
    {
        return ((delegate* unmanaged<IStreamSocketInformation, HSTRING*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_RemoteHostName(
        [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
    )
    {
        return ((delegate* unmanaged<IStreamSocketInformation, IHostName*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_RemoteAddress(
        [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
    )
    {
        return ((delegate* unmanaged<IStreamSocketInformation, IHostName*, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_RemoteServiceName(HSTRING* value)
    {
        return ((delegate* unmanaged<IStreamSocketInformation, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_RemotePort(HSTRING* value)
    {
        return ((delegate* unmanaged<IStreamSocketInformation, HSTRING*, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_RoundTripTimeStatistics(
        [NativeTypeName("ABI::Windows::Networking::Sockets::RoundTripTimeStatistics *")]
            RoundTripTimeStatistics* value
    )
    {
        return (
            (delegate* unmanaged<IStreamSocketInformation, RoundTripTimeStatistics*, int>)(
                (*lpVtbl)[12]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_BandwidthStatistics(
        [NativeTypeName("ABI::Windows::Networking::Sockets::BandwidthStatistics *")]
            BandwidthStatistics* value
    )
    {
        return (
            (delegate* unmanaged<IStreamSocketInformation, BandwidthStatistics*, int>)(
                (*lpVtbl)[13]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_ProtectionLevel(
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")]
            SocketProtectionLevel* value
    )
    {
        return (
            (delegate* unmanaged<IStreamSocketInformation, SocketProtectionLevel*, int>)(
                (*lpVtbl)[14]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_SessionKey(
        [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
    )
    {
        return ((delegate* unmanaged<IStreamSocketInformation, IBuffer*, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_LocalAddress(
            [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
        );

        [VtblIndex(7)]
        HRESULT get_LocalPort(HSTRING* value);

        [VtblIndex(8)]
        HRESULT get_RemoteHostName(
            [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
        );

        [VtblIndex(9)]
        HRESULT get_RemoteAddress(
            [NativeTypeName("ABI::Windows::Networking::IHostName **")] IHostName* value
        );

        [VtblIndex(10)]
        HRESULT get_RemoteServiceName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT get_RemotePort(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_RoundTripTimeStatistics(
            [NativeTypeName("ABI::Windows::Networking::Sockets::RoundTripTimeStatistics *")]
                RoundTripTimeStatistics* value
        );

        [VtblIndex(13)]
        HRESULT get_BandwidthStatistics(
            [NativeTypeName("ABI::Windows::Networking::Sockets::BandwidthStatistics *")]
                BandwidthStatistics* value
        );

        [VtblIndex(14)]
        HRESULT get_ProtectionLevel(
            [NativeTypeName("ABI::Windows::Networking::Sockets::SocketProtectionLevel *")]
                SocketProtectionLevel* value
        );

        [VtblIndex(15)]
        HRESULT get_SessionKey(
            [NativeTypeName("ABI::Windows::Storage::Streams::IBuffer **")] IBuffer* value
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
        public delegate* unmanaged<TSelf*, IHostName*, int> get_LocalAddress;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_LocalPort;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHostName*, int> get_RemoteHostName;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::IHostName **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IHostName*, int> get_RemoteAddress;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RemoteServiceName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_RemotePort;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::RoundTripTimeStatistics *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            RoundTripTimeStatistics*,
            int> get_RoundTripTimeStatistics;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::BandwidthStatistics *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, BandwidthStatistics*, int> get_BandwidthStatistics;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::SocketProtectionLevel *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SocketProtectionLevel*, int> get_ProtectionLevel;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::Streams::IBuffer **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IBuffer*, int> get_SessionKey;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStreamSocketInformation"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStreamSocketInformation(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStreamSocketInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStreamSocketInformation(Silk.NET.WinRT.IInspectable value)
    {
        return new IStreamSocketInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamSocketInformation"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamSocketInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStreamSocketInformation value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStreamSocketInformation"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStreamSocketInformation(Silk.NET.Windows.IUnknown value)
    {
        return new IStreamSocketInformation(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamSocketInformation"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamSocketInformation"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStreamSocketInformation value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
