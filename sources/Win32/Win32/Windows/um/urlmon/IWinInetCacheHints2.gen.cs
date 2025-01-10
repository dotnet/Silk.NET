// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/urlmon.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7857AEAC-D31F-49BF-884E-DD46DF36780A")]
[NativeTypeName("struct IWinInetCacheHints2 : IWinInetCacheHints")]
[NativeInheritance("IWinInetCacheHints")]
public unsafe partial struct IWinInetCacheHints2 : IWinInetCacheHints2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWinInetCacheHints2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWinInetCacheHints2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWinInetCacheHints2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWinInetCacheHints2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetCacheExtension(
        [NativeTypeName("LPCWSTR")] ushort* pwzExt,
        [NativeTypeName("LPVOID")] void* pszCacheFile,
        [NativeTypeName("DWORD *")] uint* pcbCacheFile,
        [NativeTypeName("DWORD *")] uint* pdwWinInetError,
        [NativeTypeName("DWORD *")] uint* pdwReserved
    )
    {
        return (
            (delegate* unmanaged<IWinInetCacheHints2, ushort*, void*, uint*, uint*, uint*, int>)(
                (*lpVtbl)[3]
            )
        )(this, pwzExt, pszCacheFile, pcbCacheFile, pdwWinInetError, pdwReserved);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT SetCacheExtension2(
        [NativeTypeName("LPCWSTR")] ushort* pwzExt,
        [NativeTypeName("WCHAR *")] ushort* pwzCacheFile,
        [NativeTypeName("DWORD *")] uint* pcchCacheFile,
        [NativeTypeName("DWORD *")] uint* pdwWinInetError,
        [NativeTypeName("DWORD *")] uint* pdwReserved
    )
    {
        return (
            (delegate* unmanaged<IWinInetCacheHints2, ushort*, ushort*, uint*, uint*, uint*, int>)(
                (*lpVtbl)[4]
            )
        )(this, pwzExt, pwzCacheFile, pcchCacheFile, pdwWinInetError, pdwReserved);
    }

    public interface Interface : IWinInetCacheHints.Interface
    {
        [VtblIndex(4)]
        HRESULT SetCacheExtension2(
            [NativeTypeName("LPCWSTR")] ushort* pwzExt,
            [NativeTypeName("WCHAR *")] ushort* pwzCacheFile,
            [NativeTypeName("DWORD *")] uint* pcchCacheFile,
            [NativeTypeName("DWORD *")] uint* pdwWinInetError,
            [NativeTypeName("DWORD *")] uint* pdwReserved
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
            "HRESULT (LPCWSTR, LPVOID, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            void*,
            uint*,
            uint*,
            uint*,
            int> SetCacheExtension;

        [NativeTypeName(
            "HRESULT (LPCWSTR, WCHAR *, DWORD *, DWORD *, DWORD *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            uint*,
            uint*,
            uint*,
            int> SetCacheExtension2;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWinInetCacheHints2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWinInetCacheHints2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWinInetCacheHints"/> to <see cref = "IWinInetCacheHints2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWinInetCacheHints"/> instance to be converted </param>
    public static explicit operator IWinInetCacheHints2(Silk.NET.Windows.IWinInetCacheHints value)
    {
        return new IWinInetCacheHints2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWinInetCacheHints2"/> to <see cref = "Silk.NET.Windows.IWinInetCacheHints"/>.</summary>
    /// <param name = "value">The <see cref = "IWinInetCacheHints2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWinInetCacheHints(IWinInetCacheHints2 value)
    {
        return new Silk.NET.Windows.IWinInetCacheHints(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWinInetCacheHints2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWinInetCacheHints2(Silk.NET.Windows.IUnknown value)
    {
        return new IWinInetCacheHints2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWinInetCacheHints2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWinInetCacheHints2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWinInetCacheHints2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
