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

[Guid("E7E1F7C0-88D2-11D0-9AD0-00A0C9A06E35")]
[NativeTypeName("struct IDirectInputEffect : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectInputEffect : IDirectInputEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectInputEffect));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectInputEffect, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirectInputEffect, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectInputEffect, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(
        HINSTANCE param0,
        [NativeTypeName("DWORD")] uint param1,
        [NativeTypeName("const GUID &")] Guid* param2
    )
    {
        return (
            (delegate* unmanaged<IDirectInputEffect, HINSTANCE, uint, Guid*, int>)((*lpVtbl)[3])
        )(this, param0, param1, param2);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEffectGuid([NativeTypeName("LPGUID")] Guid* param0)
    {
        return ((delegate* unmanaged<IDirectInputEffect, Guid*, int>)((*lpVtbl)[4]))(this, param0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetParameters(
        [NativeTypeName("LPDIEFFECT")] DIEFFECT_DX6* param0,
        [NativeTypeName("DWORD")] uint param1
    )
    {
        return ((delegate* unmanaged<IDirectInputEffect, DIEFFECT_DX6*, uint, int>)((*lpVtbl)[5]))(
            this,
            param0,
            param1
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetParameters(
        [NativeTypeName("LPCDIEFFECT")] DIEFFECT_DX6* param0,
        [NativeTypeName("DWORD")] uint param1
    )
    {
        return ((delegate* unmanaged<IDirectInputEffect, DIEFFECT_DX6*, uint, int>)((*lpVtbl)[6]))(
            this,
            param0,
            param1
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Start(
        [NativeTypeName("DWORD")] uint param0,
        [NativeTypeName("DWORD")] uint param1
    )
    {
        return ((delegate* unmanaged<IDirectInputEffect, uint, uint, int>)((*lpVtbl)[7]))(
            this,
            param0,
            param1
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IDirectInputEffect, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetEffectStatus([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectInputEffect, uint*, int>)((*lpVtbl)[9]))(this, param0);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Download()
    {
        return ((delegate* unmanaged<IDirectInputEffect, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Unload()
    {
        return ((delegate* unmanaged<IDirectInputEffect, int>)((*lpVtbl)[11]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Escape([NativeTypeName("LPDIEFFESCAPE")] DIEFFESCAPE* param0)
    {
        return ((delegate* unmanaged<IDirectInputEffect, DIEFFESCAPE*, int>)((*lpVtbl)[12]))(
            this,
            param0
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(
            HINSTANCE param0,
            [NativeTypeName("DWORD")] uint param1,
            [NativeTypeName("const GUID &")] Guid* param2
        );

        [VtblIndex(4)]
        HRESULT GetEffectGuid([NativeTypeName("LPGUID")] Guid* param0);

        [VtblIndex(5)]
        HRESULT GetParameters(
            [NativeTypeName("LPDIEFFECT")] DIEFFECT_DX6* param0,
            [NativeTypeName("DWORD")] uint param1
        );

        [VtblIndex(6)]
        HRESULT SetParameters(
            [NativeTypeName("LPCDIEFFECT")] DIEFFECT_DX6* param0,
            [NativeTypeName("DWORD")] uint param1
        );

        [VtblIndex(7)]
        HRESULT Start([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(8)]
        HRESULT Stop();

        [VtblIndex(9)]
        HRESULT GetEffectStatus([NativeTypeName("LPDWORD")] uint* param0);

        [VtblIndex(10)]
        HRESULT Download();

        [VtblIndex(11)]
        HRESULT Unload();

        [VtblIndex(12)]
        HRESULT Escape([NativeTypeName("LPDIEFFESCAPE")] DIEFFESCAPE* param0);
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
            "HRESULT (HINSTANCE, DWORD, const GUID &) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, HINSTANCE, uint, Guid*, int> Initialize;

        [NativeTypeName("HRESULT (LPGUID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetEffectGuid;

        [NativeTypeName(
            "HRESULT (LPDIEFFECT, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DIEFFECT_DX6*, uint, int> GetParameters;

        [NativeTypeName(
            "HRESULT (LPCDIEFFECT, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DIEFFECT_DX6*, uint, int> SetParameters;

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> Start;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Stop;

        [NativeTypeName("HRESULT (LPDWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetEffectStatus;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Download;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Unload;

        [NativeTypeName(
            "HRESULT (LPDIEFFESCAPE) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DIEFFESCAPE*, int> Escape;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectInputEffect"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectInputEffect(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectInputEffect"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectInputEffect(Silk.NET.Windows.IUnknown value)
    {
        return new IDirectInputEffect(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectInputEffect"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectInputEffect"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirectInputEffect value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
