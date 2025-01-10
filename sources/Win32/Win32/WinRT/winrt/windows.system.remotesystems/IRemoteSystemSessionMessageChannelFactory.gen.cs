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

[Guid("295E1C4A-BD16-4298-B7CE-415482B0E11D")]
[NativeTypeName("struct IRemoteSystemSessionMessageChannelFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemSessionMessageChannelFactory
    : IRemoteSystemSessionMessageChannelFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemSessionMessageChannelFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IRemoteSystemSessionMessageChannelFactory, Guid*, void**, int>)(
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
            (delegate* unmanaged<IRemoteSystemSessionMessageChannelFactory, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IRemoteSystemSessionMessageChannelFactory, uint>)((*lpVtbl)[2])
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
            (delegate* unmanaged<IRemoteSystemSessionMessageChannelFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IRemoteSystemSessionMessageChannelFactory, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IRemoteSystemSessionMessageChannelFactory, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSession *")]
            IRemoteSystemSession session,
        HSTRING channelName,
        [NativeTypeName(
            "ABI::Windows::System::RemoteSystems::IRemoteSystemSessionMessageChannel **"
        )]
            IRemoteSystemSessionMessageChannel* value
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteSystemSessionMessageChannelFactory,
                IRemoteSystemSession,
                HSTRING,
                IRemoteSystemSessionMessageChannel*,
                int>)((*lpVtbl)[6])
        )(this, session, channelName, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWithReliability(
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSession *")]
            IRemoteSystemSession session,
        HSTRING channelName,
        [NativeTypeName(
            "ABI::Windows::System::RemoteSystems::RemoteSystemSessionMessageChannelReliability"
        )]
            RemoteSystemSessionMessageChannelReliability reliability,
        [NativeTypeName(
            "ABI::Windows::System::RemoteSystems::IRemoteSystemSessionMessageChannel **"
        )]
            IRemoteSystemSessionMessageChannel* value
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteSystemSessionMessageChannelFactory,
                IRemoteSystemSession,
                HSTRING,
                RemoteSystemSessionMessageChannelReliability,
                IRemoteSystemSessionMessageChannel*,
                int>)((*lpVtbl)[7])
        )(this, session, channelName, reliability, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSession *")]
                IRemoteSystemSession session,
            HSTRING channelName,
            [NativeTypeName(
                "ABI::Windows::System::RemoteSystems::IRemoteSystemSessionMessageChannel **"
            )]
                IRemoteSystemSessionMessageChannel* value
        );

        [VtblIndex(7)]
        HRESULT CreateWithReliability(
            [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemSession *")]
                IRemoteSystemSession session,
            HSTRING channelName,
            [NativeTypeName(
                "ABI::Windows::System::RemoteSystems::RemoteSystemSessionMessageChannelReliability"
            )]
                RemoteSystemSessionMessageChannelReliability reliability,
            [NativeTypeName(
                "ABI::Windows::System::RemoteSystems::IRemoteSystemSessionMessageChannel **"
            )]
                IRemoteSystemSessionMessageChannel* value
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
            "HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemSession *, HSTRING, ABI::Windows::System::RemoteSystems::IRemoteSystemSessionMessageChannel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRemoteSystemSession,
            HSTRING,
            IRemoteSystemSessionMessageChannel*,
            int> Create;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemSession *, HSTRING, ABI::Windows::System::RemoteSystems::RemoteSystemSessionMessageChannelReliability, ABI::Windows::System::RemoteSystems::IRemoteSystemSessionMessageChannel **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRemoteSystemSession,
            HSTRING,
            RemoteSystemSessionMessageChannelReliability,
            IRemoteSystemSessionMessageChannel*,
            int> CreateWithReliability;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRemoteSystemSessionMessageChannelFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRemoteSystemSessionMessageChannelFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRemoteSystemSessionMessageChannelFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRemoteSystemSessionMessageChannelFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IRemoteSystemSessionMessageChannelFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemSessionMessageChannelFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemSessionMessageChannelFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IRemoteSystemSessionMessageChannelFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRemoteSystemSessionMessageChannelFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRemoteSystemSessionMessageChannelFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IRemoteSystemSessionMessageChannelFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemSessionMessageChannelFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemSessionMessageChannelFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IRemoteSystemSessionMessageChannelFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
