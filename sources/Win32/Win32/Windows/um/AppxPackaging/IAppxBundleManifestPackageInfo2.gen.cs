// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("44C2ACBC-B2CF-4CCB-BBDB-9C6DA8C3BC9E")]
[NativeTypeName("struct IAppxBundleManifestPackageInfo2 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxBundleManifestPackageInfo2
    : IAppxBundleManifestPackageInfo2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleManifestPackageInfo2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppxBundleManifestPackageInfo2, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetIsPackageReference(BOOL* isPackageReference)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2, BOOL*, int>)((*lpVtbl)[3]))(
            this,
            isPackageReference
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetIsNonQualifiedResourcePackage(BOOL* isNonQualifiedResourcePackage)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2, BOOL*, int>)((*lpVtbl)[4]))(
            this,
            isNonQualifiedResourcePackage
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIsDefaultApplicablePackage(BOOL* isDefaultApplicablePackage)
    {
        return ((delegate* unmanaged<IAppxBundleManifestPackageInfo2, BOOL*, int>)((*lpVtbl)[5]))(
            this,
            isDefaultApplicablePackage
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetIsPackageReference(BOOL* isPackageReference);

        [VtblIndex(4)]
        HRESULT GetIsNonQualifiedResourcePackage(BOOL* isNonQualifiedResourcePackage);

        [VtblIndex(5)]
        HRESULT GetIsDefaultApplicablePackage(BOOL* isDefaultApplicablePackage);
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

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetIsPackageReference;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetIsNonQualifiedResourcePackage;

        [NativeTypeName("HRESULT (BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> GetIsDefaultApplicablePackage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxBundleManifestPackageInfo2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxBundleManifestPackageInfo2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxBundleManifestPackageInfo2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxBundleManifestPackageInfo2(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxBundleManifestPackageInfo2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxBundleManifestPackageInfo2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxBundleManifestPackageInfo2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxBundleManifestPackageInfo2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
