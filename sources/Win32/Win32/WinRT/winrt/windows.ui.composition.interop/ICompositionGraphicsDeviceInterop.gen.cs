// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.ui.composition.interop.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Silk.NET.Windows;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

[Guid("A116FF71-F8BF-4C8A-9C98-70779A32A9C8")]
[NativeTypeName("struct ICompositionGraphicsDeviceInterop : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICompositionGraphicsDeviceInterop
    : ICompositionGraphicsDeviceInterop.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICompositionGraphicsDeviceInterop));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ICompositionGraphicsDeviceInterop, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ICompositionGraphicsDeviceInterop, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICompositionGraphicsDeviceInterop, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetRenderingDevice(IUnknown* value)
    {
        return (
            (delegate* unmanaged<ICompositionGraphicsDeviceInterop, IUnknown*, int>)((*lpVtbl)[3])
        )(this, value);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetRenderingDevice(IUnknown value)
    {
        return (
            (delegate* unmanaged<ICompositionGraphicsDeviceInterop, IUnknown, int>)((*lpVtbl)[4])
        )(this, value);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetRenderingDevice(IUnknown* value);

        [VtblIndex(4)]
        HRESULT SetRenderingDevice(IUnknown value);
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

        [NativeTypeName("HRESULT (IUnknown **) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown*, int> GetRenderingDevice;

        [NativeTypeName("HRESULT (IUnknown *) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IUnknown, int> SetRenderingDevice;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICompositionGraphicsDeviceInterop"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICompositionGraphicsDeviceInterop(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICompositionGraphicsDeviceInterop"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICompositionGraphicsDeviceInterop(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ICompositionGraphicsDeviceInterop(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICompositionGraphicsDeviceInterop"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICompositionGraphicsDeviceInterop"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ICompositionGraphicsDeviceInterop value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
