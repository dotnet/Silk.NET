// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dwrite.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("08256209-099A-4B34-B86D-C22B110E7771")]
[NativeTypeName("struct IDWriteLocalizedStrings : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteLocalizedStrings
    : IDWriteLocalizedStrings.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteLocalizedStrings));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteLocalizedStrings, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDWriteLocalizedStrings, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteLocalizedStrings, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetCount()
    {
        return ((delegate* unmanaged<IDWriteLocalizedStrings, uint>)((*lpVtbl)[3]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT FindLocaleName(
        [NativeTypeName("const WCHAR *")] ushort* localeName,
        [NativeTypeName("UINT32 *")] uint* index,
        BOOL* exists
    )
    {
        return (
            (delegate* unmanaged<IDWriteLocalizedStrings, ushort*, uint*, BOOL*, int>)((*lpVtbl)[4])
        )(this, localeName, index, exists);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLocaleNameLength(
        [NativeTypeName("UINT32")] uint index,
        [NativeTypeName("UINT32 *")] uint* length
    )
    {
        return ((delegate* unmanaged<IDWriteLocalizedStrings, uint, uint*, int>)((*lpVtbl)[5]))(
            this,
            index,
            length
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetLocaleName(
        [NativeTypeName("UINT32")] uint index,
        [NativeTypeName("WCHAR *")] ushort* localeName,
        [NativeTypeName("UINT32")] uint size
    )
    {
        return (
            (delegate* unmanaged<IDWriteLocalizedStrings, uint, ushort*, uint, int>)((*lpVtbl)[6])
        )(this, index, localeName, size);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetStringLength(
        [NativeTypeName("UINT32")] uint index,
        [NativeTypeName("UINT32 *")] uint* length
    )
    {
        return ((delegate* unmanaged<IDWriteLocalizedStrings, uint, uint*, int>)((*lpVtbl)[7]))(
            this,
            index,
            length
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetString(
        [NativeTypeName("UINT32")] uint index,
        [NativeTypeName("WCHAR *")] ushort* stringBuffer,
        [NativeTypeName("UINT32")] uint size
    )
    {
        return (
            (delegate* unmanaged<IDWriteLocalizedStrings, uint, ushort*, uint, int>)((*lpVtbl)[8])
        )(this, index, stringBuffer, size);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        uint GetCount();

        [VtblIndex(4)]
        HRESULT FindLocaleName(
            [NativeTypeName("const WCHAR *")] ushort* localeName,
            [NativeTypeName("UINT32 *")] uint* index,
            BOOL* exists
        );

        [VtblIndex(5)]
        HRESULT GetLocaleNameLength(
            [NativeTypeName("UINT32")] uint index,
            [NativeTypeName("UINT32 *")] uint* length
        );

        [VtblIndex(6)]
        HRESULT GetLocaleName(
            [NativeTypeName("UINT32")] uint index,
            [NativeTypeName("WCHAR *")] ushort* localeName,
            [NativeTypeName("UINT32")] uint size
        );

        [VtblIndex(7)]
        HRESULT GetStringLength(
            [NativeTypeName("UINT32")] uint index,
            [NativeTypeName("UINT32 *")] uint* length
        );

        [VtblIndex(8)]
        HRESULT GetString(
            [NativeTypeName("UINT32")] uint index,
            [NativeTypeName("WCHAR *")] ushort* stringBuffer,
            [NativeTypeName("UINT32")] uint size
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

        [NativeTypeName("UINT32 () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetCount;

        [NativeTypeName(
            "HRESULT (const WCHAR *, UINT32 *, BOOL *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint*, BOOL*, int> FindLocaleName;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetLocaleNameLength;

        [NativeTypeName(
            "HRESULT (UINT32, WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, int> GetLocaleName;

        [NativeTypeName(
            "HRESULT (UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetStringLength;

        [NativeTypeName(
            "HRESULT (UINT32, WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, int> GetString;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDWriteLocalizedStrings"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDWriteLocalizedStrings(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDWriteLocalizedStrings"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDWriteLocalizedStrings(Silk.NET.Windows.IUnknown value)
    {
        return new IDWriteLocalizedStrings(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDWriteLocalizedStrings"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDWriteLocalizedStrings"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDWriteLocalizedStrings value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
