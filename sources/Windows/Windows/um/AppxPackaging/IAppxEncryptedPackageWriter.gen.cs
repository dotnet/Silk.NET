// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxEncryptedPackageWriter.xml' path='doc/member[@name="IAppxEncryptedPackageWriter"]/*'/>
[Guid("F43D0B0B-1379-40E2-9B29-682EA2BF42AF")]
[NativeTypeName("struct IAppxEncryptedPackageWriter : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.14393.0")]
public unsafe partial struct IAppxEncryptedPackageWriter : IAppxEncryptedPackageWriter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxEncryptedPackageWriter));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, Guid*, void**, int> )(lpVtbl[0]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, uint> )(lpVtbl[1]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, uint> )(lpVtbl[2]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxEncryptedPackageWriter.xml' path='doc/member[@name="IAppxEncryptedPackageWriter.AddPayloadFileEncrypted"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPayloadFileEncrypted([NativeTypeName("LPCWSTR")] ushort* fileName, APPX_COMPRESSION_OPTION compressionOption, IStream* inputStream)
    {
        return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, ushort*, APPX_COMPRESSION_OPTION, IStream*, int> )(lpVtbl[3]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this), fileName, compressionOption, inputStream);
    }

    /// <include file='IAppxEncryptedPackageWriter.xml' path='doc/member[@name="IAppxEncryptedPackageWriter.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Close()
    {
        return ((delegate* unmanaged<IAppxEncryptedPackageWriter*, int> )(lpVtbl[4]))((IAppxEncryptedPackageWriter*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddPayloadFileEncrypted([NativeTypeName("LPCWSTR")] ushort* fileName, APPX_COMPRESSION_OPTION compressionOption, IStream* inputStream);
        [VtblIndex(4)]
        HRESULT Close();
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
        [NativeTypeName("HRESULT (LPCWSTR, APPX_COMPRESSION_OPTION, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, APPX_COMPRESSION_OPTION, IStream*, int> AddPayloadFileEncrypted;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Close;
    }
}