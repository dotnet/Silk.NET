// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='AsyncIAdviseSink.xml' path='doc/member[@name="AsyncIAdviseSink"]/*'/>
[Guid("00000150-0000-0000-C000-000000000046")]
[NativeTypeName("struct AsyncIAdviseSink : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct AsyncIAdviseSink : AsyncIAdviseSink.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_AsyncIAdviseSink));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<AsyncIAdviseSink*, Guid*, void**, int> )(lpVtbl[0]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<AsyncIAdviseSink*, uint> )(lpVtbl[1]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<AsyncIAdviseSink*, uint> )(lpVtbl[2]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='AsyncIAdviseSink.xml' path='doc/member[@name="AsyncIAdviseSink.Begin_OnDataChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void Begin_OnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed)
    {
        ((delegate* unmanaged<AsyncIAdviseSink*, FORMATETC*, STGMEDIUM*, void> )(lpVtbl[3]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), pFormatetc, pStgmed);
    }

    /// <include file='AsyncIAdviseSink.xml' path='doc/member[@name="AsyncIAdviseSink.Finish_OnDataChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public void Finish_OnDataChange()
    {
        ((delegate* unmanaged<AsyncIAdviseSink*, void> )(lpVtbl[4]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='AsyncIAdviseSink.xml' path='doc/member[@name="AsyncIAdviseSink.Begin_OnViewChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public void Begin_OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex)
    {
        ((delegate* unmanaged<AsyncIAdviseSink*, uint, int, void> )(lpVtbl[5]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), dwAspect, lindex);
    }

    /// <include file='AsyncIAdviseSink.xml' path='doc/member[@name="AsyncIAdviseSink.Finish_OnViewChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public void Finish_OnViewChange()
    {
        ((delegate* unmanaged<AsyncIAdviseSink*, void> )(lpVtbl[6]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='AsyncIAdviseSink.xml' path='doc/member[@name="AsyncIAdviseSink.Begin_OnRename"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void Begin_OnRename(IMoniker* pmk)
    {
        ((delegate* unmanaged<AsyncIAdviseSink*, IMoniker*, void> )(lpVtbl[7]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this), pmk);
    }

    /// <include file='AsyncIAdviseSink.xml' path='doc/member[@name="AsyncIAdviseSink.Finish_OnRename"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void Finish_OnRename()
    {
        ((delegate* unmanaged<AsyncIAdviseSink*, void> )(lpVtbl[8]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='AsyncIAdviseSink.xml' path='doc/member[@name="AsyncIAdviseSink.Begin_OnSave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void Begin_OnSave()
    {
        ((delegate* unmanaged<AsyncIAdviseSink*, void> )(lpVtbl[9]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='AsyncIAdviseSink.xml' path='doc/member[@name="AsyncIAdviseSink.Finish_OnSave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public void Finish_OnSave()
    {
        ((delegate* unmanaged<AsyncIAdviseSink*, void> )(lpVtbl[10]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='AsyncIAdviseSink.xml' path='doc/member[@name="AsyncIAdviseSink.Begin_OnClose"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public void Begin_OnClose()
    {
        ((delegate* unmanaged<AsyncIAdviseSink*, void> )(lpVtbl[11]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
    }

    /// <include file='AsyncIAdviseSink.xml' path='doc/member[@name="AsyncIAdviseSink.Finish_OnClose"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public void Finish_OnClose()
    {
        ((delegate* unmanaged<AsyncIAdviseSink*, void> )(lpVtbl[12]))((AsyncIAdviseSink*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        void Begin_OnDataChange(FORMATETC* pFormatetc, STGMEDIUM* pStgmed);
        [VtblIndex(4)]
        void Finish_OnDataChange();
        [VtblIndex(5)]
        void Begin_OnViewChange([NativeTypeName("DWORD")] uint dwAspect, [NativeTypeName("LONG")] int lindex);
        [VtblIndex(6)]
        void Finish_OnViewChange();
        [VtblIndex(7)]
        void Begin_OnRename(IMoniker* pmk);
        [VtblIndex(8)]
        void Finish_OnRename();
        [VtblIndex(9)]
        void Begin_OnSave();
        [VtblIndex(10)]
        void Finish_OnSave();
        [VtblIndex(11)]
        void Begin_OnClose();
        [VtblIndex(12)]
        void Finish_OnClose();
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
        [NativeTypeName("void (FORMATETC *, STGMEDIUM *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FORMATETC*, STGMEDIUM*, void> Begin_OnDataChange;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Finish_OnDataChange;
        [NativeTypeName("void (DWORD, LONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int, void> Begin_OnViewChange;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Finish_OnViewChange;
        [NativeTypeName("void (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, void> Begin_OnRename;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Finish_OnRename;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Begin_OnSave;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Finish_OnSave;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Begin_OnClose;
        [NativeTypeName("void () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void> Finish_OnClose;
    }
}