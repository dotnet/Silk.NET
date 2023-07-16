// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ITfMouseTracker.xml' path='doc/member[@name="ITfMouseTracker"]/*'/>
[Guid("09D146CD-A544-4132-925B-7AFA8EF322D0")]
[NativeTypeName("struct ITfMouseTracker : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfMouseTracker : ITfMouseTracker.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfMouseTracker));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfMouseTracker*, Guid*, void**, int> )(lpVtbl[0]))((ITfMouseTracker*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfMouseTracker*, uint> )(lpVtbl[1]))((ITfMouseTracker*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfMouseTracker*, uint> )(lpVtbl[2]))((ITfMouseTracker*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITfMouseTracker.xml' path='doc/member[@name="ITfMouseTracker.AdviseMouseSink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AdviseMouseSink(ITfRange* range, ITfMouseSink* pSink, [NativeTypeName("DWORD *")] uint* pdwCookie)
    {
        return ((delegate* unmanaged<ITfMouseTracker*, ITfRange*, ITfMouseSink*, uint*, int> )(lpVtbl[3]))((ITfMouseTracker*)Unsafe.AsPointer(ref this), range, pSink, pdwCookie);
    }

    /// <include file='ITfMouseTracker.xml' path='doc/member[@name="ITfMouseTracker.UnadviseMouseSink"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT UnadviseMouseSink([NativeTypeName("DWORD")] uint dwCookie)
    {
        return ((delegate* unmanaged<ITfMouseTracker*, uint, int> )(lpVtbl[4]))((ITfMouseTracker*)Unsafe.AsPointer(ref this), dwCookie);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AdviseMouseSink(ITfRange* range, ITfMouseSink* pSink, [NativeTypeName("DWORD *")] uint* pdwCookie);
        [VtblIndex(4)]
        HRESULT UnadviseMouseSink([NativeTypeName("DWORD")] uint dwCookie);
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
        [NativeTypeName("HRESULT (ITfRange *, ITfMouseSink *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITfRange*, ITfMouseSink*, uint*, int> AdviseMouseSink;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> UnadviseMouseSink;
    }
}