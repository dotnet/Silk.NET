// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.storage.search.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1DC7A369-B7A3-4DF2-9D61-EBA85A0343D2")]
[NativeTypeName("struct IStorageLibraryChangeTrackerTriggerDetails : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageLibraryChangeTrackerTriggerDetails
    : IStorageLibraryChangeTrackerTriggerDetails.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageLibraryChangeTrackerTriggerDetails));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails, Guid*, void**, int>)(
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
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails, uint>)((*lpVtbl)[2])
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
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Folder(
        [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
    )
    {
        return (
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerDetails, IStorageFolder*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ChangeTracker(
        [NativeTypeName("ABI::Windows::Storage::IStorageLibraryChangeTracker **")]
            IStorageLibraryChangeTracker* value
    )
    {
        return (
            (delegate* unmanaged<
                IStorageLibraryChangeTrackerTriggerDetails,
                IStorageLibraryChangeTracker*,
                int>)((*lpVtbl)[7])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Folder(
            [NativeTypeName("ABI::Windows::Storage::IStorageFolder **")] IStorageFolder* value
        );

        [VtblIndex(7)]
        HRESULT get_ChangeTracker(
            [NativeTypeName("ABI::Windows::Storage::IStorageLibraryChangeTracker **")]
                IStorageLibraryChangeTracker* value
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
            "HRESULT (ABI::Windows::Storage::IStorageFolder **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageFolder*, int> get_Folder;

        [NativeTypeName(
            "HRESULT (ABI::Windows::Storage::IStorageLibraryChangeTracker **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IStorageLibraryChangeTracker*, int> get_ChangeTracker;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageLibraryChangeTrackerTriggerDetails"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageLibraryChangeTrackerTriggerDetails(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageLibraryChangeTrackerTriggerDetails"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageLibraryChangeTrackerTriggerDetails(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IStorageLibraryChangeTrackerTriggerDetails(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageLibraryChangeTrackerTriggerDetails"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageLibraryChangeTrackerTriggerDetails"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IStorageLibraryChangeTrackerTriggerDetails value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageLibraryChangeTrackerTriggerDetails"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageLibraryChangeTrackerTriggerDetails(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IStorageLibraryChangeTrackerTriggerDetails(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageLibraryChangeTrackerTriggerDetails"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageLibraryChangeTrackerTriggerDetails"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IStorageLibraryChangeTrackerTriggerDetails value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
