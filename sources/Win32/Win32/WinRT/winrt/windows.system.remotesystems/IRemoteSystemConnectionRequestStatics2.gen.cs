// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.remotesystems.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("460F1027-64EC-598E-A800-4F2EE58DEF19")]
[NativeTypeName("struct IRemoteSystemConnectionRequestStatics2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemConnectionRequestStatics2
    : IRemoteSystemConnectionRequestStatics2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemConnectionRequestStatics2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IRemoteSystemConnectionRequestStatics2, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRemoteSystemConnectionRequestStatics2, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRemoteSystemConnectionRequestStatics2, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IRemoteSystemConnectionRequestStatics2, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IRemoteSystemConnectionRequestStatics2, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IRemoteSystemConnectionRequestStatics2, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateFromConnectionToken(
        HSTRING connectionToken,
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest **")]
            IRemoteSystemConnectionRequest* result
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteSystemConnectionRequestStatics2,
                HSTRING,
                IRemoteSystemConnectionRequest*,
                int>)((*lpVtbl)[6])
        )(this, connectionToken, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateFromConnectionTokenForUser(
        [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
        HSTRING connectionToken,
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest **")]
            IRemoteSystemConnectionRequest* result
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteSystemConnectionRequestStatics2,
                IUser,
                HSTRING,
                IRemoteSystemConnectionRequest*,
                int>)((*lpVtbl)[7])
        )(this, user, connectionToken, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT CreateFromConnectionToken(
            HSTRING connectionToken,
            [NativeTypeName(
                "ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest **"
            )]
                IRemoteSystemConnectionRequest* result
        );

        [VtblIndex(7)]
        HRESULT CreateFromConnectionTokenForUser(
            [NativeTypeName("ABI::Windows::System::IUser *")] IUser user,
            HSTRING connectionToken,
            [NativeTypeName(
                "ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest **"
            )]
                IRemoteSystemConnectionRequest* result
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
            "HRESULT (HSTRING, ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HSTRING,
            IRemoteSystemConnectionRequest*,
            int> CreateFromConnectionToken;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::IUser *, HSTRING, ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUser,
            HSTRING,
            IRemoteSystemConnectionRequest*,
            int> CreateFromConnectionTokenForUser;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRemoteSystemConnectionRequestStatics2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRemoteSystemConnectionRequestStatics2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRemoteSystemConnectionRequestStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRemoteSystemConnectionRequestStatics2(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IRemoteSystemConnectionRequestStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemConnectionRequestStatics2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemConnectionRequestStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IRemoteSystemConnectionRequestStatics2 value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRemoteSystemConnectionRequestStatics2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRemoteSystemConnectionRequestStatics2(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IRemoteSystemConnectionRequestStatics2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemConnectionRequestStatics2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemConnectionRequestStatics2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IRemoteSystemConnectionRequestStatics2 value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
