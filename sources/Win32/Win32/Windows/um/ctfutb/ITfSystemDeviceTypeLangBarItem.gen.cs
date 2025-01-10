// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("45672EB9-9059-46A2-838D-4530355F6A77")]
[NativeTypeName("struct ITfSystemDeviceTypeLangBarItem : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ITfSystemDeviceTypeLangBarItem
    : ITfSystemDeviceTypeLangBarItem.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ITfSystemDeviceTypeLangBarItem));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<ITfSystemDeviceTypeLangBarItem, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ITfSystemDeviceTypeLangBarItem, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ITfSystemDeviceTypeLangBarItem, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetIconMode([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<ITfSystemDeviceTypeLangBarItem, uint, int>)((*lpVtbl)[3]))(
            this,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetIconMode([NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<ITfSystemDeviceTypeLangBarItem, uint*, int>)((*lpVtbl)[4]))(
            this,
            pdwFlags
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetIconMode([NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(4)]
        HRESULT GetIconMode([NativeTypeName("DWORD *")] uint* pdwFlags);
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

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetIconMode;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetIconMode;
    }

    /// <summary>Initializes a new instance of the <see cref = "ITfSystemDeviceTypeLangBarItem"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ITfSystemDeviceTypeLangBarItem(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ITfSystemDeviceTypeLangBarItem"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ITfSystemDeviceTypeLangBarItem(Silk.NET.Windows.IUnknown value)
    {
        return new ITfSystemDeviceTypeLangBarItem(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ITfSystemDeviceTypeLangBarItem"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ITfSystemDeviceTypeLangBarItem"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ITfSystemDeviceTypeLangBarItem value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
