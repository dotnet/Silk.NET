// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISynchronizeMutex.xml' path='doc/member[@name="ISynchronizeMutex"]/*'/>
[Guid("00000025-0000-0000-C000-000000000046")]
[NativeTypeName("struct ISynchronizeMutex : ISynchronize")]
[NativeInheritance("ISynchronize")]
public unsafe partial struct ISynchronizeMutex : ISynchronizeMutex.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISynchronizeMutex));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISynchronizeMutex*, Guid*, void**, int> )(lpVtbl[0]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISynchronizeMutex*, uint> )(lpVtbl[1]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISynchronizeMutex*, uint> )(lpVtbl[2]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISynchronize.Wait"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Wait([NativeTypeName("DWORD")] uint dwFlags, [NativeTypeName("DWORD")] uint dwMilliseconds)
    {
        return ((delegate* unmanaged<ISynchronizeMutex*, uint, uint, int> )(lpVtbl[3]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this), dwFlags, dwMilliseconds);
    }

    /// <inheritdoc cref = "ISynchronize.Signal"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Signal()
    {
        return ((delegate* unmanaged<ISynchronizeMutex*, int> )(lpVtbl[4]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ISynchronize.Reset"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<ISynchronizeMutex*, int> )(lpVtbl[5]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISynchronizeMutex.xml' path='doc/member[@name="ISynchronizeMutex.ReleaseMutex"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReleaseMutex()
    {
        return ((delegate* unmanaged<ISynchronizeMutex*, int> )(lpVtbl[6]))((ISynchronizeMutex*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : ISynchronize.Interface
    {
        [VtblIndex(6)]
        HRESULT ReleaseMutex();
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
        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> Wait;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Signal;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> ReleaseMutex;
    }
}