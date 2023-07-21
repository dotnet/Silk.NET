// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='ID2D1ColorContext.xml' path='doc/member[@name="ID2D1ColorContext"]/*' />
[Guid("1C4820BB-5771-4518-A581-2FE4DD0EC657")]
[NativeTypeName("struct ID2D1ColorContext : ID2D1Resource")]
[NativeInheritance("ID2D1Resource")]
public unsafe partial struct ID2D1ColorContext : ID2D1ColorContext.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ID2D1ColorContext));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID2D1ColorContext*, Guid*, void**, int>)(lpVtbl[0]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID2D1ColorContext*, uint>)(lpVtbl[1]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID2D1ColorContext*, uint>)(lpVtbl[2]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID2D1Resource.GetFactory" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetFactory(ID2D1Factory** factory)
    {
        ((delegate* unmanaged<ID2D1ColorContext*, ID2D1Factory**, void>)(lpVtbl[3]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this), factory);
    }

    /// <include file='ID2D1ColorContext.xml' path='doc/member[@name="ID2D1ColorContext.GetColorSpace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public D2D1_COLOR_SPACE GetColorSpace()
    {
        return ((delegate* unmanaged<ID2D1ColorContext*, D2D1_COLOR_SPACE>)(lpVtbl[4]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1ColorContext.xml' path='doc/member[@name="ID2D1ColorContext.GetProfileSize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    [return: NativeTypeName("UINT32")]
    public uint GetProfileSize()
    {
        return ((delegate* unmanaged<ID2D1ColorContext*, uint>)(lpVtbl[5]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ID2D1ColorContext.xml' path='doc/member[@name="ID2D1ColorContext.GetProfile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetProfile(byte* profile, [NativeTypeName("UINT32")] uint profileSize)
    {
        return ((delegate* unmanaged<ID2D1ColorContext*, byte*, uint, int>)(lpVtbl[6]))((ID2D1ColorContext*)Unsafe.AsPointer(ref this), profile, profileSize);
    }

    public interface Interface : ID2D1Resource.Interface
    {
        [VtblIndex(4)]
        D2D1_COLOR_SPACE GetColorSpace();

        [VtblIndex(5)]
        [return: NativeTypeName("UINT32")]
        uint GetProfileSize();

        [VtblIndex(6)]
        HRESULT GetProfile(byte* profile, [NativeTypeName("UINT32")] uint profileSize);
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

        [NativeTypeName("void (ID2D1Factory **) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID2D1Factory**, void> GetFactory;

        [NativeTypeName("D2D1_COLOR_SPACE () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D2D1_COLOR_SPACE> GetColorSpace;

        [NativeTypeName("UINT32 () const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> GetProfileSize;

        [NativeTypeName("HRESULT (BYTE *, UINT32) const __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, byte*, uint, int> GetProfile;
    }
}
