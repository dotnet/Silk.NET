// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ICreateTypeLib2.xml' path='doc/member[@name="ICreateTypeLib2"]/*'/>
[Guid("0002040F-0000-0000-C000-000000000046")]
[NativeTypeName("struct ICreateTypeLib2 : ICreateTypeLib")]
[NativeInheritance("ICreateTypeLib")]
public unsafe partial struct ICreateTypeLib2 : ICreateTypeLib2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICreateTypeLib2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, Guid*, void**, int> )(lpVtbl[0]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, uint> )(lpVtbl[1]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, uint> )(lpVtbl[2]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "ICreateTypeLib.CreateTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateTypeInfo([NativeTypeName("LPOLESTR")] ushort* szName, TYPEKIND tkind, ICreateTypeInfo** ppCTInfo)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, ushort*, TYPEKIND, ICreateTypeInfo**, int> )(lpVtbl[3]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szName, tkind, ppCTInfo);
    }

    /// <inheritdoc cref = "ICreateTypeLib.SetName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetName([NativeTypeName("LPOLESTR")] ushort* szName)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, ushort*, int> )(lpVtbl[4]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szName);
    }

    /// <inheritdoc cref = "ICreateTypeLib.SetVersion"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetVersion([NativeTypeName("WORD")] ushort wMajorVerNum, [NativeTypeName("WORD")] ushort wMinorVerNum)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, ushort, ushort, int> )(lpVtbl[5]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), wMajorVerNum, wMinorVerNum);
    }

    /// <inheritdoc cref = "ICreateTypeLib.SetGuid"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetGuid([NativeTypeName("const GUID &")] Guid* guid)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, Guid*, int> )(lpVtbl[6]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), guid);
    }

    /// <inheritdoc cref = "ICreateTypeLib.SetDocString"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDocString([NativeTypeName("LPOLESTR")] ushort* szDoc)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, ushort*, int> )(lpVtbl[7]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szDoc);
    }

    /// <inheritdoc cref = "ICreateTypeLib.SetHelpFileName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetHelpFileName([NativeTypeName("LPOLESTR")] ushort* szHelpFileName)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, ushort*, int> )(lpVtbl[8]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szHelpFileName);
    }

    /// <inheritdoc cref = "ICreateTypeLib.SetHelpContext"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetHelpContext([NativeTypeName("DWORD")] uint dwHelpContext)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, uint, int> )(lpVtbl[9]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), dwHelpContext);
    }

    /// <inheritdoc cref = "ICreateTypeLib.SetLcid"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetLcid([NativeTypeName("LCID")] uint lcid)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, uint, int> )(lpVtbl[10]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), lcid);
    }

    /// <inheritdoc cref = "ICreateTypeLib.SetLibFlags"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetLibFlags(uint uLibFlags)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, uint, int> )(lpVtbl[11]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), uLibFlags);
    }

    /// <inheritdoc cref = "ICreateTypeLib.SaveAllChanges"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SaveAllChanges()
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, int> )(lpVtbl[12]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ICreateTypeLib2.xml' path='doc/member[@name="ICreateTypeLib2.DeleteTypeInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT DeleteTypeInfo([NativeTypeName("LPOLESTR")] ushort* szName)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, ushort*, int> )(lpVtbl[13]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szName);
    }

    /// <include file='ICreateTypeLib2.xml' path='doc/member[@name="ICreateTypeLib2.SetCustData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetCustData([NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, Guid*, VARIANT*, int> )(lpVtbl[14]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), guid, pVarVal);
    }

    /// <include file='ICreateTypeLib2.xml' path='doc/member[@name="ICreateTypeLib2.SetHelpStringContext"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetHelpStringContext([NativeTypeName("ULONG")] uint dwHelpStringContext)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, uint, int> )(lpVtbl[15]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), dwHelpStringContext);
    }

    /// <include file='ICreateTypeLib2.xml' path='doc/member[@name="ICreateTypeLib2.SetHelpStringDll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetHelpStringDll([NativeTypeName("LPOLESTR")] ushort* szFileName)
    {
        return ((delegate* unmanaged<ICreateTypeLib2*, ushort*, int> )(lpVtbl[16]))((ICreateTypeLib2*)Unsafe.AsPointer(ref this), szFileName);
    }

    public interface Interface : ICreateTypeLib.Interface
    {
        [VtblIndex(13)]
        HRESULT DeleteTypeInfo([NativeTypeName("LPOLESTR")] ushort* szName);
        [VtblIndex(14)]
        HRESULT SetCustData([NativeTypeName("const GUID &")] Guid* guid, VARIANT* pVarVal);
        [VtblIndex(15)]
        HRESULT SetHelpStringContext([NativeTypeName("ULONG")] uint dwHelpStringContext);
        [VtblIndex(16)]
        HRESULT SetHelpStringDll([NativeTypeName("LPOLESTR")] ushort* szFileName);
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
        [NativeTypeName("HRESULT (LPOLESTR, TYPEKIND, ICreateTypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, TYPEKIND, ICreateTypeInfo**, int> CreateTypeInfo;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetName;
        [NativeTypeName("HRESULT (WORD, WORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, ushort, int> SetVersion;
        [NativeTypeName("HRESULT (const GUID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetGuid;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDocString;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetHelpFileName;
        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetHelpContext;
        [NativeTypeName("HRESULT (LCID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetLcid;
        [NativeTypeName("HRESULT (UINT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetLibFlags;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> SaveAllChanges;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> DeleteTypeInfo;
        [NativeTypeName("HRESULT (const GUID &, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, VARIANT*, int> SetCustData;
        [NativeTypeName("HRESULT (ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetHelpStringContext;
        [NativeTypeName("HRESULT (LPOLESTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetHelpStringDll;
    }
}