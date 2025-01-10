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

[Guid("DD75B8C0-BA76-43B0-AE0F-68656A1DC5C8")]
[NativeTypeName("struct IAppxBundleReader : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IAppxBundleReader : IAppxBundleReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleReader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleReader, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAppxBundleReader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleReader, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFootprintFile(
        APPX_BUNDLE_FOOTPRINT_FILE_TYPE fileType,
        IAppxFile* footprintFile
    )
    {
        return (
            (delegate* unmanaged<
                IAppxBundleReader,
                APPX_BUNDLE_FOOTPRINT_FILE_TYPE,
                IAppxFile*,
                int>)((*lpVtbl)[3])
        )(this, fileType, footprintFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBlockMap(IAppxBlockMapReader* blockMapReader)
    {
        return ((delegate* unmanaged<IAppxBundleReader, IAppxBlockMapReader*, int>)((*lpVtbl)[4]))(
            this,
            blockMapReader
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetManifest(IAppxBundleManifestReader* manifestReader)
    {
        return (
            (delegate* unmanaged<IAppxBundleReader, IAppxBundleManifestReader*, int>)((*lpVtbl)[5])
        )(this, manifestReader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPayloadPackages(IAppxFilesEnumerator* payloadPackages)
    {
        return ((delegate* unmanaged<IAppxBundleReader, IAppxFilesEnumerator*, int>)((*lpVtbl)[6]))(
            this,
            payloadPackages
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPayloadPackage(
        [NativeTypeName("LPCWSTR")] ushort* fileName,
        IAppxFile* payloadPackage
    )
    {
        return ((delegate* unmanaged<IAppxBundleReader, ushort*, IAppxFile*, int>)((*lpVtbl)[7]))(
            this,
            fileName,
            payloadPackage
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFootprintFile(
            APPX_BUNDLE_FOOTPRINT_FILE_TYPE fileType,
            IAppxFile* footprintFile
        );

        [VtblIndex(4)]
        HRESULT GetBlockMap(IAppxBlockMapReader* blockMapReader);

        [VtblIndex(5)]
        HRESULT GetManifest(IAppxBundleManifestReader* manifestReader);

        [VtblIndex(6)]
        HRESULT GetPayloadPackages(IAppxFilesEnumerator* payloadPackages);

        [VtblIndex(7)]
        HRESULT GetPayloadPackage(
            [NativeTypeName("LPCWSTR")] ushort* fileName,
            IAppxFile* payloadPackage
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
            "HRESULT (APPX_BUNDLE_FOOTPRINT_FILE_TYPE, IAppxFile **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            APPX_BUNDLE_FOOTPRINT_FILE_TYPE,
            IAppxFile*,
            int> GetFootprintFile;

        [NativeTypeName("HRESULT (IAppxBlockMapReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxBlockMapReader*, int> GetBlockMap;

        [NativeTypeName("HRESULT (IAppxBundleManifestReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxBundleManifestReader*, int> GetManifest;

        [NativeTypeName("HRESULT (IAppxFilesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxFilesEnumerator*, int> GetPayloadPackages;

        [NativeTypeName("HRESULT (LPCWSTR, IAppxFile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IAppxFile*, int> GetPayloadPackage;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAppxBundleReader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAppxBundleReader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAppxBundleReader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAppxBundleReader(Silk.NET.Windows.IUnknown value)
    {
        return new IAppxBundleReader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAppxBundleReader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAppxBundleReader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAppxBundleReader value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
