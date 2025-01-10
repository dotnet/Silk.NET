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

[Guid("52AC3F2E-349A-4135-BB58-B79B2647D390")]
[NativeTypeName("struct IDatagramSocketControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IDatagramSocketControl : IDatagramSocketControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDatagramSocketControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDatagramSocketControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDatagramSocketControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDatagramSocketControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IDatagramSocketControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IDatagramSocketControl, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IDatagramSocketControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_QualityOfService(
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService *")]
            SocketQualityOfService* value
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocketControl, SocketQualityOfService*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_QualityOfService(
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService")]
            SocketQualityOfService value
    )
    {
        return (
            (delegate* unmanaged<IDatagramSocketControl, SocketQualityOfService, int>)((*lpVtbl)[7])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_OutboundUnicastHopLimit(byte* value)
    {
        return ((delegate* unmanaged<IDatagramSocketControl, byte*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_OutboundUnicastHopLimit(byte value)
    {
        return ((delegate* unmanaged<IDatagramSocketControl, byte, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_QualityOfService(
            [NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService *")]
                SocketQualityOfService* value
        );

        [VtblIndex(7)]
        HRESULT put_QualityOfService(
            [NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService")]
                SocketQualityOfService value
        );

        [VtblIndex(8)]
        HRESULT get_OutboundUnicastHopLimit(byte* value);

        [VtblIndex(9)]
        HRESULT put_OutboundUnicastHopLimit(byte value);
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
            "HRESULT (ABI::Windows::Networking::Sockets::SocketQualityOfService *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SocketQualityOfService*, int> get_QualityOfService;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Sockets::SocketQualityOfService) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, SocketQualityOfService, int> put_QualityOfService;

        [NativeTypeName("HRESULT (BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_OutboundUnicastHopLimit;

        [NativeTypeName("HRESULT (BYTE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_OutboundUnicastHopLimit;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDatagramSocketControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDatagramSocketControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IDatagramSocketControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IDatagramSocketControl(Silk.NET.WinRT.IInspectable value)
    {
        return new IDatagramSocketControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDatagramSocketControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IDatagramSocketControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IDatagramSocketControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDatagramSocketControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDatagramSocketControl(Silk.NET.Windows.IUnknown value)
    {
        return new IDatagramSocketControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDatagramSocketControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDatagramSocketControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDatagramSocketControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
