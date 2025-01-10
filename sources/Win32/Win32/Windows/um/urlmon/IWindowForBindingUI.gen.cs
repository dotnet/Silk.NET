// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("79EAC9D5-BAFA-11CE-8C82-00AA004BA90B")]
[NativeTypeName("struct IWindowForBindingUI : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWindowForBindingUI : IWindowForBindingUI.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWindowForBindingUI));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWindowForBindingUI, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWindowForBindingUI, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWindowForBindingUI, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, HWND* phwnd)
    {
        return ((delegate* unmanaged<IWindowForBindingUI, Guid*, HWND*, int>)((*lpVtbl)[3]))(
            this,
            rguidReason,
            phwnd
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetWindow([NativeTypeName("const GUID &")] Guid* rguidReason, HWND* phwnd);
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

        [NativeTypeName("HRESULT (const GUID &, HWND *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, HWND*, int> GetWindow;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWindowForBindingUI"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWindowForBindingUI(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWindowForBindingUI"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWindowForBindingUI(Silk.NET.Windows.IUnknown value)
    {
        return new IWindowForBindingUI(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWindowForBindingUI"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWindowForBindingUI"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWindowForBindingUI value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
