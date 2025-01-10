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

[Guid("9A2A4338-24FB-4269-89C5-88304AEEF20F")]
[NativeTypeName("struct ISpatialAnchorExporter : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAnchorExporter : ISpatialAnchorExporter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAnchorExporter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAnchorExporter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpatialAnchorExporter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAnchorExporter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpatialAnchorExporter, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpatialAnchorExporter, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpatialAnchorExporter, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAnchorExportSufficiencyAsync(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")]
            ISpatialAnchor anchor,
        [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialAnchorExportPurpose")]
            SpatialAnchorExportPurpose purpose,
        [NativeTypeName(
            "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialAnchorExportSufficiency_t **"
        )]
            IAsyncOperation<IntPtr>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAnchorExporter,
                ISpatialAnchor,
                SpatialAnchorExportPurpose,
                IAsyncOperation<IntPtr>**,
                int>)((*lpVtbl)[6])
        )(this, anchor, purpose, operation);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TryExportAnchorAsync(
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")]
            ISpatialAnchor anchor,
        [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialAnchorExportPurpose")]
            SpatialAnchorExportPurpose purpose,
        [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")] IOutputStream stream,
        [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
            IAsyncOperation<byte>** operation
    )
    {
        return (
            (delegate* unmanaged<
                ISpatialAnchorExporter,
                ISpatialAnchor,
                SpatialAnchorExportPurpose,
                IOutputStream,
                IAsyncOperation<byte>**,
                int>)((*lpVtbl)[7])
        )(this, anchor, purpose, stream, operation);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAnchorExportSufficiencyAsync(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")]
                ISpatialAnchor anchor,
            [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialAnchorExportPurpose")]
                SpatialAnchorExportPurpose purpose,
            [NativeTypeName(
                "ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialAnchorExportSufficiency_t **"
            )]
                IAsyncOperation<IntPtr>** operation
        );

        [VtblIndex(7)]
        HRESULT TryExportAnchorAsync(
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")]
                ISpatialAnchor anchor,
            [NativeTypeName("ABI::Windows::Perception::Spatial::SpatialAnchorExportPurpose")]
                SpatialAnchorExportPurpose purpose,
            [NativeTypeName("ABI::Windows::Storage::Streams::IOutputStream *")]
                IOutputStream stream,
            [NativeTypeName("ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **")]
                IAsyncOperation<byte>** operation
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
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialAnchor *, ABI::Windows::Perception::Spatial::SpatialAnchorExportPurpose, ABI::Windows::Foundation::__FIAsyncOperation_1_Windows__CPerception__CSpatial__CSpatialAnchorExportSufficiency_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialAnchor,
            SpatialAnchorExportPurpose,
            IAsyncOperation<IntPtr>**,
            int> GetAnchorExportSufficiencyAsync;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Perception::Spatial::ISpatialAnchor *, ABI::Windows::Perception::Spatial::SpatialAnchorExportPurpose, ABI::Windows::Storage::Streams::IOutputStream *, ABI::Windows::Foundation::__FIAsyncOperation_1_boolean_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ISpatialAnchor,
            SpatialAnchorExportPurpose,
            IOutputStream,
            IAsyncOperation<byte>**,
            int> TryExportAnchorAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAnchorExporter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAnchorExporter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpatialAnchorExporter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpatialAnchorExporter(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpatialAnchorExporter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAnchorExporter"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAnchorExporter"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpatialAnchorExporter value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAnchorExporter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAnchorExporter(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialAnchorExporter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAnchorExporter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAnchorExporter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialAnchorExporter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
