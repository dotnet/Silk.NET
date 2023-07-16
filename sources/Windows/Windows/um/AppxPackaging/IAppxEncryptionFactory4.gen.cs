// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxEncryptionFactory4.xml' path='doc/member[@name="IAppxEncryptionFactory4"]/*'/>
[Guid("A879611F-12FD-41FE-85D5-06AE779BBAF5")]
[NativeTypeName("struct IAppxEncryptionFactory4 : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IAppxEncryptionFactory4 : IAppxEncryptionFactory4.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxEncryptionFactory4));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory4*, Guid*, void**, int> )(lpVtbl[0]))((IAppxEncryptionFactory4*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory4*, uint> )(lpVtbl[1]))((IAppxEncryptionFactory4*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory4*, uint> )(lpVtbl[2]))((IAppxEncryptionFactory4*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxEncryptionFactory4.xml' path='doc/member[@name="IAppxEncryptionFactory4.EncryptPackage"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT EncryptPackage(IStream* inputStream, IStream* outputStream, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *")] APPX_ENCRYPTED_PACKAGE_SETTINGS2* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")] APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles, [NativeTypeName("UINT64")] ulong memoryLimit)
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory4*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, ulong, int> )(lpVtbl[3]))((IAppxEncryptionFactory4*)Unsafe.AsPointer(ref this), inputStream, outputStream, settings, keyInfo, exemptedFiles, memoryLimit);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT EncryptPackage(IStream* inputStream, IStream* outputStream, [NativeTypeName("const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *")] APPX_ENCRYPTED_PACKAGE_SETTINGS2* settings, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("const APPX_ENCRYPTED_EXEMPTIONS *")] APPX_ENCRYPTED_EXEMPTIONS* exemptedFiles, [NativeTypeName("UINT64")] ulong memoryLimit);
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
        [NativeTypeName("HRESULT (IStream *, IStream *, const APPX_ENCRYPTED_PACKAGE_SETTINGS2 *, const APPX_KEY_INFO *, const APPX_ENCRYPTED_EXEMPTIONS *, UINT64) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, IStream*, APPX_ENCRYPTED_PACKAGE_SETTINGS2*, APPX_KEY_INFO*, APPX_ENCRYPTED_EXEMPTIONS*, ulong, int> EncryptPackage;
    }
}