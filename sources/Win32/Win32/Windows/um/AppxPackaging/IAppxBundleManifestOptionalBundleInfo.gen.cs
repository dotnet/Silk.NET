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

[Guid("515BF2E8-BCB0-4D69-8C48-E383147B6E12")]
[NativeTypeName("struct IAppxBundleManifestOptionalBundleInfo : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxBundleManifestOptionalBundleInfo
    : IAppxBundleManifestOptionalBundleInfo.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleManifestOptionalBundleInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPackageId(IAppxManifestPackageId* packageId)
    {
        return (
            (delegate* unmanaged<
                IAppxBundleManifestOptionalBundleInfo,
                IAppxManifestPackageId*,
                int>)((*lpVtbl)[3])
        )(this, packageId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** fileName)
    {
        return (
            (delegate* unmanaged<IAppxBundleManifestOptionalBundleInfo, ushort**, int>)(
                (*lpVtbl)[4]
            )
        )(this, fileName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPackageInfoItems(IAppxBundleManifestPackageInfoEnumerator* packageInfoItems)
    {
        return (
            (delegate* unmanaged<
                IAppxBundleManifestOptionalBundleInfo,
                IAppxBundleManifestPackageInfoEnumerator*,
                int>)((*lpVtbl)[5])
        )(this, packageInfoItems);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPackageId(IAppxManifestPackageId* packageId);

        [VtblIndex(4)]
        HRESULT GetFileName([NativeTypeName("LPWSTR *")] ushort** fileName);

        [VtblIndex(5)]
        HRESULT GetPackageInfoItems(IAppxBundleManifestPackageInfoEnumerator* packageInfoItems);
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

        [NativeTypeName("HRESULT (IAppxManifestPackageId **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxManifestPackageId*, int> GetPackageId;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetFileName;

        [NativeTypeName(
            "HRESULT (IAppxBundleManifestPackageInfoEnumerator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppxBundleManifestPackageInfoEnumerator*,
            int> GetPackageInfoItems;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxBundleManifestOptionalBundleInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxBundleManifestOptionalBundleInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxBundleManifestOptionalBundleInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxBundleManifestOptionalBundleInfo(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new IAppxBundleManifestOptionalBundleInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxBundleManifestOptionalBundleInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxBundleManifestOptionalBundleInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        IAppxBundleManifestOptionalBundleInfo value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
