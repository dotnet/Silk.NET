// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("7BF992A9-AF7A-4DBA-B2E5-4D080B1ECBC6")]
[NativeTypeName("struct IStorageProviderCopyHook : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStorageProviderCopyHook
    : IStorageProviderCopyHook.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageProviderCopyHook));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageProviderCopyHook, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStorageProviderCopyHook, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageProviderCopyHook, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CopyCallback(
        HWND hwnd,
        uint operation,
        uint flags,
        [NativeTypeName("LPCWSTR")] ushort* srcFile,
        [NativeTypeName("DWORD")] uint srcAttribs,
        [NativeTypeName("LPCWSTR")] ushort* destFile,
        [NativeTypeName("DWORD")] uint destAttribs,
        uint* result
    )
    {
        return (
            (delegate* unmanaged<
                IStorageProviderCopyHook,
                HWND,
                uint,
                uint,
                ushort*,
                uint,
                ushort*,
                uint,
                uint*,
                int>)((*lpVtbl)[3])
        )(this, hwnd, operation, flags, srcFile, srcAttribs, destFile, destAttribs, result);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CopyCallback(
            HWND hwnd,
            uint operation,
            uint flags,
            [NativeTypeName("LPCWSTR")] ushort* srcFile,
            [NativeTypeName("DWORD")] uint srcAttribs,
            [NativeTypeName("LPCWSTR")] ushort* destFile,
            [NativeTypeName("DWORD")] uint destAttribs,
            uint* result
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
            "HRESULT (HWND, UINT, UINT, LPCWSTR, DWORD, LPCWSTR, DWORD, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            HWND,
            uint,
            uint,
            ushort*,
            uint,
            ushort*,
            uint,
            uint*,
            int> CopyCallback;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorageProviderCopyHook"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorageProviderCopyHook(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorageProviderCopyHook"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorageProviderCopyHook(Silk.NET.Windows.IUnknown value)
    {
        return new IStorageProviderCopyHook(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorageProviderCopyHook"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorageProviderCopyHook"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorageProviderCopyHook value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
