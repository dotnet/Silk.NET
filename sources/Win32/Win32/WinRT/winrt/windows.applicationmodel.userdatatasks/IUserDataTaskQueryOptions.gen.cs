// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.applicationmodel.userdatatasks.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("959F27ED-909A-4D30-8C1B-331D8FE667E2")]
[NativeTypeName("struct IUserDataTaskQueryOptions : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IUserDataTaskQueryOptions
    : IUserDataTaskQueryOptions.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IUserDataTaskQueryOptions));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IUserDataTaskQueryOptions, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IUserDataTaskQueryOptions, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IUserDataTaskQueryOptions, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IUserDataTaskQueryOptions, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IUserDataTaskQueryOptions, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IUserDataTaskQueryOptions, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_SortProperty(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQuerySortProperty *"
        )]
            UserDataTaskQuerySortProperty* value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskQueryOptions, UserDataTaskQuerySortProperty*, int>)(
                (*lpVtbl)[6]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_SortProperty(
        [NativeTypeName(
            "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQuerySortProperty"
        )]
            UserDataTaskQuerySortProperty value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskQueryOptions, UserDataTaskQuerySortProperty, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Kind(
        [NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQueryKind *")]
            UserDataTaskQueryKind* value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskQueryOptions, UserDataTaskQueryKind*, int>)(
                (*lpVtbl)[8]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_Kind(
        [NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQueryKind")]
            UserDataTaskQueryKind value
    )
    {
        return (
            (delegate* unmanaged<IUserDataTaskQueryOptions, UserDataTaskQueryKind, int>)(
                (*lpVtbl)[9]
            )
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_SortProperty(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQuerySortProperty *"
            )]
                UserDataTaskQuerySortProperty* value
        );

        [VtblIndex(7)]
        HRESULT put_SortProperty(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQuerySortProperty"
            )]
                UserDataTaskQuerySortProperty value
        );

        [VtblIndex(8)]
        HRESULT get_Kind(
            [NativeTypeName(
                "ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQueryKind *"
            )]
                UserDataTaskQueryKind* value
        );

        [VtblIndex(9)]
        HRESULT put_Kind(
            [NativeTypeName("ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQueryKind")]
                UserDataTaskQueryKind value
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
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQuerySortProperty *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UserDataTaskQuerySortProperty*, int> get_SortProperty;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQuerySortProperty) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UserDataTaskQuerySortProperty, int> put_SortProperty;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQueryKind *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UserDataTaskQueryKind*, int> get_Kind;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::UserDataTasks::UserDataTaskQueryKind) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, UserDataTaskQueryKind, int> put_Kind;
    }

    /// <summary>Initializes a new instance of the <see cref = "IUserDataTaskQueryOptions"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IUserDataTaskQueryOptions(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IUserDataTaskQueryOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IUserDataTaskQueryOptions(Silk.NET.WinRT.IInspectable value)
    {
        return new IUserDataTaskQueryOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataTaskQueryOptions"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataTaskQueryOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IUserDataTaskQueryOptions value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IUserDataTaskQueryOptions"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IUserDataTaskQueryOptions(Silk.NET.Windows.IUnknown value)
    {
        return new IUserDataTaskQueryOptions(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IUserDataTaskQueryOptions"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IUserDataTaskQueryOptions"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IUserDataTaskQueryOptions value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
