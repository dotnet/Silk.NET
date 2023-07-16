// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IProcessLock.xml' path='doc/member[@name="IProcessLock"]/*'/>
[Guid("000001D5-0000-0000-C000-000000000046")]
[NativeTypeName("struct IProcessLock : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IProcessLock : IProcessLock.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProcessLock));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProcessLock*, Guid*, void**, int> )(lpVtbl[0]))((IProcessLock*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProcessLock*, uint> )(lpVtbl[1]))((IProcessLock*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProcessLock*, uint> )(lpVtbl[2]))((IProcessLock*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IProcessLock.xml' path='doc/member[@name="IProcessLock.AddRefOnProcess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("ULONG")]
    public uint AddRefOnProcess()
    {
        return ((delegate* unmanaged<IProcessLock*, uint> )(lpVtbl[3]))((IProcessLock*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IProcessLock.xml' path='doc/member[@name="IProcessLock.ReleaseRefOnProcess"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    [return: NativeTypeName("ULONG")]
    public uint ReleaseRefOnProcess()
    {
        return ((delegate* unmanaged<IProcessLock*, uint> )(lpVtbl[4]))((IProcessLock*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("ULONG")]
        uint AddRefOnProcess();
        [VtblIndex(4)]
        [return: NativeTypeName("ULONG")]
        uint ReleaseRefOnProcess();
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
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRefOnProcess;
        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> ReleaseRefOnProcess;
    }
}