// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='FolderItem2.xml' path='doc/member[@name="FolderItem2"]/*'/>
[Guid("EDC817AA-92B8-11D1-B075-00C04FC33AA5")]
[NativeTypeName("struct FolderItem2 : FolderItem")]
[NativeInheritance("FolderItem")]
public unsafe partial struct FolderItem2 : FolderItem2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_FolderItem2));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<FolderItem2*, Guid*, void**, int> )(lpVtbl[0]))((FolderItem2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<FolderItem2*, uint> )(lpVtbl[1]))((FolderItem2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<FolderItem2*, uint> )(lpVtbl[2]))((FolderItem2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<FolderItem2*, uint*, int> )(lpVtbl[3]))((FolderItem2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<FolderItem2*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((FolderItem2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<FolderItem2*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((FolderItem2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<FolderItem2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((FolderItem2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "FolderItem.get_Application"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Application(IDispatch** ppid)
    {
        return ((delegate* unmanaged<FolderItem2*, IDispatch**, int> )(lpVtbl[7]))((FolderItem2*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <inheritdoc cref = "FolderItem.get_Parent"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Parent(IDispatch** ppid)
    {
        return ((delegate* unmanaged<FolderItem2*, IDispatch**, int> )(lpVtbl[8]))((FolderItem2*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <inheritdoc cref = "FolderItem.get_Name"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<FolderItem2*, ushort**, int> )(lpVtbl[9]))((FolderItem2*)Unsafe.AsPointer(ref this), pbs);
    }

    /// <inheritdoc cref = "FolderItem.put_Name"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_Name([NativeTypeName("BSTR")] ushort* bs)
    {
        return ((delegate* unmanaged<FolderItem2*, ushort*, int> )(lpVtbl[10]))((FolderItem2*)Unsafe.AsPointer(ref this), bs);
    }

    /// <inheritdoc cref = "FolderItem.get_Path"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_Path([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<FolderItem2*, ushort**, int> )(lpVtbl[11]))((FolderItem2*)Unsafe.AsPointer(ref this), pbs);
    }

    /// <inheritdoc cref = "FolderItem.get_GetLink"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_GetLink(IDispatch** ppid)
    {
        return ((delegate* unmanaged<FolderItem2*, IDispatch**, int> )(lpVtbl[12]))((FolderItem2*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <inheritdoc cref = "FolderItem.get_GetFolder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_GetFolder(IDispatch** ppid)
    {
        return ((delegate* unmanaged<FolderItem2*, IDispatch**, int> )(lpVtbl[13]))((FolderItem2*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <inheritdoc cref = "FolderItem.get_IsLink"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_IsLink([NativeTypeName("VARIANT_BOOL *")] short* pb)
    {
        return ((delegate* unmanaged<FolderItem2*, short*, int> )(lpVtbl[14]))((FolderItem2*)Unsafe.AsPointer(ref this), pb);
    }

    /// <inheritdoc cref = "FolderItem.get_IsFolder"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsFolder([NativeTypeName("VARIANT_BOOL *")] short* pb)
    {
        return ((delegate* unmanaged<FolderItem2*, short*, int> )(lpVtbl[15]))((FolderItem2*)Unsafe.AsPointer(ref this), pb);
    }

    /// <inheritdoc cref = "FolderItem.get_IsFileSystem"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_IsFileSystem([NativeTypeName("VARIANT_BOOL *")] short* pb)
    {
        return ((delegate* unmanaged<FolderItem2*, short*, int> )(lpVtbl[16]))((FolderItem2*)Unsafe.AsPointer(ref this), pb);
    }

    /// <inheritdoc cref = "FolderItem.get_IsBrowsable"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT get_IsBrowsable([NativeTypeName("VARIANT_BOOL *")] short* pb)
    {
        return ((delegate* unmanaged<FolderItem2*, short*, int> )(lpVtbl[17]))((FolderItem2*)Unsafe.AsPointer(ref this), pb);
    }

    /// <inheritdoc cref = "FolderItem.get_ModifyDate"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_ModifyDate([NativeTypeName("DATE *")] double* pdt)
    {
        return ((delegate* unmanaged<FolderItem2*, double*, int> )(lpVtbl[18]))((FolderItem2*)Unsafe.AsPointer(ref this), pdt);
    }

    /// <inheritdoc cref = "FolderItem.put_ModifyDate"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_ModifyDate([NativeTypeName("DATE")] double dt)
    {
        return ((delegate* unmanaged<FolderItem2*, double, int> )(lpVtbl[19]))((FolderItem2*)Unsafe.AsPointer(ref this), dt);
    }

    /// <inheritdoc cref = "FolderItem.get_Size"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Size([NativeTypeName("LONG *")] int* pul)
    {
        return ((delegate* unmanaged<FolderItem2*, int*, int> )(lpVtbl[20]))((FolderItem2*)Unsafe.AsPointer(ref this), pul);
    }

    /// <inheritdoc cref = "FolderItem.get_Type"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Type([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<FolderItem2*, ushort**, int> )(lpVtbl[21]))((FolderItem2*)Unsafe.AsPointer(ref this), pbs);
    }

    /// <inheritdoc cref = "FolderItem.Verbs"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT Verbs(FolderItemVerbs** ppfic)
    {
        return ((delegate* unmanaged<FolderItem2*, FolderItemVerbs**, int> )(lpVtbl[22]))((FolderItem2*)Unsafe.AsPointer(ref this), ppfic);
    }

    /// <inheritdoc cref = "FolderItem.InvokeVerb"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT InvokeVerb(VARIANT vVerb)
    {
        return ((delegate* unmanaged<FolderItem2*, VARIANT, int> )(lpVtbl[23]))((FolderItem2*)Unsafe.AsPointer(ref this), vVerb);
    }

    /// <include file='FolderItem2.xml' path='doc/member[@name="FolderItem2.InvokeVerbEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT InvokeVerbEx(VARIANT vVerb, VARIANT vArgs)
    {
        return ((delegate* unmanaged<FolderItem2*, VARIANT, VARIANT, int> )(lpVtbl[24]))((FolderItem2*)Unsafe.AsPointer(ref this), vVerb, vArgs);
    }

    /// <include file='FolderItem2.xml' path='doc/member[@name="FolderItem2.ExtendedProperty"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT ExtendedProperty([NativeTypeName("BSTR")] ushort* bstrPropName, VARIANT* pvRet)
    {
        return ((delegate* unmanaged<FolderItem2*, ushort*, VARIANT*, int> )(lpVtbl[25]))((FolderItem2*)Unsafe.AsPointer(ref this), bstrPropName, pvRet);
    }

    public interface Interface : FolderItem.Interface
    {
        [VtblIndex(24)]
        HRESULT InvokeVerbEx(VARIANT vVerb, VARIANT vArgs);
        [VtblIndex(25)]
        HRESULT ExtendedProperty([NativeTypeName("BSTR")] ushort* bstrPropName, VARIANT* pvRet);
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
        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;
        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;
        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Application;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Parent;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;
        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_Name;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Path;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_GetLink;
        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_GetFolder;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsLink;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsFolder;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsFileSystem;
        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsBrowsable;
        [NativeTypeName("HRESULT (DATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_ModifyDate;
        [NativeTypeName("HRESULT (DATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_ModifyDate;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Size;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Type;
        [NativeTypeName("HRESULT (FolderItemVerbs **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItemVerbs**, int> Verbs;
        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> InvokeVerb;
        [NativeTypeName("HRESULT (VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, int> InvokeVerbEx;
        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> ExtendedProperty;
    }
}