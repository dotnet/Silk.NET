// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodecsdk.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("FEAA2A8D-B3F3-43E4-B25C-D1DE990A1AE1")]
[NativeTypeName("struct IWICMetadataBlockReader : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWICMetadataBlockReader
    : IWICMetadataBlockReader.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataBlockReader));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICMetadataBlockReader, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICMetadataBlockReader, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICMetadataBlockReader, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
    {
        return ((delegate* unmanaged<IWICMetadataBlockReader, Guid*, int>)((*lpVtbl)[3]))(
            this,
            pguidContainerFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCount(uint* pcCount)
    {
        return ((delegate* unmanaged<IWICMetadataBlockReader, uint*, int>)((*lpVtbl)[4]))(
            this,
            pcCount
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetReaderByIndex(uint nIndex, IWICMetadataReader* ppIMetadataReader)
    {
        return (
            (delegate* unmanaged<IWICMetadataBlockReader, uint, IWICMetadataReader*, int>)(
                (*lpVtbl)[5]
            )
        )(this, nIndex, ppIMetadataReader);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEnumerator(IEnumUnknown* ppIEnumMetadata)
    {
        return ((delegate* unmanaged<IWICMetadataBlockReader, IEnumUnknown*, int>)((*lpVtbl)[6]))(
            this,
            ppIEnumMetadata
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetContainerFormat(Guid* pguidContainerFormat);

        [VtblIndex(4)]
        HRESULT GetCount(uint* pcCount);

        [VtblIndex(5)]
        HRESULT GetReaderByIndex(uint nIndex, IWICMetadataReader* ppIMetadataReader);

        [VtblIndex(6)]
        HRESULT GetEnumerator(IEnumUnknown* ppIEnumMetadata);
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
        public delegate* unmanaged<TSelf*, uint, IWICMetadataReader*, int> GetReaderByIndex;

        [NativeTypeName("HRESULT (IEnumUnknown **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumUnknown*, int> GetEnumerator;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICMetadataBlockReader"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICMetadataBlockReader(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICMetadataBlockReader"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICMetadataBlockReader(Silk.NET.Windows.IUnknown value)
    {
        return new IWICMetadataBlockReader(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICMetadataBlockReader"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICMetadataBlockReader"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICMetadataBlockReader value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
