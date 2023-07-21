// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IWICMetadataBlockReader.xml' path='doc/member[@name="IWICMetadataBlockReader"]/*' />
[Guid("FEAA2A8D-B3F3-43E4-B25C-D1DE990A1AE1")]
[NativeTypeName("struct IWICMetadataBlockReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICMetadataBlockReader : IWICMetadataBlockReader.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataBlockReader));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICMetadataBlockReader*, Guid*, void**, int>)(lpVtbl[0]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWICMetadataBlockReader*, uint>)(lpVtbl[1]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICMetadataBlockReader*, uint>)(lpVtbl[2]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWICMetadataBlockReader.xml' path='doc/member[@name="IWICMetadataBlockReader.GetContainerFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
    {
        return ((delegate* unmanaged<IWICMetadataBlockReader*, Guid*, int>)(lpVtbl[3]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), pguidContainerFormat);
    }

    /// <include file='IWICMetadataBlockReader.xml' path='doc/member[@name="IWICMetadataBlockReader.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCount(uint* pcCount)
    {
        return ((delegate* unmanaged<IWICMetadataBlockReader*, uint*, int>)(lpVtbl[4]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), pcCount);
    }

    /// <include file='IWICMetadataBlockReader.xml' path='doc/member[@name="IWICMetadataBlockReader.GetReaderByIndex"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetReaderByIndex(uint nIndex, IWICMetadataReader** ppIMetadataReader)
    {
        return ((delegate* unmanaged<IWICMetadataBlockReader*, uint, IWICMetadataReader**, int>)(lpVtbl[5]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), nIndex, ppIMetadataReader);
    }

    /// <include file='IWICMetadataBlockReader.xml' path='doc/member[@name="IWICMetadataBlockReader.GetEnumerator"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEnumerator(IEnumUnknown** ppIEnumMetadata)
    {
        return ((delegate* unmanaged<IWICMetadataBlockReader*, IEnumUnknown**, int>)(lpVtbl[6]))((IWICMetadataBlockReader*)Unsafe.AsPointer(ref this), ppIEnumMetadata);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetContainerFormat(Guid* pguidContainerFormat);

        [VtblIndex(4)]
        HRESULT GetCount(uint* pcCount);

        [VtblIndex(5)]
        HRESULT GetReaderByIndex(uint nIndex, IWICMetadataReader** ppIMetadataReader);

        [VtblIndex(6)]
        HRESULT GetEnumerator(IEnumUnknown** ppIEnumMetadata);
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
        public delegate* unmanaged<TSelf*, Guid*, int> GetContainerFormat;

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCount;

        [NativeTypeName("HRESULT (UINT, IWICMetadataReader **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, IWICMetadataReader**, int> GetReaderByIndex;

        [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumUnknown**, int> GetEnumerator;
    }
}
