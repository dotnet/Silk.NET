// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/tlogstg.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='ITravelLogStg.xml' path='doc/member[@name="ITravelLogStg"]/*'/>
[Guid("7EBFDD80-AD18-11D3-A4C5-00C04F72D6B8")]
[NativeTypeName("struct ITravelLogStg : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITravelLogStg : ITravelLogStg.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITravelLogStg));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITravelLogStg*, Guid*, void**, int> )(lpVtbl[0]))((ITravelLogStg*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITravelLogStg*, uint> )(lpVtbl[1]))((ITravelLogStg*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITravelLogStg*, uint> )(lpVtbl[2]))((ITravelLogStg*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ITravelLogStg.xml' path='doc/member[@name="ITravelLogStg.CreateEntry"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateEntry([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("LPCWSTR")] ushort* pszTitle, ITravelLogEntry* ptleRelativeTo, BOOL fPrepend, ITravelLogEntry** pptle)
    {
        return ((delegate* unmanaged<ITravelLogStg*, ushort*, ushort*, ITravelLogEntry*, BOOL, ITravelLogEntry**, int> )(lpVtbl[3]))((ITravelLogStg*)Unsafe.AsPointer(ref this), pszUrl, pszTitle, ptleRelativeTo, fPrepend, pptle);
    }

    /// <include file='ITravelLogStg.xml' path='doc/member[@name="ITravelLogStg.TravelTo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT TravelTo(ITravelLogEntry* ptle)
    {
        return ((delegate* unmanaged<ITravelLogStg*, ITravelLogEntry*, int> )(lpVtbl[4]))((ITravelLogStg*)Unsafe.AsPointer(ref this), ptle);
    }

    /// <include file='ITravelLogStg.xml' path='doc/member[@name="ITravelLogStg.EnumEntries"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT EnumEntries([NativeTypeName("TLENUMF")] uint flags, IEnumTravelLogEntry** ppenum)
    {
        return ((delegate* unmanaged<ITravelLogStg*, uint, IEnumTravelLogEntry**, int> )(lpVtbl[5]))((ITravelLogStg*)Unsafe.AsPointer(ref this), flags, ppenum);
    }

    /// <include file='ITravelLogStg.xml' path='doc/member[@name="ITravelLogStg.FindEntries"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT FindEntries([NativeTypeName("TLENUMF")] uint flags, [NativeTypeName("LPCWSTR")] ushort* pszUrl, IEnumTravelLogEntry** ppenum)
    {
        return ((delegate* unmanaged<ITravelLogStg*, uint, ushort*, IEnumTravelLogEntry**, int> )(lpVtbl[6]))((ITravelLogStg*)Unsafe.AsPointer(ref this), flags, pszUrl, ppenum);
    }

    /// <include file='ITravelLogStg.xml' path='doc/member[@name="ITravelLogStg.GetCount"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetCount([NativeTypeName("TLENUMF")] uint flags, [NativeTypeName("DWORD *")] uint* pcEntries)
    {
        return ((delegate* unmanaged<ITravelLogStg*, uint, uint*, int> )(lpVtbl[7]))((ITravelLogStg*)Unsafe.AsPointer(ref this), flags, pcEntries);
    }

    /// <include file='ITravelLogStg.xml' path='doc/member[@name="ITravelLogStg.RemoveEntry"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveEntry(ITravelLogEntry* ptle)
    {
        return ((delegate* unmanaged<ITravelLogStg*, ITravelLogEntry*, int> )(lpVtbl[8]))((ITravelLogStg*)Unsafe.AsPointer(ref this), ptle);
    }

    /// <include file='ITravelLogStg.xml' path='doc/member[@name="ITravelLogStg.GetRelativeEntry"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetRelativeEntry(int iOffset, ITravelLogEntry** ptle)
    {
        return ((delegate* unmanaged<ITravelLogStg*, int, ITravelLogEntry**, int> )(lpVtbl[9]))((ITravelLogStg*)Unsafe.AsPointer(ref this), iOffset, ptle);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateEntry([NativeTypeName("LPCWSTR")] ushort* pszUrl, [NativeTypeName("LPCWSTR")] ushort* pszTitle, ITravelLogEntry* ptleRelativeTo, BOOL fPrepend, ITravelLogEntry** pptle);
        [VtblIndex(4)]
        HRESULT TravelTo(ITravelLogEntry* ptle);
        [VtblIndex(5)]
        HRESULT EnumEntries([NativeTypeName("TLENUMF")] uint flags, IEnumTravelLogEntry** ppenum);
        [VtblIndex(6)]
        HRESULT FindEntries([NativeTypeName("TLENUMF")] uint flags, [NativeTypeName("LPCWSTR")] ushort* pszUrl, IEnumTravelLogEntry** ppenum);
        [VtblIndex(7)]
        HRESULT GetCount([NativeTypeName("TLENUMF")] uint flags, [NativeTypeName("DWORD *")] uint* pcEntries);
        [VtblIndex(8)]
        HRESULT RemoveEntry(ITravelLogEntry* ptle);
        [VtblIndex(9)]
        HRESULT GetRelativeEntry(int iOffset, ITravelLogEntry** ptle);
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
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, ITravelLogEntry *, BOOL, ITravelLogEntry **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, ITravelLogEntry*, BOOL, ITravelLogEntry**, int> CreateEntry;
        [NativeTypeName("HRESULT (ITravelLogEntry *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITravelLogEntry*, int> TravelTo;
        [NativeTypeName("HRESULT (TLENUMF, IEnumTravelLogEntry **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IEnumTravelLogEntry**, int> EnumEntries;
        [NativeTypeName("HRESULT (TLENUMF, LPCWSTR, IEnumTravelLogEntry **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, IEnumTravelLogEntry**, int> FindEntries;
        [NativeTypeName("HRESULT (TLENUMF, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetCount;
        [NativeTypeName("HRESULT (ITravelLogEntry *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITravelLogEntry*, int> RemoveEntry;
        [NativeTypeName("HRESULT (int, ITravelLogEntry **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ITravelLogEntry**, int> GetRelativeEntry;
    }
}