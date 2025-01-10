// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincodec.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A721791A-0DEF-4D06-BD91-2118BF1DB10B")]
[NativeTypeName("struct IWICMetadataQueryWriter : IWICMetadataQueryReader")]
[NativeInheritance("IWICMetadataQueryReader")]
public unsafe partial struct IWICMetadataQueryWriter
    : IWICMetadataQueryWriter.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWICMetadataQueryWriter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWICMetadataQueryWriter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWICMetadataQueryWriter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWICMetadataQueryWriter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetContainerFormat(Guid* pguidContainerFormat)
    {
        return ((delegate* unmanaged<IWICMetadataQueryWriter, Guid*, int>)((*lpVtbl)[3]))(
            this,
            pguidContainerFormat
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLocation(
        uint cchMaxLength,
        [NativeTypeName("WCHAR *")] ushort* wzNamespace,
        uint* pcchActualLength
    )
    {
        return (
            (delegate* unmanaged<IWICMetadataQueryWriter, uint, ushort*, uint*, int>)((*lpVtbl)[4])
        )(this, cchMaxLength, wzNamespace, pcchActualLength);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetMetadataByName(
        [NativeTypeName("LPCWSTR")] ushort* wzName,
        PROPVARIANT* pvarValue
    )
    {
        return (
            (delegate* unmanaged<IWICMetadataQueryWriter, ushort*, PROPVARIANT*, int>)((*lpVtbl)[5])
        )(this, wzName, pvarValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetEnumerator(IEnumString* ppIEnumString)
    {
        return ((delegate* unmanaged<IWICMetadataQueryWriter, IEnumString*, int>)((*lpVtbl)[6]))(
            this,
            ppIEnumString
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetMetadataByName(
        [NativeTypeName("LPCWSTR")] ushort* wzName,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue
    )
    {
        return (
            (delegate* unmanaged<IWICMetadataQueryWriter, ushort*, PROPVARIANT*, int>)((*lpVtbl)[7])
        )(this, wzName, pvarValue);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RemoveMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName)
    {
        return ((delegate* unmanaged<IWICMetadataQueryWriter, ushort*, int>)((*lpVtbl)[8]))(
            this,
            wzName
        );
    }

    public interface Interface : IWICMetadataQueryReader.Interface
    {
        [VtblIndex(7)]
        HRESULT SetMetadataByName(
            [NativeTypeName("LPCWSTR")] ushort* wzName,
            [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* pvarValue
        );

        [VtblIndex(8)]
        HRESULT RemoveMetadataByName([NativeTypeName("LPCWSTR")] ushort* wzName);
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

        [NativeTypeName("HRESULT (UINT, WCHAR *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint*, int> GetLocation;

        [NativeTypeName("HRESULT (LPCWSTR, PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, PROPVARIANT*, int> GetMetadataByName;

        [NativeTypeName("HRESULT (IEnumString **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumString*, int> GetEnumerator;

        [NativeTypeName("HRESULT (LPCWSTR, const PROPVARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, PROPVARIANT*, int> SetMetadataByName;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> RemoveMetadataByName;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWICMetadataQueryWriter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWICMetadataQueryWriter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWICMetadataQueryReader"/> to <see cref = "IWICMetadataQueryWriter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWICMetadataQueryReader"/> instance to be converted </param>
    public static explicit operator IWICMetadataQueryWriter(
        Silk.NET.Windows.IWICMetadataQueryReader value
    )
    {
        return new IWICMetadataQueryWriter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICMetadataQueryWriter"/> to <see cref = "Silk.NET.Windows.IWICMetadataQueryReader"/>.</summary>
    /// <param name = "value">The <see cref = "IWICMetadataQueryWriter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWICMetadataQueryReader(
        IWICMetadataQueryWriter value
    )
    {
        return new Silk.NET.Windows.IWICMetadataQueryReader(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWICMetadataQueryWriter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWICMetadataQueryWriter(Silk.NET.Windows.IUnknown value)
    {
        return new IWICMetadataQueryWriter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWICMetadataQueryWriter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWICMetadataQueryWriter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWICMetadataQueryWriter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
