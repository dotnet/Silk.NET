// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("73C105EE-9DFF-4A07-B83C-7EFF290C266E")]
[NativeTypeName("struct IProtectedModeMenuServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IProtectedModeMenuServices
    : IProtectedModeMenuServices.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectedModeMenuServices));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return (
            (delegate* unmanaged<IProtectedModeMenuServices, Guid*, void**, int>)((*lpVtbl)[0])
        )(this, riid, ppvObject);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectedModeMenuServices, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectedModeMenuServices, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateMenu(HMENU* phMenu)
    {
        return ((delegate* unmanaged<IProtectedModeMenuServices, HMENU*, int>)((*lpVtbl)[3]))(
            this,
            phMenu
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LoadMenuW(
        [NativeTypeName("LPCWSTR")] ushort* pszModuleName,
        [NativeTypeName("LPCWSTR")] ushort* pszMenuName,
        HMENU* phMenu
    )
    {
        return (
            (delegate* unmanaged<IProtectedModeMenuServices, ushort*, ushort*, HMENU*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pszModuleName, pszMenuName, phMenu);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LoadMenuID(
        [NativeTypeName("LPCWSTR")] ushort* pszModuleName,
        [NativeTypeName("WORD")] ushort wResourceID,
        HMENU* phMenu
    )
    {
        return (
            (delegate* unmanaged<IProtectedModeMenuServices, ushort*, ushort, HMENU*, int>)(
                (*lpVtbl)[5]
            )
        )(this, pszModuleName, wResourceID, phMenu);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateMenu(HMENU* phMenu);

        [VtblIndex(4)]
        HRESULT LoadMenuW(
            [NativeTypeName("LPCWSTR")] ushort* pszModuleName,
            [NativeTypeName("LPCWSTR")] ushort* pszMenuName,
            HMENU* phMenu
        );

        [VtblIndex(5)]
        HRESULT LoadMenuID(
            [NativeTypeName("LPCWSTR")] ushort* pszModuleName,
            [NativeTypeName("WORD")] ushort wResourceID,
            HMENU* phMenu
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

        [NativeTypeName("HRESULT (HMENU *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMENU*, int> CreateMenu;

        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, HMENU *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, HMENU*, int> LoadMenuW;

        [NativeTypeName("HRESULT (LPCWSTR, WORD, HMENU *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort, HMENU*, int> LoadMenuID;
    }

    /// <summary>Initializes a new instance of the <see cref = "IProtectedModeMenuServices"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IProtectedModeMenuServices(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IProtectedModeMenuServices"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IProtectedModeMenuServices(Silk.NET.Windows.IUnknown value)
    {
        return new IProtectedModeMenuServices(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IProtectedModeMenuServices"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IProtectedModeMenuServices"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IProtectedModeMenuServices value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
