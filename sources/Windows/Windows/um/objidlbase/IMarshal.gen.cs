// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/objidlbase.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IMarshal.xml' path='doc/member[@name="IMarshal"]/*' />
[Guid("00000003-0000-0000-C000-000000000046")]
[NativeTypeName("struct IMarshal : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IMarshal : IMarshal.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IMarshal));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IMarshal*, Guid*, void**, int>)(lpVtbl[0]))((IMarshal*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IMarshal*, uint>)(lpVtbl[1]))((IMarshal*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IMarshal*, uint>)(lpVtbl[2]))((IMarshal*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal.GetUnmarshalClass"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetUnmarshalClass([NativeTypeName("const IID &")] Guid* riid, void* pv, [NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("CLSID *")] Guid* pCid)
    {
        return ((delegate* unmanaged<IMarshal*, Guid*, void*, uint, void*, uint, Guid*, int>)(lpVtbl[3]))((IMarshal*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pCid);
    }

    /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal.GetMarshalSizeMax"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMarshalSizeMax([NativeTypeName("const IID &")] Guid* riid, void* pv, [NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("DWORD *")] uint* pSize)
    {
        return ((delegate* unmanaged<IMarshal*, Guid*, void*, uint, void*, uint, uint*, int>)(lpVtbl[4]))((IMarshal*)Unsafe.AsPointer(ref this), riid, pv, dwDestContext, pvDestContext, mshlflags, pSize);
    }

    /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal.MarshalInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT MarshalInterface(IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, void* pv, [NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags)
    {
        return ((delegate* unmanaged<IMarshal*, IStream*, Guid*, void*, uint, void*, uint, int>)(lpVtbl[5]))((IMarshal*)Unsafe.AsPointer(ref this), pStm, riid, pv, dwDestContext, pvDestContext, mshlflags);
    }

    /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal.UnmarshalInterface"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT UnmarshalInterface(IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, void** ppv)
    {
        return ((delegate* unmanaged<IMarshal*, IStream*, Guid*, void**, int>)(lpVtbl[6]))((IMarshal*)Unsafe.AsPointer(ref this), pStm, riid, ppv);
    }

    /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal.ReleaseMarshalData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT ReleaseMarshalData(IStream* pStm)
    {
        return ((delegate* unmanaged<IMarshal*, IStream*, int>)(lpVtbl[7]))((IMarshal*)Unsafe.AsPointer(ref this), pStm);
    }

    /// <include file='IMarshal.xml' path='doc/member[@name="IMarshal.DisconnectObject"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DisconnectObject([NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<IMarshal*, uint, int>)(lpVtbl[8]))((IMarshal*)Unsafe.AsPointer(ref this), dwReserved);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetUnmarshalClass([NativeTypeName("const IID &")] Guid* riid, void* pv, [NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("CLSID *")] Guid* pCid);

        [VtblIndex(4)]
        HRESULT GetMarshalSizeMax([NativeTypeName("const IID &")] Guid* riid, void* pv, [NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags, [NativeTypeName("DWORD *")] uint* pSize);

        [VtblIndex(5)]
        HRESULT MarshalInterface(IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, void* pv, [NativeTypeName("DWORD")] uint dwDestContext, void* pvDestContext, [NativeTypeName("DWORD")] uint mshlflags);

        [VtblIndex(6)]
        HRESULT UnmarshalInterface(IStream* pStm, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

        [VtblIndex(7)]
        HRESULT ReleaseMarshalData(IStream* pStm);

        [VtblIndex(8)]
        HRESULT DisconnectObject([NativeTypeName("DWORD")] uint dwReserved);
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

        [NativeTypeName("HRESULT (const IID &, void *, DWORD, void *, DWORD, CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void*, uint, void*, uint, Guid*, int> GetUnmarshalClass;

        [NativeTypeName("HRESULT (const IID &, void *, DWORD, void *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void*, uint, void*, uint, uint*, int> GetMarshalSizeMax;

        [NativeTypeName("HRESULT (IStream *, const IID &, void *, DWORD, void *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, Guid*, void*, uint, void*, uint, int> MarshalInterface;

        [NativeTypeName("HRESULT (IStream *, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, Guid*, void**, int> UnmarshalInterface;

        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> ReleaseMarshalData;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DisconnectObject;
    }
}
