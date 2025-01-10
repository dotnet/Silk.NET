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

[Guid("3BB384CB-0760-461D-907F-5138F84D44C1")]
[NativeTypeName("struct IBackgroundUploaderUserConsent : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "IBackgroundUploaderUserConsent is deprecated and may not work on all platforms. For more info, see MSDN."
)]
public unsafe partial struct IBackgroundUploaderUserConsent
    : IBackgroundUploaderUserConsent.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBackgroundUploaderUserConsent));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IBackgroundUploaderUserConsent, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBackgroundUploaderUserConsent, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBackgroundUploaderUserConsent, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IBackgroundUploaderUserConsent, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IBackgroundUploaderUserConsent, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IBackgroundUploaderUserConsent, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "RequestUnconstrainedUploadsAsync is deprecated and may not work on all platforms. For more info, see MSDN."
    )]
    public HRESULT RequestUnconstrainedUploadsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t *"
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
                IBackgroundUploaderUserConsent,
                IIterable<IntPtr>*,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, operations, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "RequestUnconstrainedUploadsAsync is deprecated and may not work on all platforms. For more info, see MSDN."
        )]
        HRESULT RequestUnconstrainedUploadsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t *"
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1_Windows__CNetworking__CBackgroundTransfer__CUploadOperation_t *, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CNetworking__CBackgroundTransfer__CUnconstrainedTransferRequestResult_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "RequestUnconstrainedUploadsAsync is deprecated and may not work on all platforms. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IAsyncOperation<IntPtr>**,
            int> RequestUnconstrainedUploadsAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IBackgroundUploaderUserConsent"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IBackgroundUploaderUserConsent(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IBackgroundUploaderUserConsent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IBackgroundUploaderUserConsent(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IBackgroundUploaderUserConsent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundUploaderUserConsent"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundUploaderUserConsent"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IBackgroundUploaderUserConsent value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IBackgroundUploaderUserConsent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IBackgroundUploaderUserConsent(Silk.NET.Windows.IUnknown value)
    {
        return new IBackgroundUploaderUserConsent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IBackgroundUploaderUserConsent"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IBackgroundUploaderUserConsent"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IBackgroundUploaderUserConsent value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
