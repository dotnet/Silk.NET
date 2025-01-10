// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("1E13E9EC-6B33-4D4A-B5EB-8A92F029F356")]
[NativeTypeName("struct ITfSystemLangBarItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfSystemLangBarItem : ITfSystemLangBarItem.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfSystemLangBarItem));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ITfSystemLangBarItem, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ITfSystemLangBarItem, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfSystemLangBarItem, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetIcon(HICON hIcon)
    {
        return ((delegate* unmanaged<ITfSystemLangBarItem, HICON, int>)((*lpVtbl)[3]))(this, hIcon);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetTooltipString(
        [NativeTypeName("WCHAR *")] ushort* pchToolTip,
        [NativeTypeName("ULONG")] uint cch
    )
    {
        return ((delegate* unmanaged<ITfSystemLangBarItem, ushort*, uint, int>)((*lpVtbl)[4]))(
            this,
            pchToolTip,
            cch
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetIcon(HICON hIcon);

        [VtblIndex(4)]
        HRESULT SetTooltipString(
            [NativeTypeName("WCHAR *")] ushort* pchToolTip,
            [NativeTypeName("ULONG")] uint cch
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

        [NativeTypeName("HRESULT (HICON) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HICON, int> SetIcon;

        [NativeTypeName("HRESULT (WCHAR *, ULONG) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetTooltipString;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfSystemLangBarItem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfSystemLangBarItem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfSystemLangBarItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfSystemLangBarItem(Silk.NET.Windows.IUnknown value)
    {
        return new ITfSystemLangBarItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfSystemLangBarItem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfSystemLangBarItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfSystemLangBarItem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
