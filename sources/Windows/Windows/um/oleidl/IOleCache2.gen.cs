// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oleidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IOleCache2.xml' path='doc/member[@name="IOleCache2"]/*'/>
[Guid("00000128-0000-0000-C000-000000000046")]
[NativeTypeName("struct IOleCache2 : IOleCache")]
[NativeInheritance("IOleCache")]
public unsafe partial struct IOleCache2 : IOleCache2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOleCache2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOleCache2*, Guid*, void**, int> )(lpVtbl[0]))((IOleCache2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOleCache2*, uint> )(lpVtbl[1]))((IOleCache2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOleCache2*, uint> )(lpVtbl[2]))((IOleCache2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IOleCache.Cache"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Cache(FORMATETC* pformatetc, [NativeTypeName("DWORD")] uint advf, [NativeTypeName("DWORD *")] uint* pdwConnection)
    {
        return ((delegate* unmanaged<IOleCache2*, FORMATETC*, uint, uint*, int> )(lpVtbl[3]))((IOleCache2*)Unsafe.AsPointer(ref this), pformatetc, advf, pdwConnection);
    }

    /// <inheritdoc cref = "IOleCache.Uncache"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Uncache([NativeTypeName("DWORD")] uint dwConnection)
    {
        return ((delegate* unmanaged<IOleCache2*, uint, int> )(lpVtbl[4]))((IOleCache2*)Unsafe.AsPointer(ref this), dwConnection);
    }

    /// <inheritdoc cref = "IOleCache.EnumCache"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumCache(IEnumSTATDATA** ppenumSTATDATA)
    {
        return ((delegate* unmanaged<IOleCache2*, IEnumSTATDATA**, int> )(lpVtbl[5]))((IOleCache2*)Unsafe.AsPointer(ref this), ppenumSTATDATA);
    }

    /// <inheritdoc cref = "IOleCache.InitCache"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT InitCache(IDataObject* pDataObject)
    {
        return ((delegate* unmanaged<IOleCache2*, IDataObject*, int> )(lpVtbl[6]))((IOleCache2*)Unsafe.AsPointer(ref this), pDataObject);
    }

    /// <inheritdoc cref = "IOleCache.SetData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetData(FORMATETC* pformatetc, STGMEDIUM* pmedium, BOOL fRelease)
    {
        return ((delegate* unmanaged<IOleCache2*, FORMATETC*, STGMEDIUM*, BOOL, int> )(lpVtbl[7]))((IOleCache2*)Unsafe.AsPointer(ref this), pformatetc, pmedium, fRelease);
    }

    /// <include file='IOleCache2.xml' path='doc/member[@name="IOleCache2.UpdateCache"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT UpdateCache([NativeTypeName("LPDATAOBJECT")] IDataObject* pDataObject, [NativeTypeName("DWORD")] uint grfUpdf, [NativeTypeName("LPVOID")] void* pReserved)
    {
        return ((delegate* unmanaged<IOleCache2*, IDataObject*, uint, void*, int> )(lpVtbl[8]))((IOleCache2*)Unsafe.AsPointer(ref this), pDataObject, grfUpdf, pReserved);
    }

    /// <include file='IOleCache2.xml' path='doc/member[@name="IOleCache2.DiscardCache"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT DiscardCache([NativeTypeName("DWORD")] uint dwDiscardOptions)
    {
        return ((delegate* unmanaged<IOleCache2*, uint, int> )(lpVtbl[9]))((IOleCache2*)Unsafe.AsPointer(ref this), dwDiscardOptions);
    }

    public interface Interface : IOleCache.Interface
    {
        [VtblIndex(8)]
        HRESULT UpdateCache([NativeTypeName("LPDATAOBJECT")] IDataObject* pDataObject, [NativeTypeName("DWORD")] uint grfUpdf, [NativeTypeName("LPVOID")] void* pReserved);
        [VtblIndex(9)]
        HRESULT DiscardCache([NativeTypeName("DWORD")] uint dwDiscardOptions);
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
        [NativeTypeName("HRESULT (FORMATETC *, DWORD, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FORMATETC*, uint, uint*, int> Cache;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Uncache;
        [NativeTypeName("HRESULT (IEnumSTATDATA **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSTATDATA**, int> EnumCache;
        [NativeTypeName("HRESULT (IDataObject *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject*, int> InitCache;
        [NativeTypeName("HRESULT (FORMATETC *, STGMEDIUM *, BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FORMATETC*, STGMEDIUM*, BOOL, int> SetData;
        [NativeTypeName("HRESULT (LPDATAOBJECT, DWORD, LPVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDataObject*, uint, void*, int> UpdateCache;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> DiscardCache;
    }
}