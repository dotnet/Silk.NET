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

[Guid("4B9F0EE0-0D7E-11D0-9B06-00A0C903A3B8")]
[NativeTypeName("struct IDirectDrawColorControl : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDirectDrawColorControl
    : IDirectDrawColorControl.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDirectDrawColorControl));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDirectDrawColorControl, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDirectDrawColorControl, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDirectDrawColorControl, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0)
    {
        return ((delegate* unmanaged<IDirectDrawColorControl, DDCOLORCONTROL*, int>)((*lpVtbl)[3]))(
            this,
            param0
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0)
    {
        return ((delegate* unmanaged<IDirectDrawColorControl, DDCOLORCONTROL*, int>)((*lpVtbl)[4]))(
            this,
            param0
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0);

        [VtblIndex(4)]
        HRESULT SetColorControls([NativeTypeName("LPDDCOLORCONTROL")] DDCOLORCONTROL* param0);
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
            "HRESULT (LPDDCOLORCONTROL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DDCOLORCONTROL*, int> GetColorControls;

        [NativeTypeName(
            "HRESULT (LPDDCOLORCONTROL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, DDCOLORCONTROL*, int> SetColorControls;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDirectDrawColorControl"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDirectDrawColorControl(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDirectDrawColorControl"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDirectDrawColorControl(Silk.NET.Windows.IUnknown value)
    {
        return new IDirectDrawColorControl(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDirectDrawColorControl"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDirectDrawColorControl"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDirectDrawColorControl value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
