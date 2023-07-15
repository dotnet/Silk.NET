// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using TerraFX.Interop.Windows;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;
/// <include file='IDirectInput7W.xml' path='doc/member[@name="IDirectInput7W"]/*'/>
[Guid("9A4CB685-236D-11D3-8E9D-00C04F6844AE")]
[NativeTypeName("struct IDirectInput7W : IDirectInput2W")]
[NativeInheritance("IDirectInput2W")]
public unsafe partial struct IDirectInput7W : IDirectInput7W.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectInput7W));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectInput7W*, Guid*, void**, int> )(lpVtbl[0]))((IDirectInput7W*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectInput7W*, uint> )(lpVtbl[1]))((IDirectInput7W*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectInput7W*, uint> )(lpVtbl[2]))((IDirectInput7W*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDirectInputW.CreateDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDevice([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPDIRECTINPUTDEVICEW *")] IDirectInputDeviceW** param1, [NativeTypeName("LPUNKNOWN")] IUnknown* param2)
    {
        return ((delegate* unmanaged<IDirectInput7W*, Guid*, IDirectInputDeviceW**, IUnknown*, int> )(lpVtbl[3]))((IDirectInput7W*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <inheritdoc cref = "IDirectInputW.EnumDevices"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumDevices([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIENUMDEVICESCALLBACKW")] delegate* unmanaged<DIDEVICEINSTANCE*, void*, BOOL> param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged<IDirectInput7W*, uint, delegate* unmanaged<DIDEVICEINSTANCE*, void*, BOOL> , void*, uint, int> )(lpVtbl[4]))((IDirectInput7W*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <inheritdoc cref = "IDirectInputW.GetDeviceStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDeviceStatus([NativeTypeName("const GUID &")] Guid* param0)
    {
        return ((delegate* unmanaged<IDirectInput7W*, Guid*, int> )(lpVtbl[5]))((IDirectInput7W*)Unsafe.AsPointer(ref this), param0);
    }

    /// <inheritdoc cref = "IDirectInputW.RunControlPanel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInput7W*, HWND, uint, int> )(lpVtbl[6]))((IDirectInput7W*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <inheritdoc cref = "IDirectInputW.Initialize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInput7W*, HINSTANCE, uint, int> )(lpVtbl[7]))((IDirectInput7W*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <inheritdoc cref = "IDirectInput2W.FindDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindDevice([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCWSTR")] ushort* param1, [NativeTypeName("LPGUID")] Guid* param2)
    {
        return ((delegate* unmanaged<IDirectInput7W*, Guid*, ushort*, Guid*, int> )(lpVtbl[8]))((IDirectInput7W*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInput7W.xml' path='doc/member[@name="IDirectInput7W.CreateDeviceEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateDeviceEx([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("const IID &")] Guid* param1, [NativeTypeName("LPVOID *")] void** param2, [NativeTypeName("LPUNKNOWN")] IUnknown* param3)
    {
        return ((delegate* unmanaged<IDirectInput7W*, Guid*, Guid*, void**, IUnknown*, int> )(lpVtbl[9]))((IDirectInput7W*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    public interface Interface : IDirectInput2W.Interface
    {
        [VtblIndex(9)]
        HRESULT CreateDeviceEx([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("const IID &")] Guid* param1, [NativeTypeName("LPVOID *")] void** param2, [NativeTypeName("LPUNKNOWN")] IUnknown* param3);
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
        [NativeTypeName("HRESULT (const GUID &, LPDIRECTINPUTDEVICEW *, LPUNKNOWN) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IDirectInputDeviceW**, IUnknown*, int> CreateDevice;
        [NativeTypeName("HRESULT (DWORD, LPDIENUMDEVICESCALLBACKW, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, delegate* unmanaged<DIDEVICEINSTANCE*, void*, BOOL> , void*, uint, int> EnumDevices;
        [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetDeviceStatus;
        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> RunControlPanel;
        [NativeTypeName("HRESULT (HINSTANCE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HINSTANCE, uint, int> Initialize;
        [NativeTypeName("HRESULT (const GUID &, LPCWSTR, LPGUID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, Guid*, int> FindDevice;
        [NativeTypeName("HRESULT (const GUID &, const IID &, LPVOID *, LPUNKNOWN) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, IUnknown*, int> CreateDeviceEx;
    }
}