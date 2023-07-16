// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;
/// <include file='IDirectInput2A.xml' path='doc/member[@name="IDirectInput2A"]/*'/>
[Guid("5944E662-AA8A-11CF-BFC7-444553540000")]
[NativeTypeName("struct IDirectInput2A : IDirectInputA")]
[NativeInheritance("IDirectInputA")]
public unsafe partial struct IDirectInput2A : IDirectInput2A.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectInput2A));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectInput2A*, Guid*, void**, int> )(lpVtbl[0]))((IDirectInput2A*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectInput2A*, uint> )(lpVtbl[1]))((IDirectInput2A*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectInput2A*, uint> )(lpVtbl[2]))((IDirectInput2A*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IDirectInputA.CreateDevice"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDevice([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPDIRECTINPUTDEVICEA *")] IDirectInputDeviceA** param1, [NativeTypeName("LPUNKNOWN")] IUnknown* param2)
    {
        return ((delegate* unmanaged<IDirectInput2A*, Guid*, IDirectInputDeviceA**, IUnknown*, int> )(lpVtbl[3]))((IDirectInput2A*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <inheritdoc cref = "IDirectInputA.EnumDevices"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumDevices([NativeTypeName("DWORD")] uint param0, [NativeTypeName("LPDIENUMDEVICESCALLBACKA")] delegate* unmanaged<DIDEVICEINSTANCEA*, void*, BOOL> param1, [NativeTypeName("LPVOID")] void* param2, [NativeTypeName("DWORD")] uint param3)
    {
        return ((delegate* unmanaged<IDirectInput2A*, uint, delegate* unmanaged<DIDEVICEINSTANCEA*, void*, BOOL> , void*, uint, int> )(lpVtbl[4]))((IDirectInput2A*)Unsafe.AsPointer(ref this), param0, param1, param2, param3);
    }

    /// <inheritdoc cref = "IDirectInputA.GetDeviceStatus"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDeviceStatus([NativeTypeName("const GUID &")] Guid* param0)
    {
        return ((delegate* unmanaged<IDirectInput2A*, Guid*, int> )(lpVtbl[5]))((IDirectInput2A*)Unsafe.AsPointer(ref this), param0);
    }

    /// <inheritdoc cref = "IDirectInputA.RunControlPanel"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInput2A*, HWND, uint, int> )(lpVtbl[6]))((IDirectInput2A*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <inheritdoc cref = "IDirectInputA.Initialize"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInput2A*, HINSTANCE, uint, int> )(lpVtbl[7]))((IDirectInput2A*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInput2A.xml' path='doc/member[@name="IDirectInput2A.FindDevice"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindDevice([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPGUID")] Guid* param2)
    {
        return ((delegate* unmanaged<IDirectInput2A*, Guid*, sbyte*, Guid*, int> )(lpVtbl[8]))((IDirectInput2A*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    public interface Interface : IDirectInputA.Interface
    {
        [VtblIndex(8)]
        HRESULT FindDevice([NativeTypeName("const GUID &")] Guid* param0, [NativeTypeName("LPCSTR")] sbyte* param1, [NativeTypeName("LPGUID")] Guid* param2);
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
        [NativeTypeName("HRESULT (const GUID &, LPDIRECTINPUTDEVICEA *, LPUNKNOWN) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IDirectInputDeviceA**, IUnknown*, int> CreateDevice;
        [NativeTypeName("HRESULT (DWORD, LPDIENUMDEVICESCALLBACKA, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, delegate* unmanaged<DIDEVICEINSTANCEA*, void*, BOOL> , void*, uint, int> EnumDevices;
        [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetDeviceStatus;
        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> RunControlPanel;
        [NativeTypeName("HRESULT (HINSTANCE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HINSTANCE, uint, int> Initialize;
        [NativeTypeName("HRESULT (const GUID &, LPCSTR, LPGUID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, sbyte*, Guid*, int> FindDevice;
    }
}