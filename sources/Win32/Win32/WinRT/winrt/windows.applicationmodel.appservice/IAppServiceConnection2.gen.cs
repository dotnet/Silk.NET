// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.appservice.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("8BDFCD5F-2302-4FBD-8061-52511C2F8BF9")]
[NativeTypeName("struct IAppServiceConnection2 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IAppServiceConnection2 : IAppServiceConnection2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppServiceConnection2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppServiceConnection2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppServiceConnection2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppServiceConnection2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IAppServiceConnection2, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IAppServiceConnection2, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IAppServiceConnection2, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenRemoteAsync(
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")]
            IRemoteSystemConnectionRequest remoteSystemConnectionRequest,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CAppServiceConnectionStatus_t **"
        )]
            IAsyncOperation<AppServiceConnectionStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IAppServiceConnection2,
                IRemoteSystemConnectionRequest,
                IAsyncOperation<AppServiceConnectionStatus>**,
                int>)((*lpVtbl)[6])
        )(this, remoteSystemConnectionRequest, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* value)
    {
        return ((delegate* unmanaged<IAppServiceConnection2, IUser*, int>)((*lpVtbl)[7]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT put_User([NativeTypeName("ABI::Windows::System::IUser *")] IUser value)
    {
        return ((delegate* unmanaged<IAppServiceConnection2, IUser, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT OpenRemoteAsync(
            [NativeTypeName(
                "ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *"
            )]
                IRemoteSystemConnectionRequest remoteSystemConnectionRequest,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CAppServiceConnectionStatus_t **"
            )]
                IAsyncOperation<AppServiceConnectionStatus>** operation
        );

        [VtblIndex(7)]
        HRESULT get_User([NativeTypeName("ABI::Windows::System::IUser **")] IUser* value);

        [VtblIndex(8)]
        HRESULT put_User([NativeTypeName("ABI::Windows::System::IUser *")] IUser value);
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
            "HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CApplicationModel__CAppService__CAppServiceConnectionStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRemoteSystemConnectionRequest,
            IAsyncOperation<AppServiceConnectionStatus>**,
            int> OpenRemoteAsync;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUser*, int> get_User;

        [NativeTypeName("HRESULT (ABI::Windows::System::IUser *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUser, int> put_User;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppServiceConnection2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppServiceConnection2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IAppServiceConnection2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IAppServiceConnection2(Silk.NET.WinRT.IInspectable value)
    {
        return new IAppServiceConnection2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppServiceConnection2"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IAppServiceConnection2"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IAppServiceConnection2 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppServiceConnection2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppServiceConnection2(Silk.NET.Windows.IUnknown value)
    {
        return new IAppServiceConnection2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppServiceConnection2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppServiceConnection2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppServiceConnection2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
