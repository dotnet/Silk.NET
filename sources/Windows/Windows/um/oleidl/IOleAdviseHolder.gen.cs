// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IOleAdviseHolder.xml' path='doc/member[@name="IOleAdviseHolder"]/*'/>
[Guid("00000111-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleAdviseHolder : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOleAdviseHolder : IOleAdviseHolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleAdviseHolder));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleAdviseHolder*, Guid*, void**, int> )(lpVtbl[0]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleAdviseHolder*, uint> )(lpVtbl[1]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleAdviseHolder*, uint> )(lpVtbl[2]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleAdviseHolder.xml' path='doc/member[@name="IOleAdviseHolder.Advise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Advise(IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection)
    {
        return ((delegate* unmanaged<IOleAdviseHolder*, IAdviseSink*, uint*, int> )(lpVtbl[3]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), pAdvise, pdwConnection);
    }

    /// <include file='IOleAdviseHolder.xml' path='doc/member[@name="IOleAdviseHolder.Unadvise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Unadvise([NativeTypeName("DWORD")] uint dwConnection)
    {
        return ((delegate* unmanaged<IOleAdviseHolder*, uint, int> )(lpVtbl[4]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), dwConnection);
    }

    /// <include file='IOleAdviseHolder.xml' path='doc/member[@name="IOleAdviseHolder.EnumAdvise"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumAdvise(IEnumSTATDATA** ppenumAdvise)
    {
        return ((delegate* unmanaged<IOleAdviseHolder*, IEnumSTATDATA**, int> )(lpVtbl[5]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), ppenumAdvise);
    }

    /// <include file='IOleAdviseHolder.xml' path='doc/member[@name="IOleAdviseHolder.SendOnRename"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SendOnRename(IMoniker* pmk)
    {
        return ((delegate* unmanaged<IOleAdviseHolder*, IMoniker*, int> )(lpVtbl[6]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this), pmk);
    }

    /// <include file='IOleAdviseHolder.xml' path='doc/member[@name="IOleAdviseHolder.SendOnSave"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SendOnSave()
    {
        return ((delegate* unmanaged<IOleAdviseHolder*, int> )(lpVtbl[7]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOleAdviseHolder.xml' path='doc/member[@name="IOleAdviseHolder.SendOnClose"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SendOnClose()
    {
        return ((delegate* unmanaged<IOleAdviseHolder*, int> )(lpVtbl[8]))((IOleAdviseHolder*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Advise(IAdviseSink* pAdvise, [NativeTypeName("DWORD *")] uint* pdwConnection);
        [VtblIndex(4)]
        HRESULT Unadvise([NativeTypeName("DWORD")] uint dwConnection);
        [VtblIndex(5)]
        HRESULT EnumAdvise(IEnumSTATDATA** ppenumAdvise);
        [VtblIndex(6)]
        HRESULT SendOnRename(IMoniker* pmk);
        [VtblIndex(7)]
        HRESULT SendOnSave();
        [VtblIndex(8)]
        HRESULT SendOnClose();
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
        [NativeTypeName("HRESULT (IAdviseSink *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IAdviseSink*, uint*, int> Advise;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Unadvise;
        [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSTATDATA**, int> EnumAdvise;
        [NativeTypeName("HRESULT (IMoniker *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IMoniker*, int> SendOnRename;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SendOnSave;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SendOnClose;
    }
}