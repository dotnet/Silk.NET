// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W"]/*' />
[Guid("54D41081-DC15-4833-A41B-748F73A38179")]
[NativeTypeName("struct IDirectInputDevice8W : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectInputDevice8W : IDirectInputDevice8W.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectInputDevice8W));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, Guid*, void**, int>)(lpVtbl[0]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, uint>)(lpVtbl[1]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, uint>)(lpVtbl[2]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.GetCapabilities"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCapabilities([NativeTypeName("LPDIDEVCAPS")] DIDEVCAPS* param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, DIDEVCAPS*, int>)(lpVtbl[3]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.EnumObjects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumObjects([NativeTypeName("LPDIENUMDEVICEOBJECTSCALLBACKW")] delegate* unmanaged<DIDEVICEOBJECTINSTANCE*, void*, BOOL> param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, delegate* unmanaged<DIDEVICEOBJECTINSTANCE*, void*, BOOL>, void*, uint, int>)(lpVtbl[4]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.GetProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetProperty([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPDIPROPHEADER")] DIPROPHEADER* param1)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, Guid*, DIPROPHEADER*, int>)(lpVtbl[5]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.SetProperty"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetProperty([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCDIPROPHEADER")] DIPROPHEADER* param1)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, Guid*, DIPROPHEADER*, int>)(lpVtbl[6]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.Acquire"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Acquire()
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, int>)(lpVtbl[7]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.Unacquire"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Unacquire()
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, int>)(lpVtbl[8]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.GetDeviceState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceState([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, uint, void*, int>)(lpVtbl[9]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.GetDeviceData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeviceData([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIDEVICEOBJECTDATA")] DIDEVICEOBJECTDATA* param1, [NativeTypeName("LPDWORD")] uint* param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, uint, DIDEVICEOBJECTDATA*, uint*, uint, int>)(lpVtbl[10]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.SetDataFormat"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetDataFormat([NativeTypeName("LPCDIDATAFORMAT")] DIDATAFORMAT* param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, DIDATAFORMAT*, int>)(lpVtbl[11]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.SetEventNotification"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetEventNotification(HANDLE param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, HANDLE, int>)(lpVtbl[12]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.SetCooperativeLevel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetCooperativeLevel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, HWND, uint, int>)(lpVtbl[13]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.GetObjectInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetObjectInfo([NativeTypeName("LPDIDEVICEOBJECTINSTANCEW")] DIDEVICEOBJECTINSTANCE* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, DIDEVICEOBJECTINSTANCE*, uint, uint, int>)(lpVtbl[14]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.GetDeviceInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDeviceInfo([NativeTypeName("LPDIDEVICEINSTANCEW")] DIDEVICEINSTANCE* param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, DIDEVICEINSTANCE*, int>)(lpVtbl[15]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.RunControlPanel"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, HWND, uint, int>)(lpVtbl[16]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("const GUID &")] Guid* param2)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, HINSTANCE, uint, Guid*, int>)(lpVtbl[17]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.CreateEffect"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateEffect([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCDIEFFECT")] DIEFFECT_DX6* param1, [NativeTypeName("LPDIRECTINPUTEFFECT *")] IDirectInputEffect** param2, [NativeTypeName("LPUNKNOWN")] IUnknown* param3)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, Guid*, DIEFFECT_DX6*, IDirectInputEffect**, IUnknown*, int>)(lpVtbl[18]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.EnumEffects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT EnumEffects([NativeTypeName("LPDIENUMEFFECTSCALLBACKW")] delegate* unmanaged<DIEFFECTINFO*, void*, BOOL> param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, delegate* unmanaged<DIEFFECTINFO*, void*, BOOL>, void*, uint, int>)(lpVtbl[19]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.GetEffectInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetEffectInfo([NativeTypeName("LPDIEFFECTINFOW")] DIEFFECTINFO* param0, [NativeTypeName("const GUID &")] Guid* param1)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, DIEFFECTINFO*, Guid*, int>)(lpVtbl[20]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.GetForceFeedbackState"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetForceFeedbackState([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, uint*, int>)(lpVtbl[21]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.SendForceFeedbackCommand"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SendForceFeedbackCommand([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, uint, int>)(lpVtbl[22]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.EnumCreatedEffectObjects"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT EnumCreatedEffectObjects([NativeTypeName("LPDIENUMCREATEDEFFECTOBJECTSCALLBACK")] delegate* unmanaged<IDirectInputEffect*, void*, BOOL> param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, delegate* unmanaged<IDirectInputEffect*, void*, BOOL>, void*, uint, int>)(lpVtbl[23]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.Escape"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT Escape([NativeTypeName("LPDIEFFESCAPE")] DIEFFESCAPE* param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, DIEFFESCAPE*, int>)(lpVtbl[24]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.Poll"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT Poll()
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, int>)(lpVtbl[25]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.SendDeviceData"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SendDeviceData([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPCDIDEVICEOBJECTDATA")] DIDEVICEOBJECTDATA* param1, [NativeTypeName("LPDWORD")] uint* param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, uint, DIDEVICEOBJECTDATA*, uint*, uint, int>)(lpVtbl[26]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.EnumEffectsInFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT EnumEffectsInFile([NativeTypeName("LPCWSTR")] ushort* param0, [NativeTypeName("LPDIENUMEFFECTSINFILECALLBACK")] delegate* unmanaged<DIFILEEFFECT*, void*, BOOL> param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, ushort*, delegate* unmanaged<DIFILEEFFECT*, void*, BOOL>, void*, uint, int>)(lpVtbl[27]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.WriteEffectToFile"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT WriteEffectToFile([NativeTypeName("LPCWSTR")] ushort* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIFILEEFFECT")] DIFILEEFFECT* param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, ushort*, uint, DIFILEEFFECT*, uint, int>)(lpVtbl[28]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.BuildActionMap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT BuildActionMap([NativeTypeName("LPDIACTIONFORMATW")] DIACTIONFORMATW* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, DIACTIONFORMATW*, ushort*, uint, int>)(lpVtbl[29]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.SetActionMap"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT SetActionMap([NativeTypeName("LPDIACTIONFORMATW")] DIACTIONFORMATW* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, DIACTIONFORMATW*, ushort*, uint, int>)(lpVtbl[30]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputDevice8W.xml' path='doc/member[@name="IDirectInputDevice8W.GetImageInfo"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT GetImageInfo([NativeTypeName("LPDIDEVICEIMAGEINFOHEADERW")] DIDEVICEIMAGEINFOHEADERW* param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice8W*, DIDEVICEIMAGEINFOHEADERW*, int>)(lpVtbl[31]))((IDirectInputDevice8W*)Unsafe.AsPointer(ref this), param0);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetCapabilities([NativeTypeName("LPDIDEVCAPS")] DIDEVCAPS* param0);

        [VtblIndex(5)]
        HRESULT GetProperty([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPDIPROPHEADER")] DIPROPHEADER* param1);

        [VtblIndex(6)]
        HRESULT SetProperty([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCDIPROPHEADER")] DIPROPHEADER* param1);

        [VtblIndex(7)]
        HRESULT Acquire();

        [VtblIndex(8)]
        HRESULT Unacquire();

        [VtblIndex(9)]
        HRESULT GetDeviceState([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1);

        [VtblIndex(10)]
        HRESULT GetDeviceData([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIDEVICEOBJECTDATA")] DIDEVICEOBJECTDATA* param1, [NativeTypeName("LPDWORD")] uint* param2, [NativeTypeName("DWORD")] uint param3);

        [VtblIndex(11)]
        HRESULT SetDataFormat([NativeTypeName("LPCDIDATAFORMAT")] DIDATAFORMAT* param0);

        [VtblIndex(12)]
        HRESULT SetEventNotification(HANDLE param0);

        [VtblIndex(13)]
        HRESULT SetCooperativeLevel(HWND param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(14)]
        HRESULT GetObjectInfo([NativeTypeName("LPDIDEVICEOBJECTINSTANCEW")] DIDEVICEOBJECTINSTANCE* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2);

        [VtblIndex(15)]
        HRESULT GetDeviceInfo([NativeTypeName("LPDIDEVICEINSTANCEW")] DIDEVICEINSTANCE* param0);

        [VtblIndex(16)]
        HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(17)]
        HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("const GUID &")] Guid* param2);

        [VtblIndex(18)]
        HRESULT CreateEffect([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCDIEFFECT")] DIEFFECT_DX6* param1, [NativeTypeName("LPDIRECTINPUTEFFECT *")] IDirectInputEffect** param2, [NativeTypeName("LPUNKNOWN")] IUnknown* param3);

        [VtblIndex(20)]
        HRESULT GetEffectInfo([NativeTypeName("LPDIEFFECTINFOW")] DIEFFECTINFO* param0, [NativeTypeName("const GUID &")] Guid* param1);

        [VtblIndex(21)]
        HRESULT GetForceFeedbackState([NativeTypeName("LPDWORD")] uint* param0);

        [VtblIndex(22)]
        HRESULT SendForceFeedbackCommand([NativeTypeName("DWORD")] uint param0);

        [VtblIndex(24)]
        HRESULT Escape([NativeTypeName("LPDIEFFESCAPE")] DIEFFESCAPE* param0);

        [VtblIndex(25)]
        HRESULT Poll();

        [VtblIndex(26)]
        HRESULT SendDeviceData([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPCDIDEVICEOBJECTDATA")] DIDEVICEOBJECTDATA* param1, [NativeTypeName("LPDWORD")] uint* param2, [NativeTypeName("DWORD")] uint param3);

        [VtblIndex(28)]
        HRESULT WriteEffectToFile([NativeTypeName("LPCWSTR")] ushort* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("LPDIFILEEFFECT")] DIFILEEFFECT* param2, [NativeTypeName("DWORD")] uint param3);

        [VtblIndex(29)]
        HRESULT BuildActionMap([NativeTypeName("LPDIACTIONFORMATW")] DIACTIONFORMATW* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("DWORD")] uint param2);

        [VtblIndex(30)]
        HRESULT SetActionMap([NativeTypeName("LPDIACTIONFORMATW")] DIACTIONFORMATW* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("DWORD")] uint param2);

        [VtblIndex(31)]
        HRESULT GetImageInfo([NativeTypeName("LPDIDEVICEIMAGEINFOHEADERW")] DIDEVICEIMAGEINFOHEADERW* param0);
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

        [NativeTypeName("HRESULT (LPDIDEVCAPS) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIDEVCAPS*, int> GetCapabilities;

        [NativeTypeName("HRESULT (LPDIENUMDEVICEOBJECTSCALLBACKW, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, delegate* unmanaged<DIDEVICEOBJECTINSTANCE*, void*, BOOL>, void*, uint, int> EnumObjects;

        [NativeTypeName("HRESULT (const GUID &, LPDIPROPHEADER) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, DIPROPHEADER*, int> GetProperty;

        [NativeTypeName("HRESULT (const GUID &, LPCDIPROPHEADER) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, DIPROPHEADER*, int> SetProperty;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Acquire;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unacquire;

        [NativeTypeName("HRESULT (DWORD, LPVOID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, int> GetDeviceState;

        [NativeTypeName("HRESULT (DWORD, LPDIDEVICEOBJECTDATA, LPDWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DIDEVICEOBJECTDATA*, uint*, uint, int> GetDeviceData;

        [NativeTypeName("HRESULT (LPCDIDATAFORMAT) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIDATAFORMAT*, int> SetDataFormat;

        [NativeTypeName("HRESULT (HANDLE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HANDLE, int> SetEventNotification;

        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> SetCooperativeLevel;

        [NativeTypeName("HRESULT (LPDIDEVICEOBJECTINSTANCEW, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIDEVICEOBJECTINSTANCE*, uint, uint, int> GetObjectInfo;

        [NativeTypeName("HRESULT (LPDIDEVICEINSTANCEW) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIDEVICEINSTANCE*, int> GetDeviceInfo;

        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> RunControlPanel;

        [NativeTypeName("HRESULT (HINSTANCE, DWORD, const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HINSTANCE, uint, Guid*, int> Initialize;

        [NativeTypeName("HRESULT (const GUID &, LPCDIEFFECT, LPDIRECTINPUTEFFECT *, LPUNKNOWN) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, DIEFFECT_DX6*, IDirectInputEffect**, IUnknown*, int> CreateEffect;

        [NativeTypeName("HRESULT (LPDIENUMEFFECTSCALLBACKW, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, delegate* unmanaged<DIEFFECTINFO*, void*, BOOL>, void*, uint, int> EnumEffects;

        [NativeTypeName("HRESULT (LPDIEFFECTINFOW, const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIEFFECTINFO*, Guid*, int> GetEffectInfo;

        [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetForceFeedbackState;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SendForceFeedbackCommand;

        [NativeTypeName("HRESULT (LPDIENUMCREATEDEFFECTOBJECTSCALLBACK, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, delegate* unmanaged<IDirectInputEffect*, void*, BOOL>, void*, uint, int> EnumCreatedEffectObjects;

        [NativeTypeName("HRESULT (LPDIEFFESCAPE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIEFFESCAPE*, int> Escape;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Poll;

        [NativeTypeName("HRESULT (DWORD, LPCDIDEVICEOBJECTDATA, LPDWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DIDEVICEOBJECTDATA*, uint*, uint, int> SendDeviceData;

        [NativeTypeName("HRESULT (LPCWSTR, LPDIENUMEFFECTSINFILECALLBACK, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, delegate* unmanaged<DIFILEEFFECT*, void*, BOOL>, void*, uint, int> EnumEffectsInFile;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD, LPDIFILEEFFECT, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, DIFILEEFFECT*, uint, int> WriteEffectToFile;

        [NativeTypeName("HRESULT (LPDIACTIONFORMATW, LPCWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIACTIONFORMATW*, ushort*, uint, int> BuildActionMap;

        [NativeTypeName("HRESULT (LPDIACTIONFORMATW, LPCWSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIACTIONFORMATW*, ushort*, uint, int> SetActionMap;

        [NativeTypeName("HRESULT (LPDIDEVICEIMAGEINFOHEADERW) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIDEVICEIMAGEINFOHEADERW*, int> GetImageInfo;
    }
}
