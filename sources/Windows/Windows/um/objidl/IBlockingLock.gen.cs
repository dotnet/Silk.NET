// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IBlockingLock.xml' path='doc/member[@name="IBlockingLock"]/*'/>
[Guid("30F3D47A-6447-11D1-8E3C-00C04FB9386D")]
[NativeTypeName("struct IBlockingLock : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IBlockingLock : IBlockingLock.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IBlockingLock));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IBlockingLock*, Guid*, void**, int> )(lpVtbl[0]))((IBlockingLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IBlockingLock*, uint> )(lpVtbl[1]))((IBlockingLock*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IBlockingLock*, uint> )(lpVtbl[2]))((IBlockingLock*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IBlockingLock.xml' path='doc/member[@name="IBlockingLock.Lock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Lock([NativeTypeName("DWORD")] uint dwTimeout)
    {
        return ((delegate* unmanaged<IBlockingLock*, uint, int> )(lpVtbl[3]))((IBlockingLock*)Unsafe.AsPointer(ref this), dwTimeout);
    }

    /// <include file='IBlockingLock.xml' path='doc/member[@name="IBlockingLock.Unlock"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unlock()
    {
        return ((delegate* unmanaged<IBlockingLock*, int> )(lpVtbl[4]))((IBlockingLock*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Lock([NativeTypeName("DWORD")] uint dwTimeout);
        [VtblIndex(4)]
        HRESULT Unlock();
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
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Lock;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unlock;
    }
}