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

[Guid("E30FD791-080C-400A-A712-27DFA9E744D8")]
[NativeTypeName("struct IMessageWebSocketControl2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IMessageWebSocketControl2
    : IMessageWebSocketControl2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMessageWebSocketControl2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMessageWebSocketControl2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IMessageWebSocketControl2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMessageWebSocketControl2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IMessageWebSocketControl2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IMessageWebSocketControl2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IMessageWebSocketControl2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_DesiredUnsolicitedPongInterval(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IMessageWebSocketControl2, TimeSpan*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_DesiredUnsolicitedPongInterval(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
    )
    {
        return ((delegate* unmanaged<IMessageWebSocketControl2, TimeSpan, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_ActualUnsolicitedPongInterval(
        [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
    )
    {
        return ((delegate* unmanaged<IMessageWebSocketControl2, TimeSpan*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_ReceiveMode(
        [NativeTypeName("ABI::Windows::Networking::Sockets::MessageWebSocketReceiveMode *")]
            MessageWebSocketReceiveMode* value
    )
    {
        return (
            (delegate* unmanaged<IMessageWebSocketControl2, MessageWebSocketReceiveMode*, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_ReceiveMode(
        [NativeTypeName("ABI::Windows::Networking::Sockets::MessageWebSocketReceiveMode")]
            MessageWebSocketReceiveMode value
    )
    {
        return (
            (delegate* unmanaged<IMessageWebSocketControl2, MessageWebSocketReceiveMode, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ClientCertificate(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")]
            ICertificate* value
    )
    {
        return (
            (delegate* unmanaged<IMessageWebSocketControl2, ICertificate*, int>)((*lpVtbl)[11])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_ClientCertificate(
        [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")]
            ICertificate value
    )
    {
        return ((delegate* unmanaged<IMessageWebSocketControl2, ICertificate, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_DesiredUnsolicitedPongInterval(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(7)]
        HRESULT put_DesiredUnsolicitedPongInterval(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan")] TimeSpan value
        );

        [VtblIndex(8)]
        HRESULT get_ActualUnsolicitedPongInterval(
            [NativeTypeName("ABI::Windows::Foundation::TimeSpan *")] TimeSpan* value
        );

        [VtblIndex(9)]
        HRESULT get_ReceiveMode(
            [NativeTypeName("ABI::Windows::Networking::Sockets::MessageWebSocketReceiveMode *")]
                MessageWebSocketReceiveMode* value
        );

        [VtblIndex(10)]
        HRESULT put_ReceiveMode(
            [NativeTypeName("ABI::Windows::Networking::Sockets::MessageWebSocketReceiveMode")]
                MessageWebSocketReceiveMode value
        );

        [VtblIndex(11)]
        HRESULT get_ClientCertificate(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate **")]
                ICertificate* value
        );

        [VtblIndex(12)]
        HRESULT put_ClientCertificate(
            [NativeTypeName("ABI::Windows::Security::Cryptography::Certificates::ICertificate *")]
                ICertificate value
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

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_DesiredUnsolicitedPongInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan, int> put_DesiredUnsolicitedPongInterval;

        [NativeTypeName("HRESULT (ABI::Windows::Foundation::TimeSpan *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TimeSpan*, int> get_ActualUnsolicitedPongInterval;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::MessageWebSocketReceiveMode *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MessageWebSocketReceiveMode*, int> get_ReceiveMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::MessageWebSocketReceiveMode) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, MessageWebSocketReceiveMode, int> put_ReceiveMode;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICertificate*, int> get_ClientCertificate;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Security::Cryptography::Certificates::ICertificate *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ICertificate, int> put_ClientCertificate;
    }

    /// <summary>Initializes a new instance of the <see cref = "IMessageWebSocketControl2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IMessageWebSocketControl2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IMessageWebSocketControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IMessageWebSocketControl2(Silk.NET.WinRT.IInspectable value)
    {
        return new IMessageWebSocketControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMessageWebSocketControl2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IMessageWebSocketControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IMessageWebSocketControl2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IMessageWebSocketControl2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IMessageWebSocketControl2(Silk.NET.Windows.IUnknown value)
    {
        return new IMessageWebSocketControl2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IMessageWebSocketControl2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IMessageWebSocketControl2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IMessageWebSocketControl2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
