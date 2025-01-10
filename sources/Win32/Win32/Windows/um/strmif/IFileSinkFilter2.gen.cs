// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00855B90-CE1B-11D0-BD4F-00A0C911CE86")]
[NativeTypeName("struct IFileSinkFilter2 : IFileSinkFilter")]
[NativeInheritance("IFileSinkFilter")]
public unsafe partial struct IFileSinkFilter2 : IFileSinkFilter2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSinkFilter2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSinkFilter2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileSinkFilter2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSinkFilter2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFileName(
        [NativeTypeName("LPCOLESTR")] ushort* pszFileName,
        [NativeTypeName("const AM_MEDIA_TYPE *")] AM_MEDIA_TYPE* pmt
    )
    {
        return (
            (delegate* unmanaged<IFileSinkFilter2, ushort*, AM_MEDIA_TYPE*, int>)((*lpVtbl)[3])
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
            (delegate* unmanaged<IFileSinkFilter2, ushort**, AM_MEDIA_TYPE*, int>)((*lpVtbl)[4])
        )(this, ppszFileName, pmt);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetMode([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IFileSinkFilter2, uint, int>)((*lpVtbl)[5]))(this, dwFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetMode([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IFileSinkFilter2, uint*, int>)((*lpVtbl)[6]))(this, pdwFlags);
    }

    public interface Interface : IFileSinkFilter.Interface
    {
        [VtblIndex(5)]
        HRESULT SetMode([NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(6)]
        HRESULT GetMode([NativeTypeName("DWORD *")] uint* pdwFlags);
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
        public delegate* unmanaged<TSelf*, ushort*, AM_MEDIA_TYPE*, int> SetFileName;

        [NativeTypeName("HRESULT (LPOLESTR *, AM_MEDIA_TYPE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, AM_MEDIA_TYPE*, int> GetCurFile;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetMode;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileSinkFilter2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileSinkFilter2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IFileSinkFilter"/> to <see cref = "IFileSinkFilter2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IFileSinkFilter"/> instance to be converted </param>
    public static explicit operator IFileSinkFilter2(Silk.NET.Windows.IFileSinkFilter value)
    {
        return new IFileSinkFilter2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSinkFilter2"/> to <see cref = "Silk.NET.Windows.IFileSinkFilter"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSinkFilter2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IFileSinkFilter(IFileSinkFilter2 value)
    {
        return new Silk.NET.Windows.IFileSinkFilter(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileSinkFilter2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileSinkFilter2(Silk.NET.Windows.IUnknown value)
    {
        return new IFileSinkFilter2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSinkFilter2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSinkFilter2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileSinkFilter2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
