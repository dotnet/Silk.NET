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

[Guid("4E534BDF-2960-4878-97A4-9624DEB72F2D")]
[NativeTypeName("struct IPackageStatics : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageStatics : IPackageStatics.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageStatics));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPackageStatics, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPackageStatics, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPackageStatics, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPackageStatics, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPackageStatics, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPackageStatics, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT get_Current(
        [NativeTypeName("ABI::Windows::ApplicationModel::IPackage **")] IPackage* value
    )
    {
        return ((delegate* unmanaged<IPackageStatics, IPackage*, int>)((*lpVtbl)[6]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT get_Current(
            [NativeTypeName("ABI::Windows::ApplicationModel::IPackage **")] IPackage* value
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
            "HRESULT (ABI::Windows::ApplicationModel::IPackage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IPackage*, int> get_Current;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPackageStatics"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPackageStatics(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPackageStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPackageStatics(Silk.NET.WinRT.IInspectable value)
    {
        return new IPackageStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackageStatics"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPackageStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPackageStatics value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPackageStatics"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPackageStatics(Silk.NET.Windows.IUnknown value)
    {
        return new IPackageStatics(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackageStatics"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPackageStatics"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPackageStatics value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
