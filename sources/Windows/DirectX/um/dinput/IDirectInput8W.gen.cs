// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDirectInput8W.xml' path='doc/member[@name="IDirectInput8W"]/*' />
[Guid("BF798031-483A-4DA2-AA99-5D64ED369700")]
[NativeTypeName("struct IDirectInput8W : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectInput8W : IDirectInput8W.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectInput8W));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectInput8W*, Guid*, void**, int>)(lpVtbl[0]))((IDirectInput8W*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectInput8W*, uint>)(lpVtbl[1]))((IDirectInput8W*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectInput8W*, uint>)(lpVtbl[2]))((IDirectInput8W*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInput8W.xml' path='doc/member[@name="IDirectInput8W.CreateDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDevice([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPDIRECTINPUTDEVICE8W *")] IDirectInputDevice8W** param1, [NativeTypeName("LPUNKNOWN")] IUnknown* param2)
    {
        return ((delegate* unmanaged<IDirectInput8W*, Guid*, IDirectInputDevice8W**, IUnknown*, int>)(lpVtbl[3]))((IDirectInput8W*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInput8W.xml' path='doc/member[@name="IDirectInput8W.EnumDevices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumDevices([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIENUMDEVICESCALLBACKW")] delegate* unmanaged<DIDEVICEINSTANCE*, void*, BOOL> param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged<IDirectInput8W*, uint, delegate* unmanaged<DIDEVICEINSTANCE*, void*, BOOL>, void*, uint, int>)(lpVtbl[4]))((IDirectInput8W*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectInput8W.xml' path='doc/member[@name="IDirectInput8W.GetDeviceStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDeviceStatus([NativeTypeName("const GUID &")] Guid* param0)
    {
        return ((delegate* unmanaged<IDirectInput8W*, Guid*, int>)(lpVtbl[5]))((IDirectInput8W*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInput8W.xml' path='doc/member[@name="IDirectInput8W.RunControlPanel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInput8W*, HWND, uint, int>)(lpVtbl[6]))((IDirectInput8W*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInput8W.xml' path='doc/member[@name="IDirectInput8W.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInput8W*, HINSTANCE, uint, int>)(lpVtbl[7]))((IDirectInput8W*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInput8W.xml' path='doc/member[@name="IDirectInput8W.FindDevice"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindDevice([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPGUID")] Guid* param2)
    {
        return ((delegate* unmanaged<IDirectInput8W*, Guid*, ushort*, Guid*, int>)(lpVtbl[8]))((IDirectInput8W*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInput8W.xml' path='doc/member[@name="IDirectInput8W.EnumDevicesBySemantics"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT EnumDevicesBySemantics([NativeTypeName("LPCWSTR")] ushort* param0, [NativeTypeName("LPDIACTIONFORMATW")] DIACTIONFORMATW* param1, [NativeTypeName("LPDIENUMDEVICESBYSEMANTICSCBW")] delegate* unmanaged<DIDEVICEINSTANCE*, IDirectInputDevice8W*, uint, uint, void*, BOOL> param2, [NativeTypeName("LPVOID")] void* param3, [NativeTypeName("DWORD")] uint param4)
    {
        return ((delegate* unmanaged<IDirectInput8W*, ushort*, DIACTIONFORMATW*, delegate* unmanaged<DIDEVICEINSTANCE*, IDirectInputDevice8W*, uint, uint, void*, BOOL>, void*, uint, int>)(lpVtbl[9]))((IDirectInput8W*)Unsafe.AsPointer(ref this), param0, param1, param2, param3, param4);
    }

    /// <include file='IDirectInput8W.xml' path='doc/member[@name="IDirectInput8W.ConfigureDevices"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT ConfigureDevices([NativeTypeName("LPDICONFIGUREDEVICESCALLBACK")] delegate* unmanaged<IUnknown*, void*, BOOL> param0, [NativeTypeName("LPDICONFIGUREDEVICESPARAMSW")] DICONFIGUREDEVICESPARAMSW* param1, [NativeTypeName("DWORD")] uint param2, [NativeTypeName("LPVOID")] void* param3)
    {
        return ((delegate* unmanaged<IDirectInput8W*, delegate* unmanaged<IUnknown*, void*, BOOL>, DICONFIGUREDEVICESPARAMSW*, uint, void*, int>)(lpVtbl[10]))((IDirectInput8W*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateDevice([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPDIRECTINPUTDEVICE8W *")] IDirectInputDevice8W** param1, [NativeTypeName("LPUNKNOWN")] IUnknown* param2);

        [VtblIndex(5)]
        HRESULT GetDeviceStatus([NativeTypeName("const GUID &")] Guid* param0);

        [VtblIndex(6)]
        HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(7)]
        HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(8)]
        HRESULT FindDevice([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPGUID")] Guid* param2);
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

        [NativeTypeName("HRESULT (const GUID &, LPDIRECTINPUTDEVICE8W *, LPUNKNOWN) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IDirectInputDevice8W**, IUnknown*, int> CreateDevice;

        [NativeTypeName("HRESULT (DWORD, LPDIENUMDEVICESCALLBACKW, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, delegate* unmanaged<DIDEVICEINSTANCE*, void*, BOOL>, void*, uint, int> EnumDevices;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetDeviceStatus;

        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> RunControlPanel;

        [NativeTypeName("HRESULT (HINSTANCE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HINSTANCE, uint, int> Initialize;

        [NativeTypeName("HRESULT (const GUID &, LPCWSTR, LPGUID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, Guid*, int> FindDevice;

        [NativeTypeName("HRESULT (LPCWSTR, LPDIACTIONFORMATW, LPDIENUMDEVICESBYSEMANTICSCBW, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, DIACTIONFORMATW*, delegate* unmanaged<DIDEVICEINSTANCE*, IDirectInputDevice8W*, uint, uint, void*, BOOL>, void*, uint, int> EnumDevicesBySemantics;

        [NativeTypeName("HRESULT (LPDICONFIGUREDEVICESCALLBACK, LPDICONFIGUREDEVICESPARAMSW, DWORD, LPVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, delegate* unmanaged<IUnknown*, void*, BOOL>, DICONFIGUREDEVICESPARAMSW*, uint, void*, int> ConfigureDevices;
    }
}
