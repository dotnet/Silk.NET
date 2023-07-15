// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxPackageWriter3.xml' path='doc/member[@name="IAppxPackageWriter3"]/*'/>
[Guid("A83AACD3-41C0-4501-B8A3-74164F50B2FD")]
[NativeTypeName("struct IAppxPackageWriter3 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxPackageWriter3 : IAppxPackageWriter3.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxPackageWriter3));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxPackageWriter3*, Guid*, void**, int> )(lpVtbl[0]))((IAppxPackageWriter3*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxPackageWriter3*, uint> )(lpVtbl[1]))((IAppxPackageWriter3*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxPackageWriter3*, uint> )(lpVtbl[2]))((IAppxPackageWriter3*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxPackageWriter3.xml' path='doc/member[@name="IAppxPackageWriter3.AddPayloadFiles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPayloadFiles([NativeTypeName("UINT32")] uint fileCount, APPX_PACKAGE_WRITER_PAYLOAD_STREAM* payloadFiles, [NativeTypeName("UINT64")] ulong memoryLimit)
    {
        return ((delegate* unmanaged<IAppxPackageWriter3*, uint, APPX_PACKAGE_WRITER_PAYLOAD_STREAM*, ulong, int> )(lpVtbl[3]))((IAppxPackageWriter3*)Unsafe.AsPointer(ref this), fileCount, payloadFiles, memoryLimit);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddPayloadFiles([NativeTypeName("UINT32")] uint fileCount, APPX_PACKAGE_WRITER_PAYLOAD_STREAM* payloadFiles, [NativeTypeName("UINT64")] ulong memoryLimit);
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
        public delegate* unmanaged<TSelf*, uint, APPX_PACKAGE_WRITER_PAYLOAD_STREAM*, ulong, int> AddPayloadFiles;
    }
}