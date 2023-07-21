// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dinput.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX;

/// <include file='IDirectInputEffect.xml' path='doc/member[@name="IDirectInputEffect"]/*' />
[Guid("E7E1F7C0-88D2-11D0-9AD0-00A0C9A06E35")]
[NativeTypeName("struct IDirectInputEffect : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectInputEffect : IDirectInputEffect.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectInputEffect));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectInputEffect*, Guid*, void**, int>)(lpVtbl[0]))((IDirectInputEffect*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDirectInputEffect*, uint>)(lpVtbl[1]))((IDirectInputEffect*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectInputEffect*, uint>)(lpVtbl[2]))((IDirectInputEffect*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInputEffect.xml' path='doc/member[@name="IDirectInputEffect.Initialize"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("const GUID &")] Guid* param2)
    {
        return ((delegate* unmanaged<IDirectInputEffect*, HINSTANCE, uint, Guid*, int>)(lpVtbl[3]))((IDirectInputEffect*)Unsafe.AsPointer(ref this), param0, param1, param2);
    }

    /// <include file='IDirectInputEffect.xml' path='doc/member[@name="IDirectInputEffect.GetEffectGuid"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetEffectGuid([NativeTypeName("LPGUID")] Guid* param0)
    {
        return ((delegate* unmanaged<IDirectInputEffect*, Guid*, int>)(lpVtbl[4]))((IDirectInputEffect*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputEffect.xml' path='doc/member[@name="IDirectInputEffect.GetParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetParameters([NativeTypeName("LPDIEFFECT")] DIEFFECT_DX6* param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInputEffect*, DIEFFECT_DX6*, uint, int>)(lpVtbl[5]))((IDirectInputEffect*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputEffect.xml' path='doc/member[@name="IDirectInputEffect.SetParameters"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetParameters([NativeTypeName("LPCDIEFFECT")] DIEFFECT_DX6* param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInputEffect*, DIEFFECT_DX6*, uint, int>)(lpVtbl[6]))((IDirectInputEffect*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputEffect.xml' path='doc/member[@name="IDirectInputEffect.Start"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Start([NativeTypeName("DWORD")] uint param0, [NativeTypeName("DWORD")] uint param1)
    {
        return ((delegate* unmanaged<IDirectInputEffect*, uint, uint, int>)(lpVtbl[7]))((IDirectInputEffect*)Unsafe.AsPointer(ref this), param0, param1);
    }

    /// <include file='IDirectInputEffect.xml' path='doc/member[@name="IDirectInputEffect.Stop"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT Stop()
    {
        return ((delegate* unmanaged<IDirectInputEffect*, int>)(lpVtbl[8]))((IDirectInputEffect*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInputEffect.xml' path='doc/member[@name="IDirectInputEffect.GetEffectStatus"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetEffectStatus([NativeTypeName("LPDWORD")] uint* param0)
    {
        return ((delegate* unmanaged<IDirectInputEffect*, uint*, int>)(lpVtbl[9]))((IDirectInputEffect*)Unsafe.AsPointer(ref this), param0);
    }

    /// <include file='IDirectInputEffect.xml' path='doc/member[@name="IDirectInputEffect.Download"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Download()
    {
        return ((delegate* unmanaged<IDirectInputEffect*, int>)(lpVtbl[10]))((IDirectInputEffect*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInputEffect.xml' path='doc/member[@name="IDirectInputEffect.Unload"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Unload()
    {
        return ((delegate* unmanaged<IDirectInputEffect*, int>)(lpVtbl[11]))((IDirectInputEffect*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDirectInputEffect.xml' path='doc/member[@name="IDirectInputEffect.Escape"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT Escape([NativeTypeName("LPDIEFFESCAPE")] DIEFFESCAPE* param0)
    {
        return ((delegate* unmanaged<IDirectInputEffect*, DIEFFESCAPE*, int>)(lpVtbl[12]))((IDirectInputEffect*)Unsafe.AsPointer(ref this), param0);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Initialize(HINSTANCE param0, [NativeTypeName("DWORD")] uint param1, [NativeTypeName("const GUID &")] Guid* param2);

        [VtblIndex(4)]
        HRESULT GetEffectGuid([NativeTypeName("LPGUID")] Guid* param0);

        [VtblIndex(5)]
        HRESULT GetParameters([NativeTypeName("LPDIEFFECT")] DIEFFECT_DX6* param0, [NativeTypeName("DWORD")] uint param1);

        [VtblIndex(6)]
        HRESULT SetParameters([NativeTypeName("LPCDIEFFECT")] DIEFFECT_DX6* param0, [NativeTypeName("DWORD")] uint param1);

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

        [NativeTypeName("HRESULT (HINSTANCE, DWORD, const GUID &) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HINSTANCE, uint, Guid*, int> Initialize;

        [NativeTypeName("HRESULT (LPGUID) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetEffectGuid;

        [NativeTypeName("HRESULT (LPDIEFFECT, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIEFFECT_DX6*, uint, int> GetParameters;

        [NativeTypeName("HRESULT (LPCDIEFFECT, DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
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

        [NativeTypeName("HRESULT (LPDIEFFESCAPE) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, DIEFFESCAPE*, int> Escape;
    }
}
