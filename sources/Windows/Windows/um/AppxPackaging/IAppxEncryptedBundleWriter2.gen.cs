// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxEncryptedBundleWriter2.xml' path='doc/member[@name="IAppxEncryptedBundleWriter2"]/*'/>
[Guid("E644BE82-F0FA-42B8-A956-8D1CB48EE379")]
[NativeTypeName("struct IAppxEncryptedBundleWriter2 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxEncryptedBundleWriter2 : IAppxEncryptedBundleWriter2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxEncryptedBundleWriter2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxEncryptedBundleWriter2*, Guid*, void**, int> )(lpVtbl[0]))((IAppxEncryptedBundleWriter2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxEncryptedBundleWriter2*, uint> )(lpVtbl[1]))((IAppxEncryptedBundleWriter2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxEncryptedBundleWriter2*, uint> )(lpVtbl[2]))((IAppxEncryptedBundleWriter2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxEncryptedBundleWriter2.xml' path='doc/member[@name="IAppxEncryptedBundleWriter2.AddExternalPackageReference"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddExternalPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream)
    {
        return ((delegate* unmanaged<IAppxEncryptedBundleWriter2*, ushort*, IStream*, int> )(lpVtbl[3]))((IAppxEncryptedBundleWriter2*)Unsafe.AsPointer(ref this), fileName, inputStream);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddExternalPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream);
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
        [NativeTypeName("HRESULT (LPCWSTR, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IStream*, int> AddExternalPackageReference;
    }
}