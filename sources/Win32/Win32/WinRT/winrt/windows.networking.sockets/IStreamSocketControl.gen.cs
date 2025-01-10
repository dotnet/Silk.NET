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

[Guid("FE25ADF1-92AB-4AF3-9992-0F4C85E36CC4")]
[NativeTypeName("struct IStreamSocketControl : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStreamSocketControl : IStreamSocketControl.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStreamSocketControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStreamSocketControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStreamSocketControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStreamSocketControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IStreamSocketControl, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IStreamSocketControl, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IStreamSocketControl, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_NoDelay([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IStreamSocketControl, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_NoDelay([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IStreamSocketControl, byte, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_KeepAlive([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IStreamSocketControl, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_KeepAlive([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IStreamSocketControl, byte, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_OutboundBufferSizeInBytes([NativeTypeName("UINT32 *")] uint* value)
    {
        return ((delegate* unmanaged<IStreamSocketControl, uint*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_OutboundBufferSizeInBytes([NativeTypeName("UINT32")] uint value)
    {
        return ((delegate* unmanaged<IStreamSocketControl, uint, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_QualityOfService(
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService *")]
            SocketQualityOfService* value
    )
    {
        return (
            (delegate* unmanaged<IStreamSocketControl, SocketQualityOfService*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_QualityOfService(
        [NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService")]
            SocketQualityOfService value
    )
    {
        return (
            (delegate* unmanaged<IStreamSocketControl, SocketQualityOfService, int>)((*lpVtbl)[13])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_OutboundUnicastHopLimit(byte* value)
    {
        return ((delegate* unmanaged<IStreamSocketControl, byte*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_OutboundUnicastHopLimit(byte value)
    {
        return ((delegate* unmanaged<IStreamSocketControl, byte, int>)((*lpVtbl)[15]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_NoDelay([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT put_NoDelay([NativeTypeName("boolean")] byte value);

        [VtblIndex(8)]
        HRESULT get_KeepAlive([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_KeepAlive([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_OutboundBufferSizeInBytes([NativeTypeName("UINT32 *")] uint* value);

        [VtblIndex(11)]
        HRESULT put_OutboundBufferSizeInBytes([NativeTypeName("UINT32")] uint value);

        [VtblIndex(12)]
        HRESULT get_QualityOfService(
            [NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService *")]
                SocketQualityOfService* value
        );

        [VtblIndex(13)]
        HRESULT put_QualityOfService(
            [NativeTypeName("ABI::Windows::Networking::Sockets::SocketQualityOfService")]
                SocketQualityOfService value
        );

        [VtblIndex(14)]
        HRESULT get_OutboundUnicastHopLimit(byte* value);

        [VtblIndex(15)]
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_NoDelay;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_NoDelay;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_KeepAlive;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_KeepAlive;

        [NativeTypeName("HRESULT (UINT32 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> get_OutboundBufferSizeInBytes;

        [NativeTypeName("HRESULT (UINT32) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> put_OutboundBufferSizeInBytes;

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

    /// <summary>Initializes a new instance of the <see cref = "IStreamSocketControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStreamSocketControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStreamSocketControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStreamSocketControl(Silk.NET.WinRT.IInspectable value)
    {
        return new IStreamSocketControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamSocketControl"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamSocketControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IStreamSocketControl value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStreamSocketControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStreamSocketControl(Silk.NET.Windows.IUnknown value)
    {
        return new IStreamSocketControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStreamSocketControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStreamSocketControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStreamSocketControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
