// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.system.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("D7DB7A93-A30C-48B7-9F21-051026A4E517")]
[NativeTypeName("struct IRemoteLauncherStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteLauncherStatics : IRemoteLauncherStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteLauncherStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRemoteLauncherStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRemoteLauncherStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRemoteLauncherStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IRemoteLauncherStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRemoteLauncherStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRemoteLauncherStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LaunchUriAsync(
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")]
            IRemoteSystemConnectionRequest remoteSystemConnectionRequest,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **"
        )]
            IAsyncOperation<RemoteLaunchUriStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteLauncherStatics,
                IRemoteSystemConnectionRequest,
                IUriRuntimeClass,
                IAsyncOperation<RemoteLaunchUriStatus>**,
                int>)((*lpVtbl)[6])
        )(this, remoteSystemConnectionRequest, uri, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT LaunchUriWithOptionsAsync(
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")]
            IRemoteSystemConnectionRequest remoteSystemConnectionRequest,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::System::IRemoteLauncherOptions *")]
            IRemoteLauncherOptions options,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **"
        )]
            IAsyncOperation<RemoteLaunchUriStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteLauncherStatics,
                IRemoteSystemConnectionRequest,
                IUriRuntimeClass,
                IRemoteLauncherOptions,
                IAsyncOperation<RemoteLaunchUriStatus>**,
                int>)((*lpVtbl)[7])
        )(this, remoteSystemConnectionRequest, uri, options, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT LaunchUriWithDataAsync(
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *")]
            IRemoteSystemConnectionRequest remoteSystemConnectionRequest,
        [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
        [NativeTypeName("ABI::Windows::System::IRemoteLauncherOptions *")]
            IRemoteLauncherOptions options,
        [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
            IPropertySet inputData,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **"
        )]
            IAsyncOperation<RemoteLaunchUriStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteLauncherStatics,
                IRemoteSystemConnectionRequest,
                IUriRuntimeClass,
                IRemoteLauncherOptions,
                IPropertySet,
                IAsyncOperation<RemoteLaunchUriStatus>**,
                int>)((*lpVtbl)[8])
        )(this, remoteSystemConnectionRequest, uri, options, inputData, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT LaunchUriAsync(
            [NativeTypeName(
                "ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *"
            )]
                IRemoteSystemConnectionRequest remoteSystemConnectionRequest,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **"
            )]
                IAsyncOperation<RemoteLaunchUriStatus>** operation
        );

        [VtblIndex(7)]
        HRESULT LaunchUriWithOptionsAsync(
            [NativeTypeName(
                "ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *"
            )]
                IRemoteSystemConnectionRequest remoteSystemConnectionRequest,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::System::IRemoteLauncherOptions *")]
                IRemoteLauncherOptions options,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **"
            )]
                IAsyncOperation<RemoteLaunchUriStatus>** operation
        );

        [VtblIndex(8)]
        HRESULT LaunchUriWithDataAsync(
            [NativeTypeName(
                "ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *"
            )]
                IRemoteSystemConnectionRequest remoteSystemConnectionRequest,
            [NativeTypeName("ABI::Windows::Foundation::IUriRuntimeClass *")] IUriRuntimeClass uri,
            [NativeTypeName("ABI::Windows::System::IRemoteLauncherOptions *")]
                IRemoteLauncherOptions options,
            [NativeTypeName("ABI::Windows::Foundation::Collections::IPropertySet *")]
                IPropertySet inputData,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **"
            )]
                IAsyncOperation<RemoteLaunchUriStatus>** operation
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
            "HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRemoteSystemConnectionRequest,
            IUriRuntimeClass,
            IAsyncOperation<RemoteLaunchUriStatus>**,
            int> LaunchUriAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::IRemoteLauncherOptions *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRemoteSystemConnectionRequest,
            IUriRuntimeClass,
            IRemoteLauncherOptions,
            IAsyncOperation<RemoteLaunchUriStatus>**,
            int> LaunchUriWithOptionsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemConnectionRequest *, ABI::Windows::Foundation::IUriRuntimeClass *, ABI::Windows::System::IRemoteLauncherOptions *, ABI::Windows::Foundation::Collections::IPropertySet *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteLaunchUriStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IRemoteSystemConnectionRequest,
            IUriRuntimeClass,
            IRemoteLauncherOptions,
            IPropertySet,
            IAsyncOperation<RemoteLaunchUriStatus>**,
            int> LaunchUriWithDataAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRemoteLauncherStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRemoteLauncherStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRemoteLauncherStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRemoteLauncherStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IRemoteLauncherStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteLauncherStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteLauncherStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRemoteLauncherStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRemoteLauncherStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRemoteLauncherStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IRemoteLauncherStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteLauncherStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteLauncherStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRemoteLauncherStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
