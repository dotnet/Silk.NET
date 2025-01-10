// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX;

[Guid("69C11C3E-B46B-11D1-AD7A-00C04FC29B4E")]
[NativeTypeName("struct IDirectDrawGammaControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectDrawGammaControl
    : IDirectDrawGammaControl.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectDrawGammaControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectDrawGammaControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirectDrawGammaControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectDrawGammaControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetGammaRamp(
        [NativeTypeName("DWORD")] uint param0,
        [NativeTypeName("LPDDGAMMARAMP")] DDGAMMARAMP* param1
    )
    {
        return (
            (delegate* unmanaged<IDirectDrawGammaControl, uint, DDGAMMARAMP*, int>)((*lpVtbl)[3])
        )(this, param0, param1);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetGammaRamp(
        [NativeTypeName("DWORD")] uint param0,
        [NativeTypeName("LPDDGAMMARAMP")] DDGAMMARAMP* param1
    )
    {
        return (
            (delegate* unmanaged<IDirectDrawGammaControl, uint, DDGAMMARAMP*, int>)((*lpVtbl)[4])
        )(this, param0, param1);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetGammaRamp(
            [NativeTypeName("DWORD")] uint param0,
            [NativeTypeName("LPDDGAMMARAMP")] DDGAMMARAMP* param1
        );

        [VtblIndex(4)]
        HRESULT SetGammaRamp(
            [NativeTypeName("DWORD")] uint param0,
            [NativeTypeName("LPDDGAMMARAMP")] DDGAMMARAMP* param1
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
            "HRESULT (DWORD, LPDDGAMMARAMP) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, DDGAMMARAMP*, int> GetGammaRamp;

        [NativeTypeName(
            "HRESULT (DWORD, LPDDGAMMARAMP) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, DDGAMMARAMP*, int> SetGammaRamp;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectDrawGammaControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectDrawGammaControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectDrawGammaControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectDrawGammaControl(Silk.NET.Windows.IUnknown value)
    {
        return new IDirectDrawGammaControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectDrawGammaControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectDrawGammaControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirectDrawGammaControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
