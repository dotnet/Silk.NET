// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000002F-0000-0000-C000-000000000046")]
[NativeTypeName("struct IRecordInfo : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IRecordInfo : IRecordInfo.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IRecordInfo));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IRecordInfo, Guid*, void**, int>)((*lpVtbl)[0]))(
            this,
            riid,
            ppvObject
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IRecordInfo, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IRecordInfo, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RecordInit([NativeTypeName("PVOID")] void* pvNew)
    {
        return ((delegate* unmanaged<IRecordInfo, void*, int>)((*lpVtbl)[3]))(this, pvNew);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RecordClear([NativeTypeName("PVOID")] void* pvExisting)
    {
        return ((delegate* unmanaged<IRecordInfo, void*, int>)((*lpVtbl)[4]))(this, pvExisting);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RecordCopy(
        [NativeTypeName("PVOID")] void* pvExisting,
        [NativeTypeName("PVOID")] void* pvNew
    )
    {
        return ((delegate* unmanaged<IRecordInfo, void*, void*, int>)((*lpVtbl)[5]))(
            this,
            pvExisting,
            pvNew
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetGuid(Guid* pguid)
    {
        return ((delegate* unmanaged<IRecordInfo, Guid*, int>)((*lpVtbl)[6]))(this, pguid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return ((delegate* unmanaged<IRecordInfo, ushort**, int>)((*lpVtbl)[7]))(this, pbstrName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetSize([NativeTypeName("ULONG *")] uint* pcbSize)
    {
        return ((delegate* unmanaged<IRecordInfo, uint*, int>)((*lpVtbl)[8]))(this, pcbSize);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetTypeInfo(ITypeInfo* ppTypeInfo)
    {
        return ((delegate* unmanaged<IRecordInfo, ITypeInfo*, int>)((*lpVtbl)[9]))(
            this,
            ppTypeInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetField(
        [NativeTypeName("PVOID")] void* pvData,
        [NativeTypeName("LPCOLESTR")] ushort* szFieldName,
        VARIANT* pvarField
    )
    {
        return ((delegate* unmanaged<IRecordInfo, void*, ushort*, VARIANT*, int>)((*lpVtbl)[10]))(
            this,
            pvData,
            szFieldName,
            pvarField
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetFieldNoCopy(
        [NativeTypeName("PVOID")] void* pvData,
        [NativeTypeName("LPCOLESTR")] ushort* szFieldName,
        VARIANT* pvarField,
        [NativeTypeName("PVOID *")] void** ppvDataCArray
    )
    {
        return (
            (delegate* unmanaged<IRecordInfo, void*, ushort*, VARIANT*, void**, int>)((*lpVtbl)[11])
        )(this, pvData, szFieldName, pvarField, ppvDataCArray);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT PutField(
        [NativeTypeName("ULONG")] uint wFlags,
        [NativeTypeName("PVOID")] void* pvData,
        [NativeTypeName("LPCOLESTR")] ushort* szFieldName,
        VARIANT* pvarField
    )
    {
        return (
            (delegate* unmanaged<IRecordInfo, uint, void*, ushort*, VARIANT*, int>)((*lpVtbl)[12])
        )(this, wFlags, pvData, szFieldName, pvarField);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT PutFieldNoCopy(
        [NativeTypeName("ULONG")] uint wFlags,
        [NativeTypeName("PVOID")] void* pvData,
        [NativeTypeName("LPCOLESTR")] ushort* szFieldName,
        VARIANT* pvarField
    )
    {
        return (
            (delegate* unmanaged<IRecordInfo, uint, void*, ushort*, VARIANT*, int>)((*lpVtbl)[13])
        )(this, wFlags, pvData, szFieldName, pvarField);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetFieldNames(
        [NativeTypeName("ULONG *")] uint* pcNames,
        [NativeTypeName("BSTR *")] ushort** rgBstrNames
    )
    {
        return ((delegate* unmanaged<IRecordInfo, uint*, ushort**, int>)((*lpVtbl)[14]))(
            this,
            pcNames,
            rgBstrNames
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public BOOL IsMatchingType(IRecordInfo pRecordInfo)
    {
        return ((delegate* unmanaged<IRecordInfo, IRecordInfo, int>)((*lpVtbl)[15]))(
            this,
            pRecordInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    [return: NativeTypeName("PVOID")]
    public void* RecordCreate()
    {
        return ((delegate* unmanaged<IRecordInfo, void*>)((*lpVtbl)[16]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT RecordCreateCopy(
        [NativeTypeName("PVOID")] void* pvSource,
        [NativeTypeName("PVOID *")] void** ppvDest
    )
    {
        return ((delegate* unmanaged<IRecordInfo, void*, void**, int>)((*lpVtbl)[17]))(
            this,
            pvSource,
            ppvDest
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT RecordDestroy([NativeTypeName("PVOID")] void* pvRecord)
    {
        return ((delegate* unmanaged<IRecordInfo, void*, int>)((*lpVtbl)[18]))(this, pvRecord);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RecordInit([NativeTypeName("PVOID")] void* pvNew);

        [VtblIndex(4)]
        HRESULT RecordClear([NativeTypeName("PVOID")] void* pvExisting);

        [VtblIndex(5)]
        HRESULT RecordCopy(
            [NativeTypeName("PVOID")] void* pvExisting,
            [NativeTypeName("PVOID")] void* pvNew
        );

        [VtblIndex(6)]
        HRESULT GetGuid(Guid* pguid);

        [VtblIndex(7)]
        HRESULT GetName([NativeTypeName("BSTR *")] ushort** pbstrName);

        [VtblIndex(8)]
        HRESULT GetSize([NativeTypeName("ULONG *")] uint* pcbSize);

        [VtblIndex(9)]
        HRESULT GetTypeInfo(ITypeInfo* ppTypeInfo);

        [VtblIndex(10)]
        HRESULT GetField(
            [NativeTypeName("PVOID")] void* pvData,
            [NativeTypeName("LPCOLESTR")] ushort* szFieldName,
            VARIANT* pvarField
        );

        [VtblIndex(11)]
        HRESULT GetFieldNoCopy(
            [NativeTypeName("PVOID")] void* pvData,
            [NativeTypeName("LPCOLESTR")] ushort* szFieldName,
            VARIANT* pvarField,
            [NativeTypeName("PVOID *")] void** ppvDataCArray
        );

        [VtblIndex(12)]
        HRESULT PutField(
            [NativeTypeName("ULONG")] uint wFlags,
            [NativeTypeName("PVOID")] void* pvData,
            [NativeTypeName("LPCOLESTR")] ushort* szFieldName,
            VARIANT* pvarField
        );

        [VtblIndex(13)]
        HRESULT PutFieldNoCopy(
            [NativeTypeName("ULONG")] uint wFlags,
            [NativeTypeName("PVOID")] void* pvData,
            [NativeTypeName("LPCOLESTR")] ushort* szFieldName,
            VARIANT* pvarField
        );

        [VtblIndex(14)]
        HRESULT GetFieldNames(
            [NativeTypeName("ULONG *")] uint* pcNames,
            [NativeTypeName("BSTR *")] ushort** rgBstrNames
        );

        [VtblIndex(15)]
        BOOL IsMatchingType(IRecordInfo pRecordInfo);

        [VtblIndex(16)]
        [return: NativeTypeName("PVOID")]
        void* RecordCreate();

        [VtblIndex(17)]
        HRESULT RecordCreateCopy(
            [NativeTypeName("PVOID")] void* pvSource,
            [NativeTypeName("PVOID *")] void** ppvDest
        );

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
        public delegate* unmanaged<TSelf*, ITypeInfo*, int> GetTypeInfo;

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
        public delegate* unmanaged<TSelf*, IRecordInfo, int> IsMatchingType;

        [NativeTypeName("PVOID () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*> RecordCreate;

        [NativeTypeName("HRESULT (PVOID, PVOID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, void**, int> RecordCreateCopy;

        [NativeTypeName("HRESULT (PVOID) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, void*, int> RecordDestroy;
    }

    /// <summary>Initializes a new instance of the <see cref = "IRecordInfo"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IRecordInfo(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IRecordInfo"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IRecordInfo(Silk.NET.Windows.IUnknown value)
    {
        return new IRecordInfo(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IRecordInfo"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IRecordInfo"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IRecordInfo value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
