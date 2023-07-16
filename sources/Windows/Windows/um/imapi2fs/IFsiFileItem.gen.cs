// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/imapi2fs.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IFsiFileItem.xml' path='doc/member[@name="IFsiFileItem"]/*'/>
[Guid("2C941FDB-975B-59BE-A960-9A2A262853A5")]
[NativeTypeName("struct IFsiFileItem : IFsiItem")]
[NativeInheritance("IFsiItem")]
public unsafe partial struct IFsiFileItem : IFsiFileItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFsiFileItem));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFsiFileItem*, Guid*, void**, int> )(lpVtbl[0]))((IFsiFileItem*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFsiFileItem*, uint> )(lpVtbl[1]))((IFsiFileItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFsiFileItem*, uint> )(lpVtbl[2]))((IFsiFileItem*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfoCount"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IFsiFileItem*, uint*, int> )(lpVtbl[3]))((IFsiFileItem*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref = "IDispatch.GetTypeInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IFsiFileItem*, uint, uint, ITypeInfo**, int> )(lpVtbl[4]))((IFsiFileItem*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref = "IDispatch.GetIDsOfNames"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IFsiFileItem*, Guid*, ushort**, uint, uint, int*, int> )(lpVtbl[5]))((IFsiFileItem*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref = "IDispatch.Invoke"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IFsiFileItem*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> )(lpVtbl[6]))((IFsiFileItem*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <inheritdoc cref = "IFsiItem.get_Name"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT get_Name([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, ushort**, int> )(lpVtbl[7]))((IFsiFileItem*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiItem.get_FullPath"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_FullPath([NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, ushort**, int> )(lpVtbl[8]))((IFsiFileItem*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiItem.get_CreationTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_CreationTime([NativeTypeName("DATE *")] double* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, double*, int> )(lpVtbl[9]))((IFsiFileItem*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiItem.put_CreationTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT put_CreationTime([NativeTypeName("DATE")] double newVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, double, int> )(lpVtbl[10]))((IFsiFileItem*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFsiItem.get_LastAccessedTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_LastAccessedTime([NativeTypeName("DATE *")] double* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, double*, int> )(lpVtbl[11]))((IFsiFileItem*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiItem.put_LastAccessedTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT put_LastAccessedTime([NativeTypeName("DATE")] double newVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, double, int> )(lpVtbl[12]))((IFsiFileItem*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFsiItem.get_LastModifiedTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT get_LastModifiedTime([NativeTypeName("DATE *")] double* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, double*, int> )(lpVtbl[13]))((IFsiFileItem*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiItem.put_LastModifiedTime"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT put_LastModifiedTime([NativeTypeName("DATE")] double newVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, double, int> )(lpVtbl[14]))((IFsiFileItem*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFsiItem.get_IsHidden"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT get_IsHidden([NativeTypeName("VARIANT_BOOL *")] short* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, short*, int> )(lpVtbl[15]))((IFsiFileItem*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <inheritdoc cref = "IFsiItem.put_IsHidden"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT put_IsHidden([NativeTypeName("VARIANT_BOOL")] short newVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, short, int> )(lpVtbl[16]))((IFsiFileItem*)Unsafe.AsPointer(ref this), newVal);
    }

    /// <inheritdoc cref = "IFsiItem.FileSystemName"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT FileSystemName(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, FsiFileSystems, ushort**, int> )(lpVtbl[17]))((IFsiFileItem*)Unsafe.AsPointer(ref this), fileSystem, pVal);
    }

    /// <inheritdoc cref = "IFsiItem.FileSystemPath"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT FileSystemPath(FsiFileSystems fileSystem, [NativeTypeName("BSTR *")] ushort** pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, FsiFileSystems, ushort**, int> )(lpVtbl[18]))((IFsiFileItem*)Unsafe.AsPointer(ref this), fileSystem, pVal);
    }

    /// <include file='IFsiFileItem.xml' path='doc/member[@name="IFsiFileItem.get_DataSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT get_DataSize([NativeTypeName("LONGLONG *")] long* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, long*, int> )(lpVtbl[19]))((IFsiFileItem*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IFsiFileItem.xml' path='doc/member[@name="IFsiFileItem.get_DataSize32BitLow"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_DataSize32BitLow([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, int*, int> )(lpVtbl[20]))((IFsiFileItem*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IFsiFileItem.xml' path='doc/member[@name="IFsiFileItem.get_DataSize32BitHigh"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_DataSize32BitHigh([NativeTypeName("LONG *")] int* pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, int*, int> )(lpVtbl[21]))((IFsiFileItem*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IFsiFileItem.xml' path='doc/member[@name="IFsiFileItem.get_Data"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT get_Data(IStream** pVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, IStream**, int> )(lpVtbl[22]))((IFsiFileItem*)Unsafe.AsPointer(ref this), pVal);
    }

    /// <include file='IFsiFileItem.xml' path='doc/member[@name="IFsiFileItem.put_Data"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT put_Data(IStream* newVal)
    {
        return ((delegate* unmanaged<IFsiFileItem*, IStream*, int> )(lpVtbl[23]))((IFsiFileItem*)Unsafe.AsPointer(ref this), newVal);
    }

    public interface Interface : IFsiItem.Interface
    {
        [VtblIndex(19)]
        HRESULT get_DataSize([NativeTypeName("LONGLONG *")] long* pVal);
        [VtblIndex(20)]
        HRESULT get_DataSize32BitLow([NativeTypeName("LONG *")] int* pVal);
        [VtblIndex(21)]
        HRESULT get_DataSize32BitHigh([NativeTypeName("LONG *")] int* pVal);
        [VtblIndex(22)]
        HRESULT get_Data(IStream** pVal);
        [VtblIndex(23)]
        HRESULT put_Data(IStream* newVal);
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
        [NativeTypeName("HRESULT (LONGLONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, long*, int> get_DataSize;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DataSize32BitLow;
        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_DataSize32BitHigh;
        [NativeTypeName("HRESULT (IStream **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream**, int> get_Data;
        [NativeTypeName("HRESULT (IStream *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IStream*, int> put_Data;
    }
}