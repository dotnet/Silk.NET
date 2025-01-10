// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("776B2C05-E21D-4E24-BA1A-CD529A8BFDBB")]
[NativeTypeName("struct IAppxFactory3 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxFactory3 : IAppxFactory3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxFactory3));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxFactory3, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxFactory3, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxFactory3, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreatePackageReader2(
        IStream inputStream,
        [NativeTypeName("LPCWSTR")] ushort* expectedDigest,
        IAppxPackageReader* packageReader
    )
    {
        return (
            (delegate* unmanaged<IAppxFactory3, IStream, ushort*, IAppxPackageReader*, int>)(
                (*lpVtbl)[3]
            )
        )(this, inputStream, expectedDigest, packageReader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateManifestReader2(
        IStream inputStream,
        [NativeTypeName("LPCWSTR")] ushort* expectedDigest,
        IAppxManifestReader* manifestReader
    )
    {
        return (
            (delegate* unmanaged<IAppxFactory3, IStream, ushort*, IAppxManifestReader*, int>)(
                (*lpVtbl)[4]
            )
        )(this, inputStream, expectedDigest, manifestReader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateAppInstallerReader(
        IStream inputStream,
        [NativeTypeName("LPCWSTR")] ushort* expectedDigest,
        IAppxAppInstallerReader* appInstallerReader
    )
    {
        return (
            (delegate* unmanaged<IAppxFactory3, IStream, ushort*, IAppxAppInstallerReader*, int>)(
                (*lpVtbl)[5]
            )
        )(this, inputStream, expectedDigest, appInstallerReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreatePackageReader2(
            IStream inputStream,
            [NativeTypeName("LPCWSTR")] ushort* expectedDigest,
            IAppxPackageReader* packageReader
        );

        [VtblIndex(4)]
        HRESULT CreateManifestReader2(
            IStream inputStream,
            [NativeTypeName("LPCWSTR")] ushort* expectedDigest,
            IAppxManifestReader* manifestReader
        );

        [VtblIndex(5)]
        HRESULT CreateAppInstallerReader(
            IStream inputStream,
            [NativeTypeName("LPCWSTR")] ushort* expectedDigest,
            IAppxAppInstallerReader* appInstallerReader
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
            "HRESULT (IStream *, LPCWSTR, IAppxPackageReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            ushort*,
            IAppxPackageReader*,
            int> CreatePackageReader2;

        [NativeTypeName(
            "HRESULT (IStream *, LPCWSTR, IAppxManifestReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            ushort*,
            IAppxManifestReader*,
            int> CreateManifestReader2;

        [NativeTypeName(
            "HRESULT (IStream *, LPCWSTR, IAppxAppInstallerReader **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IStream,
            ushort*,
            IAppxAppInstallerReader*,
            int> CreateAppInstallerReader;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxFactory3"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxFactory3(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxFactory3"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxFactory3(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxFactory3(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxFactory3"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxFactory3"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxFactory3 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
