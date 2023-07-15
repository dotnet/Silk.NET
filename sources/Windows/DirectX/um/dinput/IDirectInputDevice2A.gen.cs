// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDirectInputDevice2A.xml' path='doc/member[@name="IDirectInputDevice2A"]/*'/>
[Guid("5944E682-C92E-11CF-BFC7-444553540000")]
[NativeTypeName("struct IDirectInputDevice2A : IDirectInputDeviceA")]
[NativeInheritance("IDirectInputDeviceA")]
public unsafe partial struct IDirectInputDevice2A : IDirectInputDevice2A.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectInputDevice2A));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, Guid*, void**, int> )(lpVtbl[0]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, uint> )(lpVtbl[1]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, uint> )(lpVtbl[2]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.GetCapabilities"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetCapabilities([NativeTypeName("LPDIDEVCAPS")] DIDEVCAPS* param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, DIDEVCAPS*, int> )(lpVtbl[3]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0);
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.EnumObjects"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumObjects([NativeTypeName("LPDIENUMDEVICEOBJECTSCALLBACKA")] delegate* unmanaged<DIDEVICEOBJECTINSTANCEA*, void*, BOOL> param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, delegate* unmanaged<DIDEVICEOBJECTINSTANCEA*, void*, BOOL> , void*, uint, int> )(lpVtbl[4]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.GetProperty"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetProperty([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPDIPROPHEADER")] DIPROPHEADER* param1)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, Guid*, DIPROPHEADER*, int> )(lpVtbl[5]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.SetProperty"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetProperty([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCDIPROPHEADER")] DIPROPHEADER* param1)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, Guid*, DIPROPHEADER*, int> )(lpVtbl[6]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.Acquire"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Acquire()
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, int> )(lpVtbl[7]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.Unacquire"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Unacquire()
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, int> )(lpVtbl[8]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.GetDeviceState"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDeviceState([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPVOID")] void* param1)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, uint, void*, int> )(lpVtbl[9]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.GetDeviceData"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDeviceData([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIDEVICEOBJECTDATA")] DIDEVICEOBJECTDATA* param1, [NativeTypeName("LPDWORD")] uint* param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, uint, DIDEVICEOBJECTDATA*, uint*, uint, int> )(lpVtbl[10]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.SetDataFormat"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetDataFormat([NativeTypeName("LPCDIDATAFORMAT")] DIDATAFORMAT* param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, DIDATAFORMAT*, int> )(lpVtbl[11]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0);
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.SetEventNotification"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetEventNotification(HANDLE param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, HANDLE, int> )(lpVtbl[12]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0);
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.SetCooperativeLevel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetCooperativeLevel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, HWND, uint, int> )(lpVtbl[13]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.GetObjectInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetObjectInfo([NativeTypeName("LPDIDEVICEOBJECTINSTANCEA")] DIDEVICEOBJECTINSTANCEA* param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, DIDEVICEOBJECTINSTANCEA*, uint, uint, int> )(lpVtbl[14]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.GetDeviceInfo"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetDeviceInfo([NativeTypeName("LPDIDEVICEINSTANCEA")] DIDEVICEINSTANCEA* param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, DIDEVICEINSTANCEA*, int> )(lpVtbl[15]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0);
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.RunControlPanel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, HWND, uint, int> )(lpVtbl[16]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <inheritdoc cref = "IDirectInputDeviceA.Initialize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("const GUID &")] Guid* param2)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, HINSTANCE, uint, Guid*, int> )(lpVtbl[17]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputDevice2A.xml' path='doc/member[@name="IDirectInputDevice2A.CreateEffect"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT CreateEffect([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCDIEFFECT")] DIEFFECT_DX6* param1, [NativeTypeName("LPDIRECTINPUTEFFECT *")] IDirectInputEffect** param2, [NativeTypeName("LPUNKNOWN")] IUnknown* param3)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, Guid*, DIEFFECT_DX6*, IDirectInputEffect**, IUnknown*, int> )(lpVtbl[18]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <include file='IDirectInputDevice2A.xml' path='doc/member[@name="IDirectInputDevice2A.EnumEffects"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT EnumEffects([NativeTypeName("LPDIENUMEFFECTSCALLBACKA")] delegate* unmanaged<DIEFFECTINFOA*, void*, BOOL> param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, delegate* unmanaged<DIEFFECTINFOA*, void*, BOOL> , void*, uint, int> )(lpVtbl[19]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputDevice2A.xml' path='doc/member[@name="IDirectInputDevice2A.GetEffectInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT GetEffectInfo([NativeTypeName("LPDIEFFECTINFOA")] DIEFFECTINFOA* param0, [NativeTypeName("const GUID &")] Guid* param1)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, DIEFFECTINFOA*, Guid*, int> )(lpVtbl[20]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputDevice2A.xml' path='doc/member[@name="IDirectInputDevice2A.GetForceFeedbackState"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT GetForceFeedbackState([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, uint*, int> )(lpVtbl[21]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDevice2A.xml' path='doc/member[@name="IDirectInputDevice2A.SendForceFeedbackCommand"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT SendForceFeedbackCommand([NativeTypeName("DWORD")] uint param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, uint, int> )(lpVtbl[22]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDevice2A.xml' path='doc/member[@name="IDirectInputDevice2A.EnumCreatedEffectObjects"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT EnumCreatedEffectObjects([NativeTypeName("LPDIENUMCREATEDEFFECTOBJECTSCALLBACK")] delegate* unmanaged<IDirectInputEffect*, void*, BOOL> param0, [NativeTypeName("LPVOID")] void* param1, [NativeTypeName("DWORD")] uint param2)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, delegate* unmanaged<IDirectInputEffect*, void*, BOOL> , void*, uint, int> )(lpVtbl[23]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputDevice2A.xml' path='doc/member[@name="IDirectInputDevice2A.Escape"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT Escape([NativeTypeName("LPDIEFFESCAPE")] DIEFFESCAPE* param0)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, DIEFFESCAPE*, int> )(lpVtbl[24]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputDevice2A.xml' path='doc/member[@name="IDirectInputDevice2A.Poll"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT Poll()
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, int> )(lpVtbl[25]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInputDevice2A.xml' path='doc/member[@name="IDirectInputDevice2A.SendDeviceData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT SendDeviceData([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPCDIDEVICEOBJECTDATA")] DIDEVICEOBJECTDATA* param1, [NativeTypeName("LPDWORD")] uint* param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged<IDirectInputDevice2A*, uint, DIDEVICEOBJECTDATA*, uint*, uint, int> )(lpVtbl[26]))((IDirectInputDevice2A*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    public interface Interface : IDirectInputDeviceA.Interface
    {
        [VtblIndex(18)]
        HRESULT CreateEffect([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCDIEFFECT")] DIEFFECT_DX6* param1, [NativeTypeName("LPDIRECTINPUTEFFECT *")] IDirectInputEffect** param2, [NativeTypeName("LPUNKNOWN")] IUnknown* param3);
        [VtblIndex(20)]
        HRESULT GetEffectInfo([NativeTypeName("LPDIEFFECTINFOA")] DIEFFECTINFOA* param0, [NativeTypeName("const GUID &")] Guid* param1);
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
        [NativeTypeName("HRESULT (LPDIENUMDEVICEOBJECTSCALLBACKA, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, delegate* unmanaged<DIDEVICEOBJECTINSTANCEA*, void*, BOOL> , void*, uint, int> EnumObjects;
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
        [NativeTypeName("HRESULT (LPDIDEVICEOBJECTINSTANCEA, DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIDEVICEOBJECTINSTANCEA*, uint, uint, int> GetObjectInfo;
        [NativeTypeName("HRESULT (LPDIDEVICEINSTANCEA) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIDEVICEINSTANCEA*, int> GetDeviceInfo;
        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> RunControlPanel;
        [NativeTypeName("HRESULT (HINSTANCE, DWORD, const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HINSTANCE, uint, Guid*, int> Initialize;
        [NativeTypeName("HRESULT (const GUID &, LPCDIEFFECT, LPDIRECTINPUTEFFECT *, LPUNKNOWN) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, DIEFFECT_DX6*, IDirectInputEffect**, IUnknown*, int> CreateEffect;
        [NativeTypeName("HRESULT (LPDIENUMEFFECTSCALLBACKA, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, delegate* unmanaged<DIEFFECTINFOA*, void*, BOOL> , void*, uint, int> EnumEffects;
        [NativeTypeName("HRESULT (LPDIEFFECTINFOA, const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIEFFECTINFOA*, Guid*, int> GetEffectInfo;
        [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetForceFeedbackState;
        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SendForceFeedbackCommand;
        [NativeTypeName("HRESULT (LPDIENUMCREATEDEFFECTOBJECTSCALLBACK, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, delegate* unmanaged<IDirectInputEffect*, void*, BOOL> , void*, uint, int> EnumCreatedEffectObjects;
        [NativeTypeName("HRESULT (LPDIEFFESCAPE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIEFFESCAPE*, int> Escape;
        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Poll;
        [NativeTypeName("HRESULT (DWORD, LPCDIDEVICEOBJECTDATA, LPDWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, DIDEVICEOBJECTDATA*, uint*, uint, int> SendDeviceData;
    }
}