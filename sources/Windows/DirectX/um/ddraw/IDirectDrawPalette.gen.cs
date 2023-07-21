// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDirectDrawPalette.xml' path='doc/member[@name="IDirectDrawPalette"]/*' />
[Guid("6C14DB84-A733-11CE-A521-0020AF0BE560")]
[NativeTypeName("struct IDirectDrawPalette : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectDrawPalette : IDirectDrawPalette.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectDrawPalette));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectDrawPalette*, Guid*, void**, int>)(lpVtbl[0]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectDrawPalette*, uint>)(lpVtbl[1]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectDrawPalette*, uint>)(lpVtbl[2]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawPalette.xml' path='doc/member[@name="IDirectDrawPalette.GetCaps"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCaps([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectDrawPalette*, uint*, int>)(lpVtbl[3]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawPalette.xml' path='doc/member[@name="IDirectDrawPalette.GetEntries"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEntries([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param3)
    {
        return ((delegate* unmanaged<IDirectDrawPalette*, uint, uint, uint, PALETTEENTRY*, int>)(lpVtbl[4]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectDrawPalette.xml' path='doc/member[@name="IDirectDrawPalette.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param2)
    {
        return ((delegate* unmanaged<IDirectDrawPalette*, IDirectDraw*, uint, PALETTEENTRY*, int>)(lpVtbl[5]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDrawPalette.xml' path='doc/member[@name="IDirectDrawPalette.SetEntries"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetEntries([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param3)
    {
        return ((delegate* unmanaged<IDirectDrawPalette*, uint, uint, uint, PALETTEENTRY*, int>)(lpVtbl[6]))((IDirectDrawPalette*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCaps([NativeTypeName("LPDWORD")] uint* param0);

        [VtblIndex(4)]
        HRESULT GetEntries([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param3);

        [VtblIndex(5)]
        HRESULT Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param2);

        [VtblIndex(6)]
        HRESULT SetEntries([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPPALETTEENTRY")] PALETTEENTRY* param3);
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

        [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetCaps;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, LPPALETTEENTRY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, PALETTEENTRY*, int> GetEntries;

        [NativeTypeName("HRESULT (LPDIRECTDRAW, DWORD, LPPALETTEENTRY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw*, uint, PALETTEENTRY*, int> Initialize;

        [NativeTypeName("HRESULT (DWORD, DWORD, DWORD, LPPALETTEENTRY) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, uint, PALETTEENTRY*, int> SetEntries;
    }
}
