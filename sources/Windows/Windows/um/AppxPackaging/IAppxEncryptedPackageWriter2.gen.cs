// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IAppxEncryptedPackageWriter2.xml' path='doc/member[@name="IAppxEncryptedPackageWriter2"]/*' />
[Guid("3E475447-3A25-40B5-8AD2-F953AE50C92D")]
[NativeTypeName("struct IAppxEncryptedPackageWriter2 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0.14393.0")]
public unsafe partial struct IAppxEncryptedPackageWriter2 : IAppxEncryptedPackageWriter2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxEncryptedPackageWriter2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxEncryptedPackageWriter2*, Guid*, void**, int>)(lpVtbl[0]))((IAppxEncryptedPackageWriter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxEncryptedPackageWriter2*, uint>)(lpVtbl[1]))((IAppxEncryptedPackageWriter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxEncryptedPackageWriter2*, uint>)(lpVtbl[2]))((IAppxEncryptedPackageWriter2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxEncryptedPackageWriter2.xml' path='doc/member[@name="IAppxEncryptedPackageWriter2.AddPayloadFilesEncrypted"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPayloadFilesEncrypted([NativeTypeName("UINT32")] uint fileCount, APPX_PACKAGE_WRITER_PAYLOAD_STREAM* payloadFiles, [NativeTypeName("UINT64")] ulong memoryLimit)
    {
        return ((delegate* unmanaged<IAppxEncryptedPackageWriter2*, uint, APPX_PACKAGE_WRITER_PAYLOAD_STREAM*, ulong, int>)(lpVtbl[3]))((IAppxEncryptedPackageWriter2*)Unsafe.AsPointer(ref this), fileCount, payloadFiles, memoryLimit);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddPayloadFilesEncrypted([NativeTypeName("UINT32")] uint fileCount, APPX_PACKAGE_WRITER_PAYLOAD_STREAM* payloadFiles, [NativeTypeName("UINT64")] ulong memoryLimit);
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

        [NativeTypeName("HRESULT (UINT32, APPX_PACKAGE_WRITER_PAYLOAD_STREAM *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, APPX_PACKAGE_WRITER_PAYLOAD_STREAM*, ulong, int> AddPayloadFilesEncrypted;
    }
}
