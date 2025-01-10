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

[Guid("BBA65864-965F-4A5F-855F-F074BDBF3A7B")]
[NativeTypeName("struct IAppxBundleFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IAppxBundleFactory : IAppxBundleFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleFactory));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleFactory, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxBundleFactory, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleFactory, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateBundleWriter(
        IStream outputStream,
        [NativeTypeName("UINT64")] ulong bundleVersion,
        IAppxBundleWriter* bundleWriter
    )
    {
        return (
            (delegate* unmanaged<IAppxBundleFactory, IStream, ulong, IAppxBundleWriter*, int>)(
                (*lpVtbl)[3]
            )
        )(this, outputStream, bundleVersion, bundleWriter);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateBundleReader(IStream inputStream, IAppxBundleReader* bundleReader)
    {
        return (
            (delegate* unmanaged<IAppxBundleFactory, IStream, IAppxBundleReader*, int>)(
                (*lpVtbl)[4]
            )
        )(this, inputStream, bundleReader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateBundleManifestReader(
        IStream inputStream,
        IAppxBundleManifestReader* manifestReader
    )
    {
        return (
            (delegate* unmanaged<IAppxBundleFactory, IStream, IAppxBundleManifestReader*, int>)(
                (*lpVtbl)[5]
            )
        )(this, inputStream, manifestReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateBundleWriter(
            IStream outputStream,
            [NativeTypeName("UINT64")] ulong bundleVersion,
            IAppxBundleWriter* bundleWriter
        );

        [VtblIndex(4)]
        HRESULT CreateBundleReader(IStream inputStream, IAppxBundleReader* bundleReader);

        [VtblIndex(5)]
        HRESULT CreateBundleManifestReader(
            IStream inputStream,
            IAppxBundleManifestReader* manifestReader
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

        [NativeTypeName(
            "HRESULT (IStream *, UINT64, IAppxBundleWriter **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            ulong,
            IAppxBundleWriter*,
            int> CreateBundleWriter;

        [NativeTypeName("HRESULT (IStream *, IAppxBundleReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream, IAppxBundleReader*, int> CreateBundleReader;

        [NativeTypeName(
            "HRESULT (IStream *, IAppxBundleManifestReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            IAppxBundleManifestReader*,
            int> CreateBundleManifestReader;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxBundleFactory"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxBundleFactory(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxBundleFactory"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxBundleFactory(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxBundleFactory(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxBundleFactory"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxBundleFactory"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxBundleFactory value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
