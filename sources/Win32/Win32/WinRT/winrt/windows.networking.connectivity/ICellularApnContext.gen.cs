// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.connectivity.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("6FA529F4-EFFD-4542-9AB2-705BBF94943A")]
[NativeTypeName("struct ICellularApnContext : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ICellularApnContext : ICellularApnContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICellularApnContext));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICellularApnContext, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICellularApnContext, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICellularApnContext, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ICellularApnContext, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ICellularApnContext, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ICellularApnContext, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ProviderId(HSTRING* value)
    {
        return ((delegate* unmanaged<ICellularApnContext, HSTRING*, int>)((*lpVtbl)[6]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_ProviderId(HSTRING value)
    {
        return ((delegate* unmanaged<ICellularApnContext, HSTRING, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_AccessPointName(HSTRING* value)
    {
        return ((delegate* unmanaged<ICellularApnContext, HSTRING*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_AccessPointName(HSTRING value)
    {
        return ((delegate* unmanaged<ICellularApnContext, HSTRING, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_UserName(HSTRING* value)
    {
        return ((delegate* unmanaged<ICellularApnContext, HSTRING*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_UserName(HSTRING value)
    {
        return ((delegate* unmanaged<ICellularApnContext, HSTRING, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_Password(HSTRING* value)
    {
        return ((delegate* unmanaged<ICellularApnContext, HSTRING*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_Password(HSTRING value)
    {
        return ((delegate* unmanaged<ICellularApnContext, HSTRING, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsCompressionEnabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<ICellularApnContext, byte*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_IsCompressionEnabled([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<ICellularApnContext, byte, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_AuthenticationType(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::CellularApnAuthenticationType *")]
            CellularApnAuthenticationType* value
    )
    {
        return (
            (delegate* unmanaged<ICellularApnContext, CellularApnAuthenticationType*, int>)(
                (*lpVtbl)[16]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_AuthenticationType(
        [NativeTypeName("ABI::Windows::Networking::Connectivity::CellularApnAuthenticationType")]
            CellularApnAuthenticationType value
    )
    {
        return (
            (delegate* unmanaged<ICellularApnContext, CellularApnAuthenticationType, int>)(
                (*lpVtbl)[17]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ProviderId(HSTRING* value);

        [VtblIndex(7)]
        HRESULT put_ProviderId(HSTRING value);

        [VtblIndex(8)]
        HRESULT get_AccessPointName(HSTRING* value);

        [VtblIndex(9)]
        HRESULT put_AccessPointName(HSTRING value);

        [VtblIndex(10)]
        HRESULT get_UserName(HSTRING* value);

        [VtblIndex(11)]
        HRESULT put_UserName(HSTRING value);

        [VtblIndex(12)]
        HRESULT get_Password(HSTRING* value);

        [VtblIndex(13)]
        HRESULT put_Password(HSTRING value);

        [VtblIndex(14)]
        HRESULT get_IsCompressionEnabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_IsCompressionEnabled([NativeTypeName("boolean")] byte value);

        [VtblIndex(16)]
        HRESULT get_AuthenticationType(
            [NativeTypeName(
                "ABI::Windows::Networking::Connectivity::CellularApnAuthenticationType *"
            )]
                CellularApnAuthenticationType* value
        );

        [VtblIndex(17)]
        HRESULT put_AuthenticationType(
            [NativeTypeName(
                "ABI::Windows::Networking::Connectivity::CellularApnAuthenticationType"
            )]
                CellularApnAuthenticationType value
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

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ProviderId;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_ProviderId;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_AccessPointName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_AccessPointName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_UserName;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_UserName;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_Password;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> put_Password;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsCompressionEnabled;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IsCompressionEnabled;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::CellularApnAuthenticationType *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CellularApnAuthenticationType*,
            int> get_AuthenticationType;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Networking::Connectivity::CellularApnAuthenticationType) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            CellularApnAuthenticationType,
            int> put_AuthenticationType;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICellularApnContext"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICellularApnContext(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ICellularApnContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ICellularApnContext(Silk.NET.WinRT.IInspectable value)
    {
        return new ICellularApnContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICellularApnContext"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ICellularApnContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ICellularApnContext value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICellularApnContext"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICellularApnContext(Silk.NET.Windows.IUnknown value)
    {
        return new ICellularApnContext(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICellularApnContext"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICellularApnContext"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICellularApnContext value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
