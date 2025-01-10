// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.networking.backgroundtransfer.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("5D14E906-9266-4808-BD71-5925F2A3130A")]
[NativeTypeName("struct IBackgroundDownloaderUserConsent : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "IBackgroundDownloaderUserConsent is deprecated and may not work on all platforms. For more info, see MSDN."
)]
public unsafe partial struct IBackgroundDownloaderUserConsent
    : IBackgroundDownloaderUserConsent.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundDownloaderUserConsent));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBackgroundDownloaderUserConsent, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBackgroundDownloaderUserConsent, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundDownloaderUserConsent, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBackgroundDownloaderUserConsent, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IBackgroundDownloaderUserConsent, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBackgroundDownloaderUserConsent, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "RequestUnconstrainedDownloadsAsync is deprecated and may not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT RequestUnconstrainedDownloadsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t *"
        )]
            IIterable<IntPtr>* operations,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUnconstrainedTransferRequestResult_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                IBackgroundDownloaderUserConsent,
                IIterable<IntPtr>*,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, operations, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "RequestUnconstrainedDownloadsAsync is deprecated and may not work on all platforms. For more info, see MSDN."
        )]
        HRESULT RequestUnconstrainedDownloadsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t *"
            )]
                IIterable<IntPtr>* operations,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUnconstrainedTransferRequestResult_t **"
            )]
                IAsyncOperation<IntPtr>** operation
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CDownloadOperation_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUnconstrainedTransferRequestResult_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "RequestUnconstrainedDownloadsAsync is deprecated and may not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IAsyncOperation<IntPtr>**,
            int> RequestUnconstrainedDownloadsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundDownloaderUserConsent"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundDownloaderUserConsent(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundDownloaderUserConsent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundDownloaderUserConsent(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBackgroundDownloaderUserConsent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundDownloaderUserConsent"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundDownloaderUserConsent"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBackgroundDownloaderUserConsent value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundDownloaderUserConsent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundDownloaderUserConsent(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IBackgroundDownloaderUserConsent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundDownloaderUserConsent"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundDownloaderUserConsent"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IBackgroundDownloaderUserConsent value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
