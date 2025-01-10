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

[Guid("B0BC3636-486A-3CB0-9E6F-1245165C4DB6")]
[NativeTypeName("struct ISpatialAnchorStore : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct ISpatialAnchorStore : ISpatialAnchorStore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpatialAnchorStore));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpatialAnchorStore, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpatialAnchorStore, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpatialAnchorStore, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<ISpatialAnchorStore, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<ISpatialAnchorStore, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<ISpatialAnchorStore, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetAllSavedAnchors(
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t **"
        )]
            IMapView<HSTRING, IntPtr>** value
    )
    {
        return (
            (delegate* unmanaged<ISpatialAnchorStore, IMapView<HSTRING, IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT TrySave(
        HSTRING id,
        [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")]
            ISpatialAnchor anchor,
        [NativeTypeName("boolean *")] byte* succeeded
    )
    {
        return (
            (delegate* unmanaged<ISpatialAnchorStore, HSTRING, ISpatialAnchor, byte*, int>)(
                (*lpVtbl)[7]
            )
        )(this, id, anchor, succeeded);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Remove(HSTRING id)
    {
        return ((delegate* unmanaged<ISpatialAnchorStore, HSTRING, int>)((*lpVtbl)[8]))(this, id);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Clear()
    {
        return ((delegate* unmanaged<ISpatialAnchorStore, int>)((*lpVtbl)[9]))(this);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT GetAllSavedAnchors(
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t **"
            )]
                IMapView<HSTRING, IntPtr>** value
        );

        [VtblIndex(7)]
        HRESULT TrySave(
            HSTRING id,
            [NativeTypeName("ABI::Windows::Perception::Spatial::ISpatialAnchor *")]
                ISpatialAnchor anchor,
            [NativeTypeName("boolean *")] byte* succeeded
        );

        [VtblIndex(8)]
        HRESULT Remove(HSTRING id);

        [VtblIndex(9)]
        HRESULT Clear();
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
            "HRESULT (ABI::Windows::Foundation::Collections::__FIMapView_2_HSTRING_Windows__CPerception__CSpatial__CSpatialAnchor_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IMapView<HSTRING, IntPtr>**, int> GetAllSavedAnchors;

        [NativeTypeName(
            "HRESULT (HSTRING, ABI::Windows::Perception::Spatial::ISpatialAnchor *, boolean *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HSTRING, ISpatialAnchor, byte*, int> TrySave;

        [NativeTypeName("HRESULT (HSTRING) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING, int> Remove;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Clear;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpatialAnchorStore"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpatialAnchorStore(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "ISpatialAnchorStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator ISpatialAnchorStore(Silk.NET.WinRT.IInspectable value)
    {
        return new ISpatialAnchorStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAnchorStore"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAnchorStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(ISpatialAnchorStore value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpatialAnchorStore"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpatialAnchorStore(Silk.NET.Windows.IUnknown value)
    {
        return new ISpatialAnchorStore(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpatialAnchorStore"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpatialAnchorStore"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpatialAnchorStore value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
