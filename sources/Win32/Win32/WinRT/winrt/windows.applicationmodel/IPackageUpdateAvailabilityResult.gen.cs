// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("114E5009-199A-48A1-A079-313C45634A71")]
[NativeTypeName("struct IPackageUpdateAvailabilityResult : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageUpdateAvailabilityResult
    : IPackageUpdateAvailabilityResult.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageUpdateAvailabilityResult));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPackageUpdateAvailabilityResult, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPackageUpdateAvailabilityResult, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPackageUpdateAvailabilityResult, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IPackageUpdateAvailabilityResult, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IPackageUpdateAvailabilityResult, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPackageUpdateAvailabilityResult, TrustLevel*, int>)((*lpVtbl)[5])
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Availability(
        [NativeTypeName("ABI::Windows::ApplicationModel::PackageUpdateAvailability *")]
            PackageUpdateAvailability* value
    )
    {
        return (
            (delegate* unmanaged<
                IPackageUpdateAvailabilityResult,
                PackageUpdateAvailability*,
                int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_ExtendedError(HRESULT* value)
    {
        return (
            (delegate* unmanaged<IPackageUpdateAvailabilityResult, HRESULT*, int>)((*lpVtbl)[7])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Availability(
            [NativeTypeName("ABI::Windows::ApplicationModel::PackageUpdateAvailability *")]
                PackageUpdateAvailability* value
        );

        [VtblIndex(7)]
        HRESULT get_ExtendedError(HRESULT* value);
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
            "HRESULT (ABI::Windows::ApplicationModel::PackageUpdateAvailability *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PackageUpdateAvailability*, int> get_Availability;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT*, int> get_ExtendedError;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPackageUpdateAvailabilityResult"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPackageUpdateAvailabilityResult(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPackageUpdateAvailabilityResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPackageUpdateAvailabilityResult(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPackageUpdateAvailabilityResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackageUpdateAvailabilityResult"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPackageUpdateAvailabilityResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPackageUpdateAvailabilityResult value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPackageUpdateAvailabilityResult"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPackageUpdateAvailabilityResult(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPackageUpdateAvailabilityResult(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackageUpdateAvailabilityResult"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPackageUpdateAvailabilityResult"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPackageUpdateAvailabilityResult value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
