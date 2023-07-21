// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWICMetadataReader.xml' path='doc/member[@name="IWICMetadataReader"]/*' />
[Guid("9204FE99-D8FC-4FD5-A001-9536B067A899")]
[NativeTypeName("struct IWICMetadataReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICMetadataReader : IWICMetadataReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataReader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICMetadataReader*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICMetadataReader*, uint>)(lpVtbl[1]))((IWICMetadataReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICMetadataReader*, uint>)(lpVtbl[2]))((IWICMetadataReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICMetadataReader.xml' path='doc/member[@name="IWICMetadataReader.GetMetadataFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetMetadataFormat(Guid* pguidMetadataFormat)
    {
        return ((delegate* unmanaged<IWICMetadataReader*, Guid*, int>)(lpVtbl[3]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), pguidMetadataFormat);
    }

    /// <include file='IWICMetadataReader.xml' path='doc/member[@name="IWICMetadataReader.GetMetadataHandlerInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetMetadataHandlerInfo(IWICMetadataHandlerInfo** ppIHandler)
    {
        return ((delegate* unmanaged<IWICMetadataReader*, IWICMetadataHandlerInfo**, int>)(lpVtbl[4]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), ppIHandler);
    }

    /// <include file='IWICMetadataReader.xml' path='doc/member[@name="IWICMetadataReader.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetCount(uint* pcCount)
    {
        return ((delegate* unmanaged<IWICMetadataReader*, uint*, int>)(lpVtbl[5]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), pcCount);
    }

    /// <include file='IWICMetadataReader.xml' path='doc/member[@name="IWICMetadataReader.GetValueByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetValueByIndex(uint nIndex, PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue)
    {
        return ((delegate* unmanaged<IWICMetadataReader*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[6]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), nIndex, pvarSchema, pvarId, pvarValue);
    }

    /// <include file='IWICMetadataReader.xml' path='doc/member[@name="IWICMetadataReader.GetValue"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, PROPVARIANT* pvarValue)
    {
        return ((delegate* unmanaged<IWICMetadataReader*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int>)(lpVtbl[7]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), pvarSchema, pvarId, pvarValue);
    }

    /// <include file='IWICMetadataReader.xml' path='doc/member[@name="IWICMetadataReader.GetEnumerator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetEnumerator(IWICEnumMetadataItem** ppIEnumMetadata)
    {
        return ((delegate* unmanaged<IWICMetadataReader*, IWICEnumMetadataItem**, int>)(lpVtbl[8]))((IWICMetadataReader*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetMetadataFormat(Guid* pguidMetadataFormat);

        [VtblIndex(4)]
        HRESULT GetMetadataHandlerInfo(IWICMetadataHandlerInfo** ppIHandler);

        [VtblIndex(5)]
        HRESULT GetCount(uint* pcCount);

        [VtblIndex(6)]
        HRESULT GetValueByIndex(uint nIndex, PROPVARIANT* pvarSchema, PROPVARIANT* pvarId, PROPVARIANT* pvarValue);

        [VtblIndex(7)]
        HRESULT GetValue([NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarSchema, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarId, PROPVARIANT* pvarValue);

        [VtblIndex(8)]
        HRESULT GetEnumerator(IWICEnumMetadataItem** ppIEnumMetadata);
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

        [NativeTypeName("HRESULT (GUID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetMetadataFormat;

        [NativeTypeName("HRESULT (IWICMetadataHandlerInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICMetadataHandlerInfo**, int> GetMetadataHandlerInfo;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT, PROPVARIANT *, PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> GetValueByIndex;

        [NativeTypeName("HRESULT (const PROPVARIANT *, const PROPVARIANT *, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, PROPVARIANT*, PROPVARIANT*, PROPVARIANT*, int> GetValue;

        [NativeTypeName("HRESULT (IWICEnumMetadataItem **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IWICEnumMetadataItem**, int> GetEnumerator;
    }
}
