// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dinput.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("9A4CB685-236D-11D3-8E9D-00C04F6844AE")]
[NativeTypeName("struct IDirectInput7W : IDirectInput2W")]
[NativeInheritance("IDirectInput2W")]
public unsafe partial struct IDirectInput7W : IDirectInput7W.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectInput7W));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectInput7W, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirectInput7W, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectInput7W, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateDevice(
        [NativeTypeName("const GUID &")] Guid* param0,
        [NativeTypeName("LPDIRECTINPUTDEVICEW *")] IDirectInputDeviceW* param1,
        [NativeTypeName("LPUNKNOWN")] IUnknown param2
    )
    {
        return (
            (delegate* unmanaged<IDirectInput7W, Guid*, IDirectInputDeviceW*, IUnknown, int>)(
                (*lpVtbl)[3]
            )
        )(this, param0, param1, param2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT EnumDevices(
        [NativeTypeName("DWORD")] uint param0,
        [NativeTypeName("LPDIENUMDEVICESCALLBACKW")]
            delegate* unmanaged<DIDEVICEINSTANCE*, void*, BOOL> param1,
        [NativeTypeName("LPVOID")] void* param2,
        [NativeTypeName("DWORD")] uint param3
    )
    {
        return (
            (delegate* unmanaged<
                IDirectInput7W,
                uint,
                delegate* unmanaged<DIDEVICEINSTANCE*, void*, BOOL>,
                void*,
                uint,
                int>)((*lpVtbl)[4])
        )(this, param0, param1, param2, param3);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetDeviceStatus([NativeTypeName("const GUID &")] Guid* param0)
    {
        return ((delegate* unmanaged<IDirectInput7W, Guid*, int>)((*lpVtbl)[5]))(this, param0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RunControlPanel(HWND param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInput7W, HWND, uint, int>)((*lpVtbl)[6]))(
            this,
            param0,
            param1
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInput7W, HINSTANCE, uint, int>)((*lpVtbl)[7]))(
            this,
            param0,
            param1
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT FindDevice(
        [NativeTypeName("const GUID &")] Guid* param0,
        [NativeTypeName("LPCWSTR")] ushort* param1,
        [NativeTypeName("LPGUID")] Guid* param2
    )
    {
        return ((delegate* unmanaged<IDirectInput7W, Guid*, ushort*, Guid*, int>)((*lpVtbl)[8]))(
            this,
            param0,
            param1,
            param2
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT CreateDeviceEx(
        [NativeTypeName("const GUID &")] Guid* param0,
        [NativeTypeName("const IID &")] Guid* param1,
        [NativeTypeName("LPVOID *")] void** param2,
        [NativeTypeName("LPUNKNOWN")] IUnknown param3
    )
    {
        return (
            (delegate* unmanaged<IDirectInput7W, Guid*, Guid*, void**, IUnknown, int>)((*lpVtbl)[9])
        )(this, param0, param1, param2, param3);
    }

    public interface Interface : IDirectInput2W.Interface
    {
        [VtblIndex(9)]
        HRESULT CreateDeviceEx(
            [NativeTypeName("const GUID &")] Guid* param0,
            [NativeTypeName("const IID &")] Guid* param1,
            [NativeTypeName("LPVOID *")] void** param2,
            [NativeTypeName("LPUNKNOWN")] IUnknown param3
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

        [NativeTypeName(
            "HRESULT (const GUID &, LPDIRECTINPUTDEVICEW *, LPUNKNOWN) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, IDirectInputDeviceW*, IUnknown, int> CreateDevice;

        [NativeTypeName(
            "HRESULT (DWORD, LPDIENUMDEVICESCALLBACKW, LPVOID, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            delegate* unmanaged<DIDEVICEINSTANCE*, void*, BOOL>,
            void*,
            uint,
            int> EnumDevices;

        [NativeTypeName("HRESULT (const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetDeviceStatus;

        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> RunControlPanel;

        [NativeTypeName(
            "HRESULT (HINSTANCE, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HINSTANCE, uint, int> Initialize;

        [NativeTypeName(
            "HRESULT (const GUID &, LPCWSTR, LPGUID) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort*, Guid*, int> FindDevice;

        [NativeTypeName(
            "HRESULT (const GUID &, const IID &, LPVOID *, LPUNKNOWN) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, Guid*, void**, IUnknown, int> CreateDeviceEx;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectInput7W"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectInput7W(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDirectInput2W"/> to <see cref = "IDirectInput7W"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDirectInput2W"/> instance to be converted </param>
    public static explicit operator IDirectInput7W(Silk.NET.DirectX.IDirectInput2W value)
    {
        return new IDirectInput7W(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectInput7W"/> to <see cref = "Silk.NET.DirectX.IDirectInput2W"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectInput7W"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDirectInput2W(IDirectInput7W value)
    {
        return new Silk.NET.DirectX.IDirectInput2W(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.DirectX.IDirectInputW"/> to <see cref = "IDirectInput7W"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.DirectX.IDirectInputW"/> instance to be converted </param>
    public static explicit operator IDirectInput7W(Silk.NET.DirectX.IDirectInputW value)
    {
        return new IDirectInput7W(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectInput7W"/> to <see cref = "Silk.NET.DirectX.IDirectInputW"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectInput7W"/> instance to be converted </param>
    public static implicit operator Silk.NET.DirectX.IDirectInputW(IDirectInput7W value)
    {
        return new Silk.NET.DirectX.IDirectInputW(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectInput7W"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectInput7W(Silk.NET.Windows.IUnknown value)
    {
        return new IDirectInput7W(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectInput7W"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectInput7W"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirectInput7W value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
