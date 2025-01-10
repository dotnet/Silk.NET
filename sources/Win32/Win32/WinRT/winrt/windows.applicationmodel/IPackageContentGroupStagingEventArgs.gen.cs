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

[Guid("3D7BC27E-6F27-446C-986E-D4733D4D9113")]
[NativeTypeName("struct IPackageContentGroupStagingEventArgs : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageContentGroupStagingEventArgs
    : IPackageContentGroupStagingEventArgs.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageContentGroupStagingEventArgs));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IPackageContentGroupStagingEventArgs, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IPackageContentGroupStagingEventArgs, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPackageContentGroupStagingEventArgs, uint>)((*lpVtbl)[2]))(
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
            (delegate* unmanaged<IPackageContentGroupStagingEventArgs, uint*, Guid**, int>)(
                (*lpVtbl)[3]
            )
        )(this, iidCount, iids);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return (
            (delegate* unmanaged<IPackageContentGroupStagingEventArgs, HSTRING*, int>)((*lpVtbl)[4])
        )(this, className);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return (
            (delegate* unmanaged<IPackageContentGroupStagingEventArgs, TrustLevel*, int>)(
                (*lpVtbl)[5]
            )
        )(this, trustLevel);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_ActivityId(Guid* value)
    {
        return (
            (delegate* unmanaged<IPackageContentGroupStagingEventArgs, Guid*, int>)((*lpVtbl)[6])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Package(
        [NativeTypeName("ABI::Windows::ApplicationModel::IPackage **")] IPackage* value
    )
    {
        return (
            (delegate* unmanaged<IPackageContentGroupStagingEventArgs, IPackage*, int>)(
                (*lpVtbl)[7]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Progress(double* value)
    {
        return (
            (delegate* unmanaged<IPackageContentGroupStagingEventArgs, double*, int>)((*lpVtbl)[8])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_IsComplete([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<IPackageContentGroupStagingEventArgs, byte*, int>)((*lpVtbl)[9])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ErrorCode(HRESULT* value)
    {
        return (
            (delegate* unmanaged<IPackageContentGroupStagingEventArgs, HRESULT*, int>)(
                (*lpVtbl)[10]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_ContentGroupName(HSTRING* value)
    {
        return (
            (delegate* unmanaged<IPackageContentGroupStagingEventArgs, HSTRING*, int>)(
                (*lpVtbl)[11]
            )
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_IsContentGroupRequired([NativeTypeName("boolean *")] byte* value)
    {
        return (
            (delegate* unmanaged<IPackageContentGroupStagingEventArgs, byte*, int>)((*lpVtbl)[12])
        )(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_ActivityId(Guid* value);

        [VtblIndex(7)]
        HRESULT get_Package(
            [NativeTypeName("ABI::Windows::ApplicationModel::IPackage **")] IPackage* value
        );

        [VtblIndex(8)]
        HRESULT get_Progress(double* value);

        [VtblIndex(9)]
        HRESULT get_IsComplete([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_ErrorCode(HRESULT* value);

        [VtblIndex(11)]
        HRESULT get_ContentGroupName(HSTRING* value);

        [VtblIndex(12)]
        HRESULT get_IsContentGroupRequired([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> get_ActivityId;

        [NativeTypeName(
            "HRESULT (ABI::Windows::ApplicationModel::IPackage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPackage*, int> get_Package;

        [NativeTypeName("HRESULT (DOUBLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_Progress;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsComplete;

        [NativeTypeName("HRESULT (HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HRESULT*, int> get_ErrorCode;

        [NativeTypeName("HRESULT (HSTRING *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HSTRING*, int> get_ContentGroupName;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_IsContentGroupRequired;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPackageContentGroupStagingEventArgs"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPackageContentGroupStagingEventArgs(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPackageContentGroupStagingEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPackageContentGroupStagingEventArgs(
        Silk.NET.WinRT.IInspectable value
    )
    {
        return new IPackageContentGroupStagingEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackageContentGroupStagingEventArgs"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPackageContentGroupStagingEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(
        IPackageContentGroupStagingEventArgs value
    )
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPackageContentGroupStagingEventArgs"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPackageContentGroupStagingEventArgs(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IPackageContentGroupStagingEventArgs(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackageContentGroupStagingEventArgs"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPackageContentGroupStagingEventArgs"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IPackageContentGroupStagingEventArgs value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
