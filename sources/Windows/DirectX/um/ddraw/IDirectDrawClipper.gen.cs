// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDirectDrawClipper.xml' path='doc/member[@name="IDirectDrawClipper"]/*'/>
[Guid("6C14DB85-A733-11CE-A521-0020AF0BE560")]
[NativeTypeName("struct IDirectDrawClipper : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectDrawClipper : IDirectDrawClipper.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectDrawClipper));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectDrawClipper*, Guid*, void**, int> )(lpVtbl[0]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectDrawClipper*, uint> )(lpVtbl[1]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectDrawClipper*, uint> )(lpVtbl[2]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectDrawClipper.xml' path='doc/member[@name="IDirectDrawClipper.GetClipList"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetClipList([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPRGNDATA")] RGNDATA* param1, [NativeTypeName("LPDWORD")] uint* param2)
    {
        return ((delegate* unmanaged<IDirectDrawClipper*, RECT*, RGNDATA*, uint*, int> )(lpVtbl[3]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectDrawClipper.xml' path='doc/member[@name="IDirectDrawClipper.GetHWnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetHWnd(HWND* param0)
    {
        return ((delegate* unmanaged<IDirectDrawClipper*, HWND*, int> )(lpVtbl[4]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawClipper.xml' path='doc/member[@name="IDirectDrawClipper.Initialize"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectDrawClipper*, IDirectDraw*, uint, int> )(lpVtbl[5]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawClipper.xml' path='doc/member[@name="IDirectDrawClipper.IsClipListChanged"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT IsClipListChanged(BOOL* param0)
    {
        return ((delegate* unmanaged<IDirectDrawClipper*, BOOL*, int> )(lpVtbl[6]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectDrawClipper.xml' path='doc/member[@name="IDirectDrawClipper.SetClipList"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetClipList([NativeTypeName("LPRGNDATA")] RGNDATA* param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectDrawClipper*, RGNDATA*, uint, int> )(lpVtbl[7]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectDrawClipper.xml' path='doc/member[@name="IDirectDrawClipper.SetHWnd"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT SetHWnd([NativeTypeName("DWORD")] uint param0, HWND param1)
    {
        return ((delegate* unmanaged<IDirectDrawClipper*, uint, HWND, int> )(lpVtbl[8]))((IDirectDrawClipper*)Unsafe.AsPointer(ref this), param0, param1);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetClipList([NativeTypeName("LPRECT")] RECT* param0, [NativeTypeName("LPRGNDATA")] RGNDATA* param1, [NativeTypeName("LPDWORD")] uint* param2);
        [VtblIndex(4)]
        HRESULT GetHWnd(HWND* param0);
        [VtblIndex(5)]
        HRESULT Initialize([NativeTypeName("LPDIRECTDRAW")] IDirectDraw* param0, [NativeTypeName("DWORD")] uint param1);
        [VtblIndex(6)]
        HRESULT IsClipListChanged(BOOL* param0);
        [VtblIndex(7)]
        HRESULT SetClipList([NativeTypeName("LPRGNDATA")] RGNDATA* param0, [NativeTypeName("DWORD")] uint param1);
        [VtblIndex(8)]
        HRESULT SetHWnd([NativeTypeName("DWORD")] uint param0, HWND param1);
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
        [NativeTypeName("HRESULT (LPRECT, LPRGNDATA, LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RECT*, RGNDATA*, uint*, int> GetClipList;
        [NativeTypeName("HRESULT (HWND *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND*, int> GetHWnd;
        [NativeTypeName("HRESULT (LPDIRECTDRAW, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDirectDraw*, uint, int> Initialize;
        [NativeTypeName("HRESULT (BOOL *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL*, int> IsClipListChanged;
        [NativeTypeName("HRESULT (LPRGNDATA, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, RGNDATA*, uint, int> SetClipList;
        [NativeTypeName("HRESULT (DWORD, HWND) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, HWND, int> SetHWnd;
    }
}