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

[Guid("A485B392-FF2B-4B47-BE62-743F2F140F30")]
[NativeTypeName("struct IRemoteSystemStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IRemoteSystemStatics : IRemoteSystemStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRemoteSystemStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRemoteSystemStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IRemoteSystemStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRemoteSystemStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IRemoteSystemStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IRemoteSystemStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IRemoteSystemStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindByHostNameAsync(
        [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName hostName,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystem_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<IRemoteSystemStatics, IHostName, IAsyncOperation<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, hostName, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateWatcher(
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **")]
            IRemoteSystemWatcher* result
    )
    {
        return (
            (delegate* unmanaged<IRemoteSystemStatics, IRemoteSystemWatcher*, int>)((*lpVtbl)[7])
        )(this, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT CreateWatcherWithFilters(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CRemoteSystems__CIRemoteSystemFilter_t *"
        )]
            IIterable<IntPtr>* filters,
        [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **")]
            IRemoteSystemWatcher* result
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteSystemStatics,
                IIterable<IntPtr>*,
                IRemoteSystemWatcher*,
                int>)((*lpVtbl)[8])
        )(this, filters, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RequestAccessAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystemAccessStatus_t **"
        )]
            IAsyncOperation<RemoteSystemAccessStatus>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IRemoteSystemStatics,
                IAsyncOperation<RemoteSystemAccessStatus>**,
                int>)((*lpVtbl)[9])
        )(this, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindByHostNameAsync(
            [NativeTypeName("ABI::Windows::Networking::IHostName *")] IHostName hostName,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystem_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT CreateWatcher(
            [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **")]
                IRemoteSystemWatcher* result
        );

        [VtblIndex(8)]
        HRESULT CreateWatcherWithFilters(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CRemoteSystems__CIRemoteSystemFilter_t *"
            )]
                IIterable<IntPtr>* filters,
            [NativeTypeName("ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **")]
                IRemoteSystemWatcher* result
        );

        [VtblIndex(9)]
        HRESULT RequestAccessAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystemAccessStatus_t **"
            )]
                IAsyncOperation<RemoteSystemAccessStatus>** operation
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
            "HRESULT (ABI::Windows::Networking::IHostName *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystem_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IHostName,
            IAsyncOperation<IntPtr>**,
            int> FindByHostNameAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IRemoteSystemWatcher*, int> CreateWatcher;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CSystem__CRemoteSystems__CIRemoteSystemFilter_t *, ABI::Windows::System::RemoteSystems::IRemoteSystemWatcher **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IRemoteSystemWatcher*,
            int> CreateWatcherWithFilters;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CSystem__CRemoteSystems__CRemoteSystemAccessStatus_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<RemoteSystemAccessStatus>**,
            int> RequestAccessAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRemoteSystemStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRemoteSystemStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IRemoteSystemStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IRemoteSystemStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IRemoteSystemStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IRemoteSystemStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRemoteSystemStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRemoteSystemStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IRemoteSystemStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRemoteSystemStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRemoteSystemStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRemoteSystemStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
