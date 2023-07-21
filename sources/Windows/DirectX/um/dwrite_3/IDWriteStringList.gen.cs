// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDWriteStringList.xml' path='doc/member[@name="IDWriteStringList"]/*' />
[Guid("CFEE3140-1157-47CA-8B85-31BFCF3F2D0E")]
[NativeTypeName("struct IDWriteStringList : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDWriteStringList : IDWriteStringList.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDWriteStringList));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDWriteStringList*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteStringList*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDWriteStringList*, uint>)(lpVtbl[1]))((IDWriteStringList*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDWriteStringList*, uint>)(lpVtbl[2]))((IDWriteStringList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteStringList.xml' path='doc/member[@name="IDWriteStringList.GetCount"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    [return: NativeTypeName("UINT32")]
    public uint GetCount()
    {
        return ((delegate* unmanaged<IDWriteStringList*, uint>)(lpVtbl[3]))((IDWriteStringList*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDWriteStringList.xml' path='doc/member[@name="IDWriteStringList.GetLocaleNameLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLocaleNameLength([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32 *")] uint* length)
    {
        return ((delegate* unmanaged<IDWriteStringList*, uint, uint*, int>)(lpVtbl[4]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, length);
    }

    /// <include file='IDWriteStringList.xml' path='doc/member[@name="IDWriteStringList.GetLocaleName"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetLocaleName([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint size)
    {
        return ((delegate* unmanaged<IDWriteStringList*, uint, ushort*, uint, int>)(lpVtbl[5]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, localeName, size);
    }

    /// <include file='IDWriteStringList.xml' path='doc/member[@name="IDWriteStringList.GetStringLength"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetStringLength([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32 *")] uint* length)
    {
        return ((delegate* unmanaged<IDWriteStringList*, uint, uint*, int>)(lpVtbl[6]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, length);
    }

    /// <include file='IDWriteStringList.xml' path='doc/member[@name="IDWriteStringList.GetString"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetString([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint stringBufferSize)
    {
        return ((delegate* unmanaged<IDWriteStringList*, uint, ushort*, uint, int>)(lpVtbl[7]))((IDWriteStringList*)Unsafe.AsPointer(ref this), listIndex, stringBuffer, stringBufferSize);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        [return: NativeTypeName("UINT32")]
        uint GetCount();

        [VtblIndex(4)]
        HRESULT GetLocaleNameLength([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32 *")] uint* length);

        [VtblIndex(5)]
        HRESULT GetLocaleName([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* localeName, [NativeTypeName("UINT32")] uint size);

        [VtblIndex(6)]
        HRESULT GetStringLength([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("UINT32 *")] uint* length);

        [VtblIndex(7)]
        HRESULT GetString([NativeTypeName("UINT32")] uint listIndex, [NativeTypeName("WCHAR *")] ushort* stringBuffer, [NativeTypeName("UINT32")] uint stringBufferSize);
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

        [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetLocaleNameLength;

        [NativeTypeName("HRESULT (UINT32, WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, int> GetLocaleName;

        [NativeTypeName("HRESULT (UINT32, UINT32 *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> GetStringLength;

        [NativeTypeName("HRESULT (UINT32, WCHAR *, UINT32) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort*, uint, int> GetString;
    }
}
