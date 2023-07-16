// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/AppxPackaging.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IAppxBundleFactory2.xml' path='doc/member[@name="IAppxBundleFactory2"]/*'/>
[Guid("7325B83D-0185-42C4-82AC-BE34AB1A2A8A")]
[NativeTypeName("struct IAppxBundleFactory2 : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAppxBundleFactory2 : IAppxBundleFactory2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAppxBundleFactory2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAppxBundleFactory2*, Guid*, void**, int> )(lpVtbl[0]))((IAppxBundleFactory2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IAppxBundleFactory2*, uint> )(lpVtbl[1]))((IAppxBundleFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAppxBundleFactory2*, uint> )(lpVtbl[2]))((IAppxBundleFactory2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IAppxBundleFactory2.xml' path='doc/member[@name="IAppxBundleFactory2.CreateBundleReader2"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateBundleReader2(IStream* inputStream, [NativeTypeName("LPCWSTR")] ushort* expectedDigest, IAppxBundleReader** bundleReader)
    {
        return ((delegate* unmanaged<IAppxBundleFactory2*, IStream*, ushort*, IAppxBundleReader**, int> )(lpVtbl[3]))((IAppxBundleFactory2*)Unsafe.AsPointer(ref this), inputStream, expectedDigest, bundleReader);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateBundleReader2(IStream* inputStream, [NativeTypeName("LPCWSTR")] ushort* expectedDigest, IAppxBundleReader** bundleReader);
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
        [NativeTypeName("HRESULT (IStream *, LPCWSTR, IAppxBundleReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, ushort*, IAppxBundleReader**, int> CreateBundleReader2;
    }
}