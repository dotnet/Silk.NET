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

[Guid("DBCA4FC3-82B9-4816-9C24-E40E61774BD8")]
[NativeTypeName("struct IRemoteSystemSessionJoinRequestedEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemSessionJoinRequestedEventArgs
    : IRemoteSystemSessionJoinRequestedEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemSessionJoinRequestedEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IRemoteSystemSessionJoinRequestedEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return (
            (delegate* unmanaged<IRemoteSystemSessionJoinRequestedEventArgs, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IRemoteSystemSessionJoinRequestedEventArgs, uint>)((*lpVtbl)[2])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IRemoteSystemSessionJoinRequestedEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IRemoteSystemSessionJoinRequestedEventArgs, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IRemoteSystemSessionJoinRequestedEventArgs, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_JoinRequest(
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSessionJoinRequest **")]
            IRemoteSystemSessionJoinRequest* value
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteSystemSessionJoinRequestedEventArgs,
                IRemoteSystemSessionJoinRequest*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetDeferral(
        [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* result
    )
    {
        return (
            (delegate* unmanaged<IRemoteSystemSessionJoinRequestedEventArgs, IDeferral*, int>)(
                (*lpVtbl)[7]
            )
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_JoinRequest(
            [NativeTypeName(
                "ABI::Windows::System::RemoteSystems::IRemoteSystemSessionJoinRequest **"
            )]
                IRemoteSystemSessionJoinRequest* value
        );

        [VtblIndex(7)]
        HRESULT GetDeferral(
            [NativeTypeName("ABI::Windows::Foundation::IDeferral **")] IDeferral* result
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
            "HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemSessionJoinRequest **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRemoteSystemSessionJoinRequest*, int> get_JoinRequest;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::IDeferral **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IDeferral*, int> GetDeferral;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRemoteSystemSessionJoinRequestedEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRemoteSystemSessionJoinRequestedEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRemoteSystemSessionJoinRequestedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRemoteSystemSessionJoinRequestedEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IRemoteSystemSessionJoinRequestedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemSessionJoinRequestedEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemSessionJoinRequestedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IRemoteSystemSessionJoinRequestedEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRemoteSystemSessionJoinRequestedEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRemoteSystemSessionJoinRequestedEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IRemoteSystemSessionJoinRequestedEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemSessionJoinRequestedEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemSessionJoinRequestedEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IRemoteSystemSessionJoinRequestedEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
