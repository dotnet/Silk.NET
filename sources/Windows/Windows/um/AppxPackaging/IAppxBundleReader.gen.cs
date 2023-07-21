// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAppxBundleReader.xml' path='doc/member[@name="IAppxBundleReader"]/*' />
[Guid("DD75B8C0-BA76-43B0-AE0F-68656A1DC5C8")]
[NativeTypeName("struct IAppxBundleReader : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IAppxBundleReader : IAppxBundleReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleReader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleReader*, Guid*, void**, int>)(lpVtbl[0]))((IAppxBundleReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleReader*, uint>)(lpVtbl[1]))((IAppxBundleReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleReader*, uint>)(lpVtbl[2]))((IAppxBundleReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBundleReader.xml' path='doc/member[@name="IAppxBundleReader.GetFootprintFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFootprintFile(APPX_BUNDLE_FOOTPRINT_FILE_TYPE fileType, IAppxFile** footprintFile)
    {
        return ((delegate* unmanaged<IAppxBundleReader*, APPX_BUNDLE_FOOTPRINT_FILE_TYPE, IAppxFile**, int>)(lpVtbl[3]))((IAppxBundleReader*)Unsafe.AsPointer(ref this), fileType, footprintFile);
    }

    /// <include file='IAppxBundleReader.xml' path='doc/member[@name="IAppxBundleReader.GetBlockMap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetBlockMap(IAppxBlockMapReader** blockMapReader)
    {
        return ((delegate* unmanaged<IAppxBundleReader*, IAppxBlockMapReader**, int>)(lpVtbl[4]))((IAppxBundleReader*)Unsafe.AsPointer(ref this), blockMapReader);
    }

    /// <include file='IAppxBundleReader.xml' path='doc/member[@name="IAppxBundleReader.GetManifest"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetManifest(IAppxBundleManifestReader** manifestReader)
    {
        return ((delegate* unmanaged<IAppxBundleReader*, IAppxBundleManifestReader**, int>)(lpVtbl[5]))((IAppxBundleReader*)Unsafe.AsPointer(ref this), manifestReader);
    }

    /// <include file='IAppxBundleReader.xml' path='doc/member[@name="IAppxBundleReader.GetPayloadPackages"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetPayloadPackages(IAppxFilesEnumerator** payloadPackages)
    {
        return ((delegate* unmanaged<IAppxBundleReader*, IAppxFilesEnumerator**, int>)(lpVtbl[6]))((IAppxBundleReader*)Unsafe.AsPointer(ref this), payloadPackages);
    }

    /// <include file='IAppxBundleReader.xml' path='doc/member[@name="IAppxBundleReader.GetPayloadPackage"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetPayloadPackage([NativeTypeName("LPCWSTR")] ushort* fileName, IAppxFile** payloadPackage)
    {
        return ((delegate* unmanaged<IAppxBundleReader*, ushort*, IAppxFile**, int>)(lpVtbl[7]))((IAppxBundleReader*)Unsafe.AsPointer(ref this), fileName, payloadPackage);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFootprintFile(APPX_BUNDLE_FOOTPRINT_FILE_TYPE fileType, IAppxFile** footprintFile);

        [VtblIndex(4)]
        HRESULT GetBlockMap(IAppxBlockMapReader** blockMapReader);

        [VtblIndex(5)]
        HRESULT GetManifest(IAppxBundleManifestReader** manifestReader);

        [VtblIndex(6)]
        HRESULT GetPayloadPackages(IAppxFilesEnumerator** payloadPackages);

        [VtblIndex(7)]
        HRESULT GetPayloadPackage([NativeTypeName("LPCWSTR")] ushort* fileName, IAppxFile** payloadPackage);
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

        [NativeTypeName("HRESULT (APPX_BUNDLE_FOOTPRINT_FILE_TYPE, IAppxFile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, APPX_BUNDLE_FOOTPRINT_FILE_TYPE, IAppxFile**, int> GetFootprintFile;

        [NativeTypeName("HRESULT (IAppxBlockMapReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxBlockMapReader**, int> GetBlockMap;

        [NativeTypeName("HRESULT (IAppxBundleManifestReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxBundleManifestReader**, int> GetManifest;

        [NativeTypeName("HRESULT (IAppxFilesEnumerator **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAppxFilesEnumerator**, int> GetPayloadPackages;

        [NativeTypeName("HRESULT (LPCWSTR, IAppxFile **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IAppxFile**, int> GetPayloadPackage;
    }
}
