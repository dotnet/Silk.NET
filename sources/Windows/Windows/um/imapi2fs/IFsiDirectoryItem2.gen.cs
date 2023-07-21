// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IFsiDirectoryItem2.xml' path='doc/member[@name="IFsiDirectoryItem2"]/*' />
[Guid("F7FB4B9B-6D96-4D7B-9115-201B144811EF")]
[NativeTypeName("struct IFsiDirectoryItem2 : IFsiDirectoryItem")]
[NativeInheritance("IFsiDirectoryItem")]
public unsafe partial struct IFsiDirectoryItem2 : IFsiDirectoryItem2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFsiDirectoryItem2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, Guid*, void**, int>)(lpVtbl[0]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, uint>)(lpVtbl[1]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, uint>)(lpVtbl[2]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, uint*, int>)(lpVtbl[3]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref="IFsiItem.get_Name" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort**, int>)(lpVtbl[7]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref="IFsiItem.get_FullPath" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FullPath([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort**, int>)(lpVtbl[8]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref="IFsiItem.get_CreationTime" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CreationTime([NativeTypeName("DATE *")] double* pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, double*, int>)(lpVtbl[9]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref="IFsiItem.put_CreationTime" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_CreationTime([NativeTypeName("DATE")] double newVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, double, int>)(lpVtbl[10]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref="IFsiItem.get_LastAccessedTime" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_LastAccessedTime([NativeTypeName("DATE *")] double* pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, double*, int>)(lpVtbl[11]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref="IFsiItem.put_LastAccessedTime" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_LastAccessedTime([NativeTypeName("DATE")] double newVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, double, int>)(lpVtbl[12]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref="IFsiItem.get_LastModifiedTime" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_LastModifiedTime([NativeTypeName("DATE *")] double* pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, double*, int>)(lpVtbl[13]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref="IFsiItem.put_LastModifiedTime" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_LastModifiedTime([NativeTypeName("DATE")] double newVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, double, int>)(lpVtbl[14]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref="IFsiItem.get_IsHidden" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsHidden([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, short*, int>)(lpVtbl[15]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref="IFsiItem.put_IsHidden" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_IsHidden([NativeTypeName("VARIANT_BOOL")] short newVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, short, int>)(lpVtbl[16]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref="IFsiItem.FileSystemName" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT FileSystemName(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, FsiFileSystems, ushort**, int>)(lpVtbl[17]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), fileSystem, pVal);
    }

    /// <inheritdoc cref="IFsiItem.FileSystemPath" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT FileSystemPath(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, FsiFileSystems, ushort**, int>)(lpVtbl[18]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), fileSystem, pVal);
    }

    /// <inheritdoc cref="IFsiDirectoryItem.get__NewEnum" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get__NewEnum(IEnumVARIANT** NewEnum)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, IEnumVARIANT**, int>)(lpVtbl[19]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), NewEnum);
    }

    /// <inheritdoc cref="IFsiDirectoryItem.get_Item" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_Item([NativeTypeName("BSTR")] ushort* path, IFsiItem** item)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, IFsiItem**, int>)(lpVtbl[20]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), path, item);
    }

    /// <inheritdoc cref="IFsiDirectoryItem.get_Count" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* Count)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, int*, int>)(lpVtbl[21]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), Count);
    }

    /// <inheritdoc cref="IFsiDirectoryItem.get_EnumFsiItems" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_EnumFsiItems(IEnumFsiItems** NewEnum)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, IEnumFsiItems**, int>)(lpVtbl[22]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), NewEnum);
    }

    /// <inheritdoc cref="IFsiDirectoryItem.AddDirectory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT AddDirectory([NativeTypeName("BSTR")] ushort* path)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, int>)(lpVtbl[23]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), path);
    }

    /// <inheritdoc cref="IFsiDirectoryItem.AddFile" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT AddFile([NativeTypeName("BSTR")] ushort* path, IStream* fileData)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, IStream*, int>)(lpVtbl[24]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), path, fileData);
    }

    /// <inheritdoc cref="IFsiDirectoryItem.AddTree" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT AddTree([NativeTypeName("BSTR")] ushort* sourceDirectory, [NativeTypeName("VARIANT_BOOL")] short includeBaseDirectory)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, short, int>)(lpVtbl[25]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), sourceDirectory, includeBaseDirectory);
    }

    /// <inheritdoc cref="IFsiDirectoryItem.Add" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT Add(IFsiItem* item)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, IFsiItem*, int>)(lpVtbl[26]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), item);
    }

    /// <inheritdoc cref="IFsiDirectoryItem.Remove" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT Remove([NativeTypeName("BSTR")] ushort* path)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, int>)(lpVtbl[27]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), path);
    }

    /// <inheritdoc cref="IFsiDirectoryItem.RemoveTree" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT RemoveTree([NativeTypeName("BSTR")] ushort* path)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, int>)(lpVtbl[28]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), path);
    }

    /// <include file='IFsiDirectoryItem2.xml' path='doc/member[@name="IFsiDirectoryItem2.AddTreeWithNamedStreams"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT AddTreeWithNamedStreams([NativeTypeName("BSTR")] ushort* sourceDirectory, [NativeTypeName("VARIANT_BOOL")] short includeBaseDirectory)
    {
        return ((delegate* unmanaged<IFsiDirectoryItem2*, ushort*, short, int>)(lpVtbl[29]))((IFsiDirectoryItem2*)Unsafe.AsPointer(ref this), sourceDirectory, includeBaseDirectory);
    }

    public interface Interface : IFsiDirectoryItem.Interface
    {
        [VtblIndex(29)]
        HRESULT AddTreeWithNamedStreams([NativeTypeName("BSTR")] ushort* sourceDirectory, [NativeTypeName("VARIANT_BOOL")] short includeBaseDirectory);
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
        public delegate* unmanaged<TSelf*, ushort**, int> get_Name;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_FullPath;

        [NativeTypeName("HRESULT (DATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_CreationTime;

        [NativeTypeName("HRESULT (DATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_CreationTime;

        [NativeTypeName("HRESULT (DATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_LastAccessedTime;

        [NativeTypeName("HRESULT (DATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_LastAccessedTime;

        [NativeTypeName("HRESULT (DATE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double*, int> get_LastModifiedTime;

        [NativeTypeName("HRESULT (DATE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, double, int> put_LastModifiedTime;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_IsHidden;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_IsHidden;

        [NativeTypeName("HRESULT (FsiFileSystems, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems, ushort**, int> FileSystemName;

        [NativeTypeName("HRESULT (FsiFileSystems, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FsiFileSystems, ushort**, int> FileSystemPath;

        [NativeTypeName("HRESULT (IEnumVARIANT **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumVARIANT**, int> get__NewEnum;

        [NativeTypeName("HRESULT (BSTR, IFsiItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IFsiItem**, int> get_Item;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName("HRESULT (IEnumFsiItems **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumFsiItems**, int> get_EnumFsiItems;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> AddDirectory;

        [NativeTypeName("HRESULT (BSTR, IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IStream*, int> AddFile;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, int> AddTree;

        [NativeTypeName("HRESULT (IFsiItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IFsiItem*, int> Add;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> Remove;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RemoveTree;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short, int> AddTreeWithNamedStreams;
    }
}
