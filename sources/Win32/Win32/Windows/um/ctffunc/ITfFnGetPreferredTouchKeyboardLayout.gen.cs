// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("5F309A41-590A-4ACC-A97F-D8EFFF13FDFC")]
[NativeTypeName("struct ITfFnGetPreferredTouchKeyboardLayout : ITfFunction")]
[NativeInheritance("ITfFunction")]
[SupportedOSPlatform("windows6.2")]
public unsafe partial struct ITfFnGetPreferredTouchKeyboardLayout
    : ITfFnGetPreferredTouchKeyboardLayout.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfFnGetPreferredTouchKeyboardLayout));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout, Guid*, void**, int>)(
                (*lpVtbl)[0]
            )
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout, uint>)((*lpVtbl)[1]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout, uint>)((*lpVtbl)[2]))(
            this
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetDisplayName([NativeTypeName("BSTR *")] ushort** pbstrName)
    {
        return (
            (delegate* unmanaged<ITfFnGetPreferredTouchKeyboardLayout, ushort**, int>)((*lpVtbl)[3])
        )(this, pbstrName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetLayout(
        TKBLayoutType* pTKBLayoutType,
        [NativeTypeName("WORD *")] ushort* pwPreferredLayoutId
    )
    {
        return (
            (delegate* unmanaged<
                ITfFnGetPreferredTouchKeyboardLayout,
                TKBLayoutType*,
                ushort*,
                int>)((*lpVtbl)[4])
        )(this, pTKBLayoutType, pwPreferredLayoutId);
    }

    public interface Interface : ITfFunction.Interface
    {
        [VtblIndex(4)]
        HRESULT GetLayout(
            TKBLayoutType* pTKBLayoutType,
            [NativeTypeName("WORD *")] ushort* pwPreferredLayoutId
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetDisplayName;

        [NativeTypeName("HRESULT (TKBLayoutType *, WORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, TKBLayoutType*, ushort*, int> GetLayout;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfFnGetPreferredTouchKeyboardLayout"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfFnGetPreferredTouchKeyboardLayout(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.ITfFunction"/> to <see cref = "ITfFnGetPreferredTouchKeyboardLayout"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.ITfFunction"/> instance to be converted </param>
    public static explicit operator ITfFnGetPreferredTouchKeyboardLayout(
        Silk.NET.Windows.ITfFunction value
    )
    {
        return new ITfFnGetPreferredTouchKeyboardLayout(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnGetPreferredTouchKeyboardLayout"/> to <see cref = "Silk.NET.Windows.ITfFunction"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnGetPreferredTouchKeyboardLayout"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.ITfFunction(
        ITfFnGetPreferredTouchKeyboardLayout value
    )
    {
        return new Silk.NET.Windows.ITfFunction(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfFnGetPreferredTouchKeyboardLayout"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfFnGetPreferredTouchKeyboardLayout(
        Silk.NET.Windows.IUnknown value
    )
    {
        return new ITfFnGetPreferredTouchKeyboardLayout(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfFnGetPreferredTouchKeyboardLayout"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfFnGetPreferredTouchKeyboardLayout"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(
        ITfFnGetPreferredTouchKeyboardLayout value
    )
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
