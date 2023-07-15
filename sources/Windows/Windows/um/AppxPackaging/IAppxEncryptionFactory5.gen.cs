// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IAppxEncryptionFactory5.xml' path='doc/member[@name="IAppxEncryptionFactory5"]/*'/>
[Guid("68D6E77A-F446-480F-B0F0-D91A24C60746")]
[NativeTypeName("struct IAppxEncryptionFactory5 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxEncryptionFactory5 : IAppxEncryptionFactory5.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxEncryptionFactory5));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory5*, Guid*, void**, int> )(lpVtbl[0]))((IAppxEncryptionFactory5*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory5*, uint> )(lpVtbl[1]))((IAppxEncryptionFactory5*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory5*, uint> )(lpVtbl[2]))((IAppxEncryptionFactory5*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxEncryptionFactory5.xml' path='doc/member[@name="IAppxEncryptionFactory5.CreateEncryptedPackageReader2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateEncryptedPackageReader2(IStream* inputStream, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("LPCWSTR")] ushort* expectedDigest, IAppxPackageReader** packageReader)
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory5*, IStream*, APPX_KEY_INFO*, ushort*, IAppxPackageReader**, int> )(lpVtbl[3]))((IAppxEncryptionFactory5*)Unsafe.AsPointer(ref this), inputStream, keyInfo, expectedDigest, packageReader);
    }

    /// <include file='IAppxEncryptionFactory5.xml' path='doc/member[@name="IAppxEncryptionFactory5.CreateEncryptedBundleReader2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT CreateEncryptedBundleReader2(IStream* inputStream, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("LPCWSTR")] ushort* expectedDigest, IAppxBundleReader** bundleReader)
    {
        return ((delegate* unmanaged<IAppxEncryptionFactory5*, IStream*, APPX_KEY_INFO*, ushort*, IAppxBundleReader**, int> )(lpVtbl[4]))((IAppxEncryptionFactory5*)Unsafe.AsPointer(ref this), inputStream, keyInfo, expectedDigest, bundleReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateEncryptedPackageReader2(IStream* inputStream, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("LPCWSTR")] ushort* expectedDigest, IAppxPackageReader** packageReader);
        [VtblIndex(4)]
        HRESULT CreateEncryptedBundleReader2(IStream* inputStream, [NativeTypeName("const APPX_KEY_INFO *")] APPX_KEY_INFO* keyInfo, [NativeTypeName("LPCWSTR")] ushort* expectedDigest, IAppxBundleReader** bundleReader);
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
        [NativeTypeName("HRESULT (IStream *, const APPX_KEY_INFO *, LPCWSTR, IAppxPackageReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, APPX_KEY_INFO*, ushort*, IAppxPackageReader**, int> CreateEncryptedPackageReader2;
        [NativeTypeName("HRESULT (IStream *, const APPX_KEY_INFO *, LPCWSTR, IAppxBundleReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, APPX_KEY_INFO*, ushort*, IAppxBundleReader**, int> CreateEncryptedBundleReader2;
    }
}