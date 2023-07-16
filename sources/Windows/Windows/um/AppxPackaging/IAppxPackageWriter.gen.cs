// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxPackageWriter.xml' path='doc/member[@name="IAppxPackageWriter"]/*'/>
[Guid("9099E33B-246F-41E4-881A-008EB613F858")]
[NativeTypeName("struct IAppxPackageWriter : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct IAppxPackageWriter : IAppxPackageWriter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxPackageWriter));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxPackageWriter*, Guid*, void**, int> )(lpVtbl[0]))((IAppxPackageWriter*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxPackageWriter*, uint> )(lpVtbl[1]))((IAppxPackageWriter*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxPackageWriter*, uint> )(lpVtbl[2]))((IAppxPackageWriter*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxPackageWriter.xml' path='doc/member[@name="IAppxPackageWriter.AddPayloadFile"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPayloadFile([NativeTypeName("LPCWSTR")] ushort* fileName, [NativeTypeName("LPCWSTR")] ushort* contentType, APPX_COMPRESSION_OPTION compressionOption, IStream* inputStream)
    {
        return ((delegate* unmanaged<IAppxPackageWriter*, ushort*, ushort*, APPX_COMPRESSION_OPTION, IStream*, int> )(lpVtbl[3]))((IAppxPackageWriter*)Unsafe.AsPointer(ref this), fileName, contentType, compressionOption, inputStream);
    }

    /// <include file='IAppxPackageWriter.xml' path='doc/member[@name="IAppxPackageWriter.Close"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Close(IStream* manifest)
    {
        return ((delegate* unmanaged<IAppxPackageWriter*, IStream*, int> )(lpVtbl[4]))((IAppxPackageWriter*)Unsafe.AsPointer(ref this), manifest);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddPayloadFile([NativeTypeName("LPCWSTR")] ushort* fileName, [NativeTypeName("LPCWSTR")] ushort* contentType, APPX_COMPRESSION_OPTION compressionOption, IStream* inputStream);
        [VtblIndex(4)]
        HRESULT Close(IStream* manifest);
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
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, APPX_COMPRESSION_OPTION, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, APPX_COMPRESSION_OPTION, IStream*, int> AddPayloadFile;
        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> Close;
    }
}