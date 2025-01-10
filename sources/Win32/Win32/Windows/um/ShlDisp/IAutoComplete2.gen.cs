// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("EAC04BC0-3791-11D2-BB95-0060977B464C")]
[NativeTypeName("struct IAutoComplete2 : IAutoComplete")]
[NativeInheritance("IAutoComplete")]
public unsafe partial struct IAutoComplete2 : IAutoComplete2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAutoComplete2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAutoComplete2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAutoComplete2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAutoComplete2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Init(
        HWND hwndEdit,
        IUnknown punkACL,
        [NativeTypeName("LPCWSTR")] ushort* pwszRegKeyPath,
        [NativeTypeName("LPCWSTR")] ushort* pwszQuickComplete
    )
    {
        return (
            (delegate* unmanaged<IAutoComplete2, HWND, IUnknown, ushort*, ushort*, int>)(
                (*lpVtbl)[3]
            )
        )(this, hwndEdit, punkACL, pwszRegKeyPath, pwszQuickComplete);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Enable(BOOL fEnable)
    {
        return ((delegate* unmanaged<IAutoComplete2, BOOL, int>)((*lpVtbl)[4]))(this, fEnable);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetOptions([NativeTypeName("DWORD")] uint dwFlag)
    {
        return ((delegate* unmanaged<IAutoComplete2, uint, int>)((*lpVtbl)[5]))(this, dwFlag);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetOptions([NativeTypeName("DWORD *")] uint* pdwFlag)
    {
        return ((delegate* unmanaged<IAutoComplete2, uint*, int>)((*lpVtbl)[6]))(this, pdwFlag);
    }

    public interface Interface : IAutoComplete.Interface
    {
        [VtblIndex(5)]
        HRESULT SetOptions([NativeTypeName("DWORD")] uint dwFlag);

        [VtblIndex(6)]
        HRESULT GetOptions([NativeTypeName("DWORD *")] uint* pdwFlag);
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

        [NativeTypeName("HRESULT (HWND, IUnknown *, LPCWSTR, LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, IUnknown, ushort*, ushort*, int> Init;

        [NativeTypeName("HRESULT (BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, int> Enable;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> SetOptions;

        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetOptions;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAutoComplete2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAutoComplete2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IAutoComplete"/> to <see cref = "IAutoComplete2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IAutoComplete"/> instance to be converted </param>
    public static explicit operator IAutoComplete2(Silk.NET.Windows.IAutoComplete value)
    {
        return new IAutoComplete2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAutoComplete2"/> to <see cref = "Silk.NET.Windows.IAutoComplete"/>.</summary>
    /// <param name = "value">The <see cref = "IAutoComplete2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IAutoComplete(IAutoComplete2 value)
    {
        return new Silk.NET.Windows.IAutoComplete(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAutoComplete2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAutoComplete2(Silk.NET.Windows.IUnknown value)
    {
        return new IAutoComplete2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAutoComplete2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAutoComplete2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAutoComplete2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
