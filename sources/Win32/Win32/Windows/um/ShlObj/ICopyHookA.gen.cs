// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("000214EF-0000-0000-C000-000000000046")]
[NativeTypeName("struct ICopyHookA : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ICopyHookA : ICopyHookA.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ICopyHookA));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ICopyHookA, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ICopyHookA, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ICopyHookA, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public uint CopyCallback(
        HWND hwnd,
        uint wFunc,
        uint wFlags,
        [NativeTypeName("PCSTR")] sbyte* pszSrcFile,
        [NativeTypeName("DWORD")] uint dwSrcAttribs,
        [NativeTypeName("PCSTR")] sbyte* pszDestFile,
        [NativeTypeName("DWORD")] uint dwDestAttribs
    )
    {
        return (
            (delegate* unmanaged<ICopyHookA, HWND, uint, uint, sbyte*, uint, sbyte*, uint, uint>)(
                (*lpVtbl)[3]
            )
        )(this, hwnd, wFunc, wFlags, pszSrcFile, dwSrcAttribs, pszDestFile, dwDestAttribs);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        uint CopyCallback(
            HWND hwnd,
            uint wFunc,
            uint wFlags,
            [NativeTypeName("PCSTR")] sbyte* pszSrcFile,
            [NativeTypeName("DWORD")] uint dwSrcAttribs,
            [NativeTypeName("PCSTR")] sbyte* pszDestFile,
            [NativeTypeName("DWORD")] uint dwDestAttribs
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

        [NativeTypeName(
            "UINT (HWND, UINT, UINT, PCSTR, DWORD, PCSTR, DWORD) __attribute__((nothrow)) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            uint,
            uint,
            sbyte*,
            uint,
            sbyte*,
            uint,
            uint> CopyCallback;
    }

    /// <summary>Initializes a new instance of the <see cref = "ICopyHookA"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ICopyHookA(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ICopyHookA"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ICopyHookA(Silk.NET.Windows.IUnknown value)
    {
        return new ICopyHookA(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ICopyHookA"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ICopyHookA"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ICopyHookA value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
