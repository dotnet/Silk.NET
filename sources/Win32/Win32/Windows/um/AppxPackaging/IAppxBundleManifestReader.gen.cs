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

[Guid("CF0EBBC1-CC99-4106-91EB-E67462E04FB0")]
[NativeTypeName("struct IAppxBundleManifestReader : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IAppxBundleManifestReader
    : IAppxBundleManifestReader.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleManifestReader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleManifestReader, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxBundleManifestReader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleManifestReader, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPackageId(IAppxManifestPackageId* packageId)
    {
        return (
            (delegate* unmanaged<IAppxBundleManifestReader, IAppxManifestPackageId*, int>)(
                (*lpVtbl)[3]
            )
        )(this, packageId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPackageInfoItems(IAppxBundleManifestPackageInfoEnumerator* packageInfoItems)
    {
        return (
            (delegate* unmanaged<
                IAppxBundleManifestReader,
                IAppxBundleManifestPackageInfoEnumerator*,
                int>)((*lpVtbl)[4])
        )(this, packageInfoItems);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetStream(IStream* manifestStream)
    {
        return ((delegate* unmanaged<IAppxBundleManifestReader, IStream*, int>)((*lpVtbl)[5]))(
            this,
            manifestStream
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPackageId(IAppxManifestPackageId* packageId);

        [VtblIndex(4)]
        HRESULT GetPackageInfoItems(IAppxBundleManifestPackageInfoEnumerator* packageInfoItems);

        [VtblIndex(5)]
        HRESULT GetStream(IStream* manifestStream);
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

        [NativeTypeName(
            "HRESULT (IAppxBundleManifestPackageInfoEnumerator **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IAppxBundleManifestPackageInfoEnumerator*,
            int> GetPackageInfoItems;

        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> GetStream;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxBundleManifestReader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxBundleManifestReader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxBundleManifestReader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxBundleManifestReader(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxBundleManifestReader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxBundleManifestReader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxBundleManifestReader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxBundleManifestReader value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
