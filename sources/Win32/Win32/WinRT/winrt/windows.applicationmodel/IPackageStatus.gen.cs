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

[Guid("5FE74F71-A365-4C09-A02D-046D525EA1DA")]
[NativeTypeName("struct IPackageStatus : IInspectable")]
[NativeInheritance("IInspectable")]
public unsafe partial struct IPackageStatus : IPackageStatus.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPackageStatus));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPackageStatus, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPackageStatus, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPackageStatus, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIids(
        [NativeTypeName("ULONG *")] uint* iidCount,
        [NativeTypeName("IID **")] Guid** iids
    )
    {
        return ((delegate* unmanaged<IPackageStatus, uint*, Guid**, int>)((*lpVtbl)[3]))(
            this,
            iidCount,
            iids
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetRuntimeClassName(HSTRING* className)
    {
        return ((delegate* unmanaged<IPackageStatus, HSTRING*, int>)((*lpVtbl)[4]))(
            this,
            className
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetTrustLevel(TrustLevel* trustLevel)
    {
        return ((delegate* unmanaged<IPackageStatus, TrustLevel*, int>)((*lpVtbl)[5]))(
            this,
            trustLevel
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT VerifyIsOK([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackageStatus, byte*, int>)((*lpVtbl)[6]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_NotAvailable([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackageStatus, byte*, int>)((*lpVtbl)[7]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_PackageOffline([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackageStatus, byte*, int>)((*lpVtbl)[8]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_DataOffline([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackageStatus, byte*, int>)((*lpVtbl)[9]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_Disabled([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackageStatus, byte*, int>)((*lpVtbl)[10]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_NeedsRemediation([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackageStatus, byte*, int>)((*lpVtbl)[11]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_LicenseIssue([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackageStatus, byte*, int>)((*lpVtbl)[12]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_Modified([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackageStatus, byte*, int>)((*lpVtbl)[13]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_Tampered([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackageStatus, byte*, int>)((*lpVtbl)[14]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_DependencyIssue([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackageStatus, byte*, int>)((*lpVtbl)[15]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_Servicing([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackageStatus, byte*, int>)((*lpVtbl)[16]))(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_DeploymentInProgress([NativeTypeName("boolean *")] byte* value)
    {
        return ((delegate* unmanaged<IPackageStatus, byte*, int>)((*lpVtbl)[17]))(this, value);
    }

    public interface Interface : IInspectable.Interface
    {
        [VtblIndex(6)]
        HRESULT VerifyIsOK([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(7)]
        HRESULT get_NotAvailable([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(8)]
        HRESULT get_PackageOffline([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(9)]
        HRESULT get_DataOffline([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(10)]
        HRESULT get_Disabled([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(11)]
        HRESULT get_NeedsRemediation([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(12)]
        HRESULT get_LicenseIssue([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(13)]
        HRESULT get_Modified([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(14)]
        HRESULT get_Tampered([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(15)]
        HRESULT get_DependencyIssue([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(16)]
        HRESULT get_Servicing([NativeTypeName("boolean *")] byte* value);

        [VtblIndex(17)]
        HRESULT get_DeploymentInProgress([NativeTypeName("boolean *")] byte* value);
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

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> VerifyIsOK;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_NotAvailable;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_PackageOffline;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_DataOffline;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Disabled;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_NeedsRemediation;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_LicenseIssue;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Modified;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Tampered;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_DependencyIssue;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_Servicing;

        [NativeTypeName("HRESULT (boolean *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, int> get_DeploymentInProgress;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPackageStatus"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPackageStatus(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.WinRT.IInspectable"/> to <see cref = "IPackageStatus"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.WinRT.IInspectable"/> instance to be converted </param>
    public static explicit operator IPackageStatus(Silk.NET.WinRT.IInspectable value)
    {
        return new IPackageStatus(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackageStatus"/> to <see cref = "Silk.NET.WinRT.IInspectable"/>.</summary>
    /// <param name = "value">The <see cref = "IPackageStatus"/> instance to be converted </param>
    public static implicit operator Silk.NET.WinRT.IInspectable(IPackageStatus value)
    {
        return new Silk.NET.WinRT.IInspectable(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPackageStatus"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPackageStatus(Silk.NET.Windows.IUnknown value)
    {
        return new IPackageStatus(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPackageStatus"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPackageStatus"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPackageStatus value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
