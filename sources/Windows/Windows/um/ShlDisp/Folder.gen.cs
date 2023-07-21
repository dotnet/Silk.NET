// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='Folder.xml' path='doc/member[@name="Folder"]/*' />
[Guid("BBCBDE60-C3FF-11CE-8350-444553540000")]
[NativeTypeName("struct Folder : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct Folder : Folder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_Folder));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<Folder*, Guid*, void**, int>)(lpVtbl[0]))((Folder*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<Folder*, uint>)(lpVtbl[1]))((Folder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<Folder*, uint>)(lpVtbl[2]))((Folder*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<Folder*, uint*, int>)(lpVtbl[3]))((Folder*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<Folder*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((Folder*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<Folder*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((Folder*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<Folder*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((Folder*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='Folder.xml' path='doc/member[@name="Folder.get_Title"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Title([NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<Folder*, ushort**, int>)(lpVtbl[7]))((Folder*)Unsafe.AsPointer(ref this), pbs);
    }

    /// <include file='Folder.xml' path='doc/member[@name="Folder.get_Application"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Application(IDispatch** ppid)
    {
        return ((delegate* unmanaged<Folder*, IDispatch**, int>)(lpVtbl[8]))((Folder*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='Folder.xml' path='doc/member[@name="Folder.get_Parent"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Parent(IDispatch** ppid)
    {
        return ((delegate* unmanaged<Folder*, IDispatch**, int>)(lpVtbl[9]))((Folder*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='Folder.xml' path='doc/member[@name="Folder.get_ParentFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_ParentFolder(Folder** ppsf)
    {
        return ((delegate* unmanaged<Folder*, Folder**, int>)(lpVtbl[10]))((Folder*)Unsafe.AsPointer(ref this), ppsf);
    }

    /// <include file='Folder.xml' path='doc/member[@name="Folder.Items"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Items(FolderItems** ppid)
    {
        return ((delegate* unmanaged<Folder*, FolderItems**, int>)(lpVtbl[11]))((Folder*)Unsafe.AsPointer(ref this), ppid);
    }

    /// <include file='Folder.xml' path='doc/member[@name="Folder.ParseName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT ParseName([NativeTypeName("BSTR")] ushort* bName, FolderItem** ppid)
    {
        return ((delegate* unmanaged<Folder*, ushort*, FolderItem**, int>)(lpVtbl[12]))((Folder*)Unsafe.AsPointer(ref this), bName, ppid);
    }

    /// <include file='Folder.xml' path='doc/member[@name="Folder.NewFolder"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT NewFolder([NativeTypeName("BSTR")] ushort* bName, VARIANT vOptions)
    {
        return ((delegate* unmanaged<Folder*, ushort*, VARIANT, int>)(lpVtbl[13]))((Folder*)Unsafe.AsPointer(ref this), bName, vOptions);
    }

    /// <include file='Folder.xml' path='doc/member[@name="Folder.MoveHere"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT MoveHere(VARIANT vItem, VARIANT vOptions)
    {
        return ((delegate* unmanaged<Folder*, VARIANT, VARIANT, int>)(lpVtbl[14]))((Folder*)Unsafe.AsPointer(ref this), vItem, vOptions);
    }

    /// <include file='Folder.xml' path='doc/member[@name="Folder.CopyHere"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT CopyHere(VARIANT vItem, VARIANT vOptions)
    {
        return ((delegate* unmanaged<Folder*, VARIANT, VARIANT, int>)(lpVtbl[15]))((Folder*)Unsafe.AsPointer(ref this), vItem, vOptions);
    }

    /// <include file='Folder.xml' path='doc/member[@name="Folder.GetDetailsOf"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetDetailsOf(VARIANT vItem, int iColumn, [NativeTypeName("BSTR *")] ushort** pbs)
    {
        return ((delegate* unmanaged<Folder*, VARIANT, int, ushort**, int>)(lpVtbl[16]))((Folder*)Unsafe.AsPointer(ref this), vItem, iColumn, pbs);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Title([NativeTypeName("BSTR *")] ushort** pbs);

        [VtblIndex(8)]
        HRESULT get_Application(IDispatch** ppid);

        [VtblIndex(9)]
        HRESULT get_Parent(IDispatch** ppid);

        [VtblIndex(10)]
        HRESULT get_ParentFolder(Folder** ppsf);

        [VtblIndex(11)]
        HRESULT Items(FolderItems** ppid);

        [VtblIndex(12)]
        HRESULT ParseName([NativeTypeName("BSTR")] ushort* bName, FolderItem** ppid);

        [VtblIndex(13)]
        HRESULT NewFolder([NativeTypeName("BSTR")] ushort* bName, VARIANT vOptions);

        [VtblIndex(14)]
        HRESULT MoveHere(VARIANT vItem, VARIANT vOptions);

        [VtblIndex(15)]
        HRESULT CopyHere(VARIANT vItem, VARIANT vOptions);

        [VtblIndex(16)]
        HRESULT GetDetailsOf(VARIANT vItem, int iColumn, [NativeTypeName("BSTR *")] ushort** pbs);
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Title;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Application;

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch**, int> get_Parent;

        [NativeTypeName("HRESULT (Folder **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Folder**, int> get_ParentFolder;

        [NativeTypeName("HRESULT (FolderItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FolderItems**, int> Items;

        [NativeTypeName("HRESULT (BSTR, FolderItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, FolderItem**, int> ParseName;

        [NativeTypeName("HRESULT (BSTR, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, int> NewFolder;

        [NativeTypeName("HRESULT (VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, int> MoveHere;

        [NativeTypeName("HRESULT (VARIANT, VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, VARIANT, int> CopyHere;

        [NativeTypeName("HRESULT (VARIANT, int, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int, ushort**, int> GetDetailsOf;
    }
}
