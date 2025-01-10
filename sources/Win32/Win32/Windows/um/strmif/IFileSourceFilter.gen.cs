// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("56A868A6-0AD4-11CE-B03A-0020AF0BA770")]
[NativeTypeName("struct IFileSourceFilter : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileSourceFilter : IFileSourceFilter.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSourceFilter));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSourceFilter, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileSourceFilter, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSourceFilter, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Load(
        [NativeTypeName("LPCOLESTR")] ushort* pszFileName,
        [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt
    )
    {
        return (
            (delegate* unmanaged<IFileSourceFilter, ushort*, AM_MEDIA_TYPE*, int>)((*lpVtbl)[3])
        )(this, pszFileName, pmt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetCurFile(
        [NativeTypeName("LPOLESTR *")] ushort** ppszFileName,
        AM_MEDIA_TYPE* pmt
    )
    {
        return (
            (delegate* unmanaged<IFileSourceFilter, ushort**, AM_MEDIA_TYPE*, int>)((*lpVtbl)[4])
        )(this, ppszFileName, pmt);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Load(
            [NativeTypeName("LPCOLESTR")] ushort* pszFileName,
            [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt
        );

        [VtblIndex(4)]
        HRESULT GetCurFile(
            [NativeTypeName("LPOLESTR *")] ushort** ppszFileName,
            AM_MEDIA_TYPE* pmt
        );
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

        [NativeTypeName("HRESULT (LPCOLESTR, const AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, AM_MEDIA_TYPE*, int> Load;

        [NativeTypeName("HRESULT (LPOLESTR *, AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, AM_MEDIA_TYPE*, int> GetCurFile;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileSourceFilter"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileSourceFilter(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileSourceFilter"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileSourceFilter(Silk.NET.Windows.IUnknown value)
    {
        return new IFileSourceFilter(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSourceFilter"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSourceFilter"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileSourceFilter value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
