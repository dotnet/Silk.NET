// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo"]/*'/>
[Guid("0000002F-0000-0000-C000-000000000046")]
[NativeTypeName("struct IRecordInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRecordInfo : IRecordInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRecordInfo));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRecordInfo*, Guid*, void**, int> )(lpVtbl[0]))((IRecordInfo*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRecordInfo*, uint> )(lpVtbl[1]))((IRecordInfo*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRecordInfo*, uint> )(lpVtbl[2]))((IRecordInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.RecordInit"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RecordInit([NativeTypeName("PVOID")] void* pvNew)
    {
        return ((delegate* unmanaged<IRecordInfo*, void*, int> )(lpVtbl[3]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvNew);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.RecordClear"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RecordClear([NativeTypeName("PVOID")] void* pvExisting)
    {
        return ((delegate* unmanaged<IRecordInfo*, void*, int> )(lpVtbl[4]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvExisting);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.RecordCopy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RecordCopy([NativeTypeName("PVOID")] void* pvExisting, [NativeTypeName("PVOID")] void* pvNew)
    {
        return ((delegate* unmanaged<IRecordInfo*, void*, void*, int> )(lpVtbl[5]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvExisting, pvNew);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.GetGuid"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetGuid(Guid* pguid)
    {
        return ((delegate* unmanaged<IRecordInfo*, Guid*, int> )(lpVtbl[6]))((IRecordInfo*)Unsafe.AsPointer(ref this), pguid);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.GetName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IRecordInfo*, ushort**, int> )(lpVtbl[7]))((IRecordInfo*)Unsafe.AsPointer(ref this), pbstrName);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.GetSize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSize([NativeTypeName("ULONG *")] uint* pcbSize)
    {
        return ((delegate* unmanaged<IRecordInfo*, uint*, int> )(lpVtbl[8]))((IRecordInfo*)Unsafe.AsPointer(ref this), pcbSize);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.GetTypeInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetTypeInfo(ITypeInfo** ppTypeInfo)
    {
        return ((delegate* unmanaged<IRecordInfo*, ITypeInfo**, int> )(lpVtbl[9]))((IRecordInfo*)Unsafe.AsPointer(ref this), ppTypeInfo);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.GetField"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetField([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, VARIANT* pvarField)
    {
        return ((delegate* unmanaged<IRecordInfo*, void*, ushort*, VARIANT*, int> )(lpVtbl[10]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvData, szFieldName, pvarField);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.GetFieldNoCopy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFieldNoCopy([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, VARIANT* pvarField, [NativeTypeName("PVOID *")] void** ppvDataCArray)
    {
        return ((delegate* unmanaged<IRecordInfo*, void*, ushort*, VARIANT*, void**, int> )(lpVtbl[11]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvData, szFieldName, pvarField, ppvDataCArray);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.PutField"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PutField([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, VARIANT* pvarField)
    {
        return ((delegate* unmanaged<IRecordInfo*, uint, void*, ushort*, VARIANT*, int> )(lpVtbl[12]))((IRecordInfo*)Unsafe.AsPointer(ref this), wFlags, pvData, szFieldName, pvarField);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.PutFieldNoCopy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT PutFieldNoCopy([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, VARIANT* pvarField)
    {
        return ((delegate* unmanaged<IRecordInfo*, uint, void*, ushort*, VARIANT*, int> )(lpVtbl[13]))((IRecordInfo*)Unsafe.AsPointer(ref this), wFlags, pvData, szFieldName, pvarField);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.GetFieldNames"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFieldNames([NativeTypeName("ULONG *")] uint* pcNames, [NativeTypeName("BSTR *")] ushort** rgBstrNames)
    {
        return ((delegate* unmanaged<IRecordInfo*, uint*, ushort**, int> )(lpVtbl[14]))((IRecordInfo*)Unsafe.AsPointer(ref this), pcNames, rgBstrNames);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.IsMatchingType"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public BOOL IsMatchingType(IRecordInfo* pRecordInfo)
    {
        return ((delegate* unmanaged<IRecordInfo*, IRecordInfo*, int> )(lpVtbl[15]))((IRecordInfo*)Unsafe.AsPointer(ref this), pRecordInfo);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.RecordCreate"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [return: NativeTypeName("PVOID")]
    public void* RecordCreate()
    {
        return ((delegate* unmanaged<IRecordInfo*, void*> )(lpVtbl[16]))((IRecordInfo*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.RecordCreateCopy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RecordCreateCopy([NativeTypeName("PVOID")] void* pvSource, [NativeTypeName("PVOID *")] void** ppvDest)
    {
        return ((delegate* unmanaged<IRecordInfo*, void*, void**, int> )(lpVtbl[17]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvSource, ppvDest);
    }

    /// <include file='IRecordInfo.xml' path='doc/member[@name="IRecordInfo.RecordDestroy"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RecordDestroy([NativeTypeName("PVOID")] void* pvRecord)
    {
        return ((delegate* unmanaged<IRecordInfo*, void*, int> )(lpVtbl[18]))((IRecordInfo*)Unsafe.AsPointer(ref this), pvRecord);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RecordInit([NativeTypeName("PVOID")] void* pvNew);
        [VtblIndex(4)]
        HRESULT RecordClear([NativeTypeName("PVOID")] void* pvExisting);
        [VtblIndex(5)]
        HRESULT RecordCopy([NativeTypeName("PVOID")] void* pvExisting, [NativeTypeName("PVOID")] void* pvNew);
        [VtblIndex(6)]
        HRESULT GetGuid(Guid* pguid);
        [VtblIndex(7)]
        HRESULT GetName([NativeTypeName("BSTR *")] ushort** pbstrName);
        [VtblIndex(8)]
        HRESULT GetSize([NativeTypeName("ULONG *")] uint* pcbSize);
        [VtblIndex(9)]
        HRESULT GetTypeInfo(ITypeInfo** ppTypeInfo);
        [VtblIndex(10)]
        HRESULT GetField([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, VARIANT* pvarField);
        [VtblIndex(11)]
        HRESULT GetFieldNoCopy([NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, VARIANT* pvarField, [NativeTypeName("PVOID *")] void** ppvDataCArray);
        [VtblIndex(12)]
        HRESULT PutField([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, VARIANT* pvarField);
        [VtblIndex(13)]
        HRESULT PutFieldNoCopy([NativeTypeName("ULONG")] uint wFlags, [NativeTypeName("PVOID")] void* pvData, [NativeTypeName("LPCOLESTR")] ushort* szFieldName, VARIANT* pvarField);
        [VtblIndex(14)]
        HRESULT GetFieldNames([NativeTypeName("ULONG *")] uint* pcNames, [NativeTypeName("BSTR *")] ushort** rgBstrNames);
        [VtblIndex(15)]
        BOOL IsMatchingType(IRecordInfo* pRecordInfo);
        [VtblIndex(16)]
        [return: NativeTypeName("PVOID")]
        void* RecordCreate();
        [VtblIndex(17)]
        HRESULT RecordCreateCopy([NativeTypeName("PVOID")] void* pvSource, [NativeTypeName("PVOID *")] void** ppvDest);
        [VtblIndex(18)]
        HRESULT RecordDestroy([NativeTypeName("PVOID")] void* pvRecord);
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
        [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int> RecordInit;
        [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int> RecordClear;
        [NativeTypeName("HRESULT (PVOID, PVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void*, int> RecordCopy;
        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetGuid;
        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetName;
        [NativeTypeName("HRESULT (ULONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetSize;
        [NativeTypeName("HRESULT (ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITypeInfo**, int> GetTypeInfo;
        [NativeTypeName("HRESULT (PVOID, LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, ushort*, VARIANT*, int> GetField;
        [NativeTypeName("HRESULT (PVOID, LPCOLESTR, VARIANT *, PVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, ushort*, VARIANT*, void**, int> GetFieldNoCopy;
        [NativeTypeName("HRESULT (ULONG, PVOID, LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, ushort*, VARIANT*, int> PutField;
        [NativeTypeName("HRESULT (ULONG, PVOID, LPCOLESTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, ushort*, VARIANT*, int> PutFieldNoCopy;
        [NativeTypeName("HRESULT (ULONG *, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, ushort**, int> GetFieldNames;
        [NativeTypeName("BOOL (IRecordInfo *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IRecordInfo*, int> IsMatchingType;
        [NativeTypeName("PVOID () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> RecordCreate;
        [NativeTypeName("HRESULT (PVOID, PVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void**, int> RecordCreateCopy;
        [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int> RecordDestroy;
    }
}