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

[Guid("41DD7EEA-B335-521F-B96C-5EA07F5B7329")]
[NativeTypeName("struct IFindRelatedPackagesOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IFindRelatedPackagesOptions
    : IFindRelatedPackagesOptions.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFindRelatedPackagesOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IFindRelatedPackagesOptions, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFindRelatedPackagesOptions, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFindRelatedPackagesOptions, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return (
            (delegate* unmanaged<IFindRelatedPackagesOptions, uint*, Guid**, int>)((*lpVtbl)[3])
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IFindRelatedPackagesOptions, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IFindRelatedPackagesOptions, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Relationship(
        [NativeTypeName("ABI::Windows::ApplicationModel::PackageRelationship *")]
            PackageRelationship* value
    )
    {
        return (
            (delegate* unmanaged<IFindRelatedPackagesOptions, PackageRelationship*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_Relationship(
        [NativeTypeName("ABI::Windows::ApplicationModel::PackageRelationship")]
            PackageRelationship value
    )
    {
        return (
            (delegate* unmanaged<IFindRelatedPackagesOptions, PackageRelationship, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_IncludeFrameworks([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IFindRelatedPackagesOptions, byte*, int>)((*lpVtbl)[8]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_IncludeFrameworks([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IFindRelatedPackagesOptions, byte, int>)((*lpVtbl)[9]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_IncludeHostRuntimes([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IFindRelatedPackagesOptions, byte*, int>)((*lpVtbl)[10]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_IncludeHostRuntimes([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IFindRelatedPackagesOptions, byte, int>)((*lpVtbl)[11]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IncludeOptionals([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IFindRelatedPackagesOptions, byte*, int>)((*lpVtbl)[12]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_IncludeOptionals([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IFindRelatedPackagesOptions, byte, int>)((*lpVtbl)[13]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IncludeResources([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IFindRelatedPackagesOptions, byte*, int>)((*lpVtbl)[14]))(
            this,
            value
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_IncludeResources([NativeTypeName("boolean")] byte value)
    {
        return ((delegate* unmanaged<IFindRelatedPackagesOptions, byte, int>)((*lpVtbl)[15]))(
            this,
            value
        );
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Relationship(
            [NativeTypeName("ABI::Windows::ApplicationModel::PackageRelationship *")]
                PackageRelationship* value
        );

        [VtblIndex(7)]
        HRESULT put_Relationship(
            [NativeTypeName("ABI::Windows::ApplicationModel::PackageRelationship")]
                PackageRelationship value
        );

        [VtblIndex(8)]
        HRESULT get_IncludeFrameworks([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT put_IncludeFrameworks([NativeTypeName("boolean")] byte value);

        [VtblIndex(10)]
        HRESULT get_IncludeHostRuntimes([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT put_IncludeHostRuntimes([NativeTypeName("boolean")] byte value);

        [VtblIndex(12)]
        HRESULT get_IncludeOptionals([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT put_IncludeOptionals([NativeTypeName("boolean")] byte value);

        [VtblIndex(14)]
        HRESULT get_IncludeResources([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT put_IncludeResources([NativeTypeName("boolean")] byte value);
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
            "HRESULT (ABI::Windows::ApplicationModel::PackageRelationship *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PackageRelationship*, int> get_Relationship;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::PackageRelationship) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, PackageRelationship, int> put_Relationship;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IncludeFrameworks;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IncludeFrameworks;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IncludeHostRuntimes;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IncludeHostRuntimes;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IncludeOptionals;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IncludeOptionals;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IncludeResources;

        [NativeTypeName("HRESULT (boolean) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte, int> put_IncludeResources;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFindRelatedPackagesOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFindRelatedPackagesOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IFindRelatedPackagesOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IFindRelatedPackagesOptions(Silk.NET.WinRT.IInspectable value)
    {
        return new IFindRelatedPackagesOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFindRelatedPackagesOptions"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IFindRelatedPackagesOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IFindRelatedPackagesOptions value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFindRelatedPackagesOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFindRelatedPackagesOptions(Silk.NET.Windows.IUnknown value)
    {
        return new IFindRelatedPackagesOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFindRelatedPackagesOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFindRelatedPackagesOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFindRelatedPackagesOptions value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
