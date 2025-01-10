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

[Guid("AC831E2D-66C5-56D7-A4CE-705D94925AD6")]
[NativeTypeName("struct IRemoteSystemConnectionInfoStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemConnectionInfoStatics
    : IRemoteSystemConnectionInfoStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemConnectionInfoStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IRemoteSystemConnectionInfoStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRemoteSystemConnectionInfoStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRemoteSystemConnectionInfoStatics, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IRemoteSystemConnectionInfoStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IRemoteSystemConnectionInfoStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IRemoteSystemConnectionInfoStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT TryCreateFromAppServiceConnection(
        [NativeTypeName("ABI::Windows::ApplicationModel::AppService::IAppServiceConnection *")]
            IAppServiceConnection connection,
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionInfo **")]
            IRemoteSystemConnectionInfo* result
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteSystemConnectionInfoStatics,
                IAppServiceConnection,
                IRemoteSystemConnectionInfo*,
                int>)((*lpVtbl)[6])
        )(this, connection, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT TryCreateFromAppServiceConnection(
            [NativeTypeName("ABI::Windows::ApplicationModel::AppService::IAppServiceConnection *")]
                IAppServiceConnection connection,
            [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionInfo **")]
                IRemoteSystemConnectionInfo* result
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
            "HRESULT (ABI::Windows::ApplicationModel::AppService::IAppServiceConnection *, ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionInfo **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppServiceConnection,
            IRemoteSystemConnectionInfo*,
            int> TryCreateFromAppServiceConnection;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRemoteSystemConnectionInfoStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRemoteSystemConnectionInfoStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRemoteSystemConnectionInfoStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRemoteSystemConnectionInfoStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IRemoteSystemConnectionInfoStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemConnectionInfoStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemConnectionInfoStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IRemoteSystemConnectionInfoStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRemoteSystemConnectionInfoStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRemoteSystemConnectionInfoStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IRemoteSystemConnectionInfoStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemConnectionInfoStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemConnectionInfoStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IRemoteSystemConnectionInfoStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
