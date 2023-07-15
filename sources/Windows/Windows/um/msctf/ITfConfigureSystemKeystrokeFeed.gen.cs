// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITfConfigureSystemKeystrokeFeed.xml' path='doc/member[@name="ITfConfigureSystemKeystrokeFeed"]/*'/>
[Guid("0D2C969A-BC9C-437C-84EE-951C49B1A764")]
[NativeTypeName("struct ITfConfigureSystemKeystrokeFeed : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfConfigureSystemKeystrokeFeed : ITfConfigureSystemKeystrokeFeed.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfConfigureSystemKeystrokeFeed));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed*, Guid*, void**, int> )(lpVtbl[0]))((ITfConfigureSystemKeystrokeFeed*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed*, uint> )(lpVtbl[1]))((ITfConfigureSystemKeystrokeFeed*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed*, uint> )(lpVtbl[2]))((ITfConfigureSystemKeystrokeFeed*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfConfigureSystemKeystrokeFeed.xml' path='doc/member[@name="ITfConfigureSystemKeystrokeFeed.DisableSystemKeystrokeFeed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT DisableSystemKeystrokeFeed()
    {
        return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed*, int> )(lpVtbl[3]))((ITfConfigureSystemKeystrokeFeed*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfConfigureSystemKeystrokeFeed.xml' path='doc/member[@name="ITfConfigureSystemKeystrokeFeed.EnableSystemKeystrokeFeed"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnableSystemKeystrokeFeed()
    {
        return ((delegate* unmanaged<ITfConfigureSystemKeystrokeFeed*, int> )(lpVtbl[4]))((ITfConfigureSystemKeystrokeFeed*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT DisableSystemKeystrokeFeed();
        [VtblIndex(4)]
        HRESULT EnableSystemKeystrokeFeed();
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> DisableSystemKeystrokeFeed;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> EnableSystemKeystrokeFeed;
    }
}