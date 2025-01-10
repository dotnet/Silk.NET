// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlDisp.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00BB2762-6A77-11D0-A535-00C04FD7D062")]
[NativeTypeName("struct IAutoComplete : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IAutoComplete : IAutoComplete.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAutoComplete));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAutoComplete, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAutoComplete, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAutoComplete, uint>)((*lpVtbl)[2]))(this);
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
            (delegate* unmanaged<IAutoComplete, HWND, IUnknown, ushort*, ushort*, int>)(
                (*lpVtbl)[3]
            )
        )(this, hwndEdit, punkACL, pwszRegKeyPath, pwszQuickComplete);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Enable(BOOL fEnable)
    {
        return ((delegate* unmanaged<IAutoComplete, BOOL, int>)((*lpVtbl)[4]))(this, fEnable);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Init(
            HWND hwndEdit,
            IUnknown punkACL,
            [NativeTypeName("LPCWSTR")] ushort* pwszRegKeyPath,
            [NativeTypeName("LPCWSTR")] ushort* pwszQuickComplete
        );

        [VtblIndex(4)]
        HRESULT Enable(BOOL fEnable);
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IAutoComplete"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAutoComplete(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAutoComplete"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAutoComplete(Silk.NET.Windows.IUnknown value)
    {
        return new IAutoComplete(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAutoComplete"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAutoComplete"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAutoComplete value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
