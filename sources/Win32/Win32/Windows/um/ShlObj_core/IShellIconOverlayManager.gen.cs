// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("F10B5E34-DD3B-42A7-AA7D-2F4EC54BB09B")]
[NativeTypeName("struct IShellIconOverlayManager : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellIconOverlayManager
    : IShellIconOverlayManager.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellIconOverlayManager));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellIconOverlayManager, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellIconOverlayManager, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellIconOverlayManager, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetFileOverlayInfo(
        [NativeTypeName("PCWSTR")] ushort* pwszPath,
        [NativeTypeName("DWORD")] uint dwAttrib,
        int* pIndex,
        [NativeTypeName("DWORD")] uint dwflags
    )
    {
        return (
            (delegate* unmanaged<IShellIconOverlayManager, ushort*, uint, int*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pwszPath, dwAttrib, pIndex, dwflags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetReservedOverlayInfo(
        [NativeTypeName("PCWSTR")] ushort* pwszPath,
        [NativeTypeName("DWORD")] uint dwAttrib,
        int* pIndex,
        [NativeTypeName("DWORD")] uint dwflags,
        int iReservedID
    )
    {
        return (
            (delegate* unmanaged<IShellIconOverlayManager, ushort*, uint, int*, uint, int, int>)(
                (*lpVtbl)[4]
            )
        )(this, pwszPath, dwAttrib, pIndex, dwflags, iReservedID);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT RefreshOverlayImages([NativeTypeName("DWORD")] uint dwFlags)
    {
        return ((delegate* unmanaged<IShellIconOverlayManager, uint, int>)((*lpVtbl)[5]))(
            this,
            dwFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT LoadNonloadedOverlayIdentifiers()
    {
        return ((delegate* unmanaged<IShellIconOverlayManager, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT OverlayIndexFromImageIndex(int iImage, int* piIndex, BOOL fAdd)
    {
        return (
            (delegate* unmanaged<IShellIconOverlayManager, int, int*, BOOL, int>)((*lpVtbl)[7])
        )(this, iImage, piIndex, fAdd);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetFileOverlayInfo(
            [NativeTypeName("PCWSTR")] ushort* pwszPath,
            [NativeTypeName("DWORD")] uint dwAttrib,
            int* pIndex,
            [NativeTypeName("DWORD")] uint dwflags
        );

        [VtblIndex(4)]
        HRESULT GetReservedOverlayInfo(
            [NativeTypeName("PCWSTR")] ushort* pwszPath,
            [NativeTypeName("DWORD")] uint dwAttrib,
            int* pIndex,
            [NativeTypeName("DWORD")] uint dwflags,
            int iReservedID
        );

        [VtblIndex(5)]
        HRESULT RefreshOverlayImages([NativeTypeName("DWORD")] uint dwFlags);

        [VtblIndex(6)]
        HRESULT LoadNonloadedOverlayIdentifiers();

        [VtblIndex(7)]
        HRESULT OverlayIndexFromImageIndex(int iImage, int* piIndex, BOOL fAdd);
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
            "HRESULT (PCWSTR, DWORD, int *, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, int*, uint, int> GetFileOverlayInfo;

        [NativeTypeName(
            "HRESULT (PCWSTR, DWORD, int *, DWORD, int) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            int*,
            uint,
            int,
            int> GetReservedOverlayInfo;

        [NativeTypeName("HRESULT (DWORD) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> RefreshOverlayImages;

        [NativeTypeName("HRESULT () __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> LoadNonloadedOverlayIdentifiers;

        [NativeTypeName(
            "HRESULT (int, int *, BOOL) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, int*, BOOL, int> OverlayIndexFromImageIndex;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellIconOverlayManager"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellIconOverlayManager(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellIconOverlayManager"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellIconOverlayManager(Silk.NET.Windows.IUnknown value)
    {
        return new IShellIconOverlayManager(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellIconOverlayManager"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellIconOverlayManager"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellIconOverlayManager value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
