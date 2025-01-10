// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.perception.spatial.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("03BBF9B9-12D8-4BCE-8835-C5DF3AC0ADAB")]
[NativeTypeName("struct ISpatialAnchorTransferManagerStatics : IInspectable")]
[NativeInheritance("IInspectable")]
[Obsolete(
    "Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN."
)]
public unsafe partial struct ISpatialAnchorTransferManagerStatics
    : ISpatialAnchorTransferManagerStatics.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAnchorTransferManagerStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ISpatialAnchorTransferManagerStatics, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpatialAnchorTransferManagerStatics, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAnchorTransferManagerStatics, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<ISpatialAnchorTransferManagerStatics, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<ISpatialAnchorTransferManagerStatics, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<ISpatialAnchorTransferManagerStatics, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    [Obsolete(
        "Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN."
    )]
    public HRESULT TryImportAnchorsAsync(
        [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream stream,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAnchorTransferManagerStatics,
                IInputStream,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, stream, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    [Obsolete(
        "Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN."
    )]
    public HRESULT TryExportAnchorsAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t *"
        )]
            IIterable<IntPtr>* anchors,
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream stream,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAnchorTransferManagerStatics,
                IIterable<IntPtr>*,
                IOutputStream,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[7])
        )(this, anchors, stream, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    [Obsolete(
        "Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN."
    )]
    public HRESULT RequestAccessAsync(
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialPerceptionAccessStatus_t **"
        )]
            IAsyncOperation<SpatialPerceptionAccessStatus>** result
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAnchorTransferManagerStatics,
                IAsyncOperation<SpatialPerceptionAccessStatus>**,
                int>)((*lpVtbl)[8])
        )(this, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        [Obsolete(
            "Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN."
        )]
        HRESULT TryImportAnchorsAsync(
            [NativeTypeName("ABI::Windows::Storage::Streams::IInputStream *")] IInputStream stream,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        [Obsolete(
            "Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN."
        )]
        HRESULT TryExportAnchorsAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t *"
            )]
                IIterable<IntPtr>* anchors,
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
                IOutputStream stream,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
        );

        [VtblIndex(8)]
        [Obsolete(
            "Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN."
        )]
        HRESULT RequestAccessAsync(
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialPerceptionAccessStatus_t **"
            )]
                IAsyncOperation<SpatialPerceptionAccessStatus>** result
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
            "HRESULT (ABI::Windows::Storage::Streams::IInputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1___FIMapView_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IInputStream,
            IAsyncOperation<IntPtr>**,
            int> TryImportAnchorsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::Collections::__FIIterable_1___FIKeyValuePair_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t *, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IIterable<IntPtr>*,
            IOutputStream,
            IAsyncOperation<byte>**,
            int> TryExportAnchorsAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialPerceptionAccessStatus_t **) __attribute__((stdcall))"
        )]
        [Obsolete(
            "Use SpatialEntityStore instead of SpatialAnchorTransferManager. For more info, see MSDN."
        )]
        public delegate* unmanaged<
            TSelf*,
            IAsyncOperation<SpatialPerceptionAccessStatus>**,
            int> RequestAccessAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAnchorTransferManagerStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAnchorTransferManagerStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpatialAnchorTransferManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpatialAnchorTransferManagerStatics(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new ISpatialAnchorTransferManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAnchorTransferManagerStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAnchorTransferManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        ISpatialAnchorTransferManagerStatics value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAnchorTransferManagerStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAnchorTransferManagerStatics(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ISpatialAnchorTransferManagerStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAnchorTransferManagerStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAnchorTransferManagerStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ISpatialAnchorTransferManagerStatics value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
