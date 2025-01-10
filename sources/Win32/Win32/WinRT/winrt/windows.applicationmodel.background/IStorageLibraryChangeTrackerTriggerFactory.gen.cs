// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.background.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("1EB0FFD0-5A85-499E-A888-824607124F50")]
[NativeTypeName("struct IStorageLibraryChangeTrackerTriggerFactory : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IStorageLibraryChangeTrackerTriggerFactory
    : IStorageLibraryChangeTrackerTriggerFactory.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)
            Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageLibraryChangeTrackerTriggerFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerFactory, Guid*, void**, int>)(
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
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerFactory, uint>)((*lpVtbl)[1])
        )(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return (
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerFactory, uint>)((*lpVtbl)[2])
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
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerFactory, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerFactory, HSTRING*, int>)(
                (*lpVtbl)[4]
            )
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IStorageLibraryChangeTrackerTriggerFactory, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Create(
        [NativeTypeName("ABI::Windows::Storage::IStorageLibraryChangeTracker *")]
            IStorageLibraryChangeTracker tracker,
        [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")]
            IBackgroundTrigger* result
    )
    {
        return (
            (delegate* unmanaged<
                IStorageLibraryChangeTrackerTriggerFactory,
                IStorageLibraryChangeTracker,
                IBackgroundTrigger*,
                int>)((*lpVtbl)[6])
        )(this, tracker, result);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT Create(
            [NativeTypeName("ABI::Windows::Storage::IStorageLibraryChangeTracker *")]
                IStorageLibraryChangeTracker tracker,
            [NativeTypeName("ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **")]
                IBackgroundTrigger* result
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
            "HRESULT (ABI::Windows::Storage::IStorageLibraryChangeTracker *, ABI::Windows::ApplicationModel::Background::IBackgroundTrigger **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStorageLibraryChangeTracker,
            IBackgroundTrigger*,
            int> Create;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageLibraryChangeTrackerTriggerFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageLibraryChangeTrackerTriggerFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IStorageLibraryChangeTrackerTriggerFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IStorageLibraryChangeTrackerTriggerFactory(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IStorageLibraryChangeTrackerTriggerFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageLibraryChangeTrackerTriggerFactory"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageLibraryChangeTrackerTriggerFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IStorageLibraryChangeTrackerTriggerFactory value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageLibraryChangeTrackerTriggerFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageLibraryChangeTrackerTriggerFactory(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IStorageLibraryChangeTrackerTriggerFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageLibraryChangeTrackerTriggerFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageLibraryChangeTrackerTriggerFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IStorageLibraryChangeTrackerTriggerFactory value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
