// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxBundleWriter4.xml' path='doc/member[@name="IAppxBundleWriter4"]/*'/>
[Guid("9CD9D523-5009-4C01-9882-DC029FBD47A3")]
[NativeTypeName("struct IAppxBundleWriter4 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxBundleWriter4 : IAppxBundleWriter4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleWriter4));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleWriter4*, Guid*, void**, int> )(lpVtbl[0]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleWriter4*, uint> )(lpVtbl[1]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleWriter4*, uint> )(lpVtbl[2]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBundleWriter4.xml' path='doc/member[@name="IAppxBundleWriter4.AddPayloadPackage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddPayloadPackage([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* packageStream, BOOL isDefaultApplicablePackage)
    {
        return ((delegate* unmanaged<IAppxBundleWriter4*, ushort*, IStream*, BOOL, int> )(lpVtbl[3]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this), fileName, packageStream, isDefaultApplicablePackage);
    }

    /// <include file='IAppxBundleWriter4.xml' path='doc/member[@name="IAppxBundleWriter4.AddPackageReference"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT AddPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream, BOOL isDefaultApplicablePackage)
    {
        return ((delegate* unmanaged<IAppxBundleWriter4*, ushort*, IStream*, BOOL, int> )(lpVtbl[4]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this), fileName, inputStream, isDefaultApplicablePackage);
    }

    /// <include file='IAppxBundleWriter4.xml' path='doc/member[@name="IAppxBundleWriter4.AddExternalPackageReference"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddExternalPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream, BOOL isDefaultApplicablePackage)
    {
        return ((delegate* unmanaged<IAppxBundleWriter4*, ushort*, IStream*, BOOL, int> )(lpVtbl[5]))((IAppxBundleWriter4*)Unsafe.AsPointer(ref this), fileName, inputStream, isDefaultApplicablePackage);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddPayloadPackage([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* packageStream, BOOL isDefaultApplicablePackage);
        [VtblIndex(4)]
        HRESULT AddPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream, BOOL isDefaultApplicablePackage);
        [VtblIndex(5)]
        HRESULT AddExternalPackageReference([NativeTypeName("LPCWSTR")] ushort* fileName, IStream* inputStream, BOOL isDefaultApplicablePackage);
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
        [NativeTypeName("HRESULT (LPCWSTR, IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IStream*, BOOL, int> AddPayloadPackage;
        [NativeTypeName("HRESULT (LPCWSTR, IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IStream*, BOOL, int> AddPackageReference;
        [NativeTypeName("HRESULT (LPCWSTR, IStream *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IStream*, BOOL, int> AddExternalPackageReference;
    }
}