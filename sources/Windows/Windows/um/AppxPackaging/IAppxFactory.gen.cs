// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAppxFactory.xml' path='doc/member[@name="IAppxFactory"]/*' />
[Guid("BEB94909-E451-438B-B5A7-D79E767B75D8")]
[NativeTypeName("struct IAppxFactory : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxFactory : IAppxFactory.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxFactory));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxFactory*, Guid*, void**, int>)(lpVtbl[0]))((IAppxFactory*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxFactory*, uint>)(lpVtbl[1]))((IAppxFactory*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxFactory*, uint>)(lpVtbl[2]))((IAppxFactory*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxFactory.xml' path='doc/member[@name="IAppxFactory.CreatePackageWriter"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreatePackageWriter(IStream* outputStream, APPX_PACKAGE_SETTINGS* settings, IAppxPackageWriter** packageWriter)
    {
        return ((delegate* unmanaged<IAppxFactory*, IStream*, APPX_PACKAGE_SETTINGS*, IAppxPackageWriter**, int>)(lpVtbl[3]))((IAppxFactory*)Unsafe.AsPointer(ref this), outputStream, settings, packageWriter);
    }

    /// <include file='IAppxFactory.xml' path='doc/member[@name="IAppxFactory.CreatePackageReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreatePackageReader(IStream* inputStream, IAppxPackageReader** packageReader)
    {
        return ((delegate* unmanaged<IAppxFactory*, IStream*, IAppxPackageReader**, int>)(lpVtbl[4]))((IAppxFactory*)Unsafe.AsPointer(ref this), inputStream, packageReader);
    }

    /// <include file='IAppxFactory.xml' path='doc/member[@name="IAppxFactory.CreateManifestReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateManifestReader(IStream* inputStream, IAppxManifestReader** manifestReader)
    {
        return ((delegate* unmanaged<IAppxFactory*, IStream*, IAppxManifestReader**, int>)(lpVtbl[5]))((IAppxFactory*)Unsafe.AsPointer(ref this), inputStream, manifestReader);
    }

    /// <include file='IAppxFactory.xml' path='doc/member[@name="IAppxFactory.CreateBlockMapReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT CreateBlockMapReader(IStream* inputStream, IAppxBlockMapReader** blockMapReader)
    {
        return ((delegate* unmanaged<IAppxFactory*, IStream*, IAppxBlockMapReader**, int>)(lpVtbl[6]))((IAppxFactory*)Unsafe.AsPointer(ref this), inputStream, blockMapReader);
    }

    /// <include file='IAppxFactory.xml' path='doc/member[@name="IAppxFactory.CreateValidatedBlockMapReader"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CreateValidatedBlockMapReader(IStream* blockMapStream, [NativeTypeName("LPCWSTR")] ushort* signatureFileName, IAppxBlockMapReader** blockMapReader)
    {
        return ((delegate* unmanaged<IAppxFactory*, IStream*, ushort*, IAppxBlockMapReader**, int>)(lpVtbl[7]))((IAppxFactory*)Unsafe.AsPointer(ref this), blockMapStream, signatureFileName, blockMapReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreatePackageWriter(IStream* outputStream, APPX_PACKAGE_SETTINGS* settings, IAppxPackageWriter** packageWriter);

        [VtblIndex(4)]
        HRESULT CreatePackageReader(IStream* inputStream, IAppxPackageReader** packageReader);

        [VtblIndex(5)]
        HRESULT CreateManifestReader(IStream* inputStream, IAppxManifestReader** manifestReader);

        [VtblIndex(6)]
        HRESULT CreateBlockMapReader(IStream* inputStream, IAppxBlockMapReader** blockMapReader);

        [VtblIndex(7)]
        HRESULT CreateValidatedBlockMapReader(IStream* blockMapStream, [NativeTypeName("LPCWSTR")] ushort* signatureFileName, IAppxBlockMapReader** blockMapReader);
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

        [NativeTypeName("HRESULT (IStream *, APPX_PACKAGE_SETTINGS *, IAppxPackageWriter **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, APPX_PACKAGE_SETTINGS*, IAppxPackageWriter**, int> CreatePackageWriter;

        [NativeTypeName("HRESULT (IStream *, IAppxPackageReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, IAppxPackageReader**, int> CreatePackageReader;

        [NativeTypeName("HRESULT (IStream *, IAppxManifestReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, IAppxManifestReader**, int> CreateManifestReader;

        [NativeTypeName("HRESULT (IStream *, IAppxBlockMapReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, IAppxBlockMapReader**, int> CreateBlockMapReader;

        [NativeTypeName("HRESULT (IStream *, LPCWSTR, IAppxBlockMapReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, ushort*, IAppxBlockMapReader**, int> CreateValidatedBlockMapReader;
    }
}
