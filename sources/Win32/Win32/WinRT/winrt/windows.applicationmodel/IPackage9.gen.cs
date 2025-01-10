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

[Guid("D5AB224F-D7E1-49EC-90CE-720CDBD02E9C")]
[NativeTypeName("struct IPackage9 : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackage9 : IPackage9.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackage9));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPackage9, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPackage9, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPackage9, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPackage9, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPackage9, HSTRING*, int>)((*lpVtbl)[4]))(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPackage9, TrustLevel*, int>)((*lpVtbl)[5]))(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindRelatedPackages(
        [NativeTypeName("ABI::Windows::ApplicationModel::IFindRelatedPackagesOptions *")]
            IFindRelatedPackagesOptions options,
        [NativeTypeName(
            "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CPackage_t **"
        )]
            IVector<IntPtr>** result
    )
    {
        return (
            (delegate* unmanaged<IPackage9, IFindRelatedPackagesOptions, IVector<IntPtr>**, int>)(
                (*lpVtbl)[6]
            )
        )(this, options, result);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_SourceUriSchemeName(HSTRING* value)
    {
        return ((delegate* unmanaged<IPackage9, HSTRING*, int>)((*lpVtbl)[7]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT FindRelatedPackages(
            [NativeTypeName("ABI::Windows::ApplicationModel::IFindRelatedPackagesOptions *")]
                IFindRelatedPackagesOptions options,
            [NativeTypeName(
                "ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CPackage_t **"
            )]
                IVector<IntPtr>** result
        );

        [VtblIndex(7)]
        HRESULT get_SourceUriSchemeName(HSTRING* value);
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
            "HRESULT (ABI::Windows::ApplicationModel::IFindRelatedPackagesOptions *, ABI::Windows::Foundation::Collections::__FIVector_1_Windows__CApplicationModel__CPackage_t **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IFindRelatedPackagesOptions,
            IVector<IntPtr>**,
            int> FindRelatedPackages;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_SourceUriSchemeName;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPackage9"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPackage9(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPackage9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPackage9(Silk.NET.WinRT.IInspectable value)
    {
        return new IPackage9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackage9"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPackage9"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPackage9 value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPackage9"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPackage9(Silk.NET.Windows.IUnknown value)
    {
        return new IPackage9(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackage9"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPackage9"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPackage9 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
