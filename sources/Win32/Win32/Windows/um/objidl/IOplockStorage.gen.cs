// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("8D19C834-8879-11D1-83E9-00C04FC2C6D4")]
[NativeTypeName("struct IOplockStorage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOplockStorage : IOplockStorage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOplockStorage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOplockStorage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IOplockStorage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOplockStorage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateStorageEx(
        [NativeTypeName("LPCWSTR")] ushort* pwcsName,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("DWORD")] uint stgfmt,
        [NativeTypeName("DWORD")] uint grfAttrs,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppstgOpen
    )
    {
        return (
            (delegate* unmanaged<IOplockStorage, ushort*, uint, uint, uint, Guid*, void**, int>)(
                (*lpVtbl)[3]
            )
        )(this, pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OpenStorageEx(
        [NativeTypeName("LPCWSTR")] ushort* pwcsName,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("DWORD")] uint stgfmt,
        [NativeTypeName("DWORD")] uint grfAttrs,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppstgOpen
    )
    {
        return (
            (delegate* unmanaged<IOplockStorage, ushort*, uint, uint, uint, Guid*, void**, int>)(
                (*lpVtbl)[4]
            )
        )(this, pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateStorageEx(
            [NativeTypeName("LPCWSTR")] ushort* pwcsName,
            [NativeTypeName("DWORD")] uint grfMode,
            [NativeTypeName("DWORD")] uint stgfmt,
            [NativeTypeName("DWORD")] uint grfAttrs,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppstgOpen
        );

        [VtblIndex(4)]
        HRESULT OpenStorageEx(
            [NativeTypeName("LPCWSTR")] ushort* pwcsName,
            [NativeTypeName("DWORD")] uint grfMode,
            [NativeTypeName("DWORD")] uint stgfmt,
            [NativeTypeName("DWORD")] uint grfAttrs,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppstgOpen
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
            "HRESULT (LPCWSTR, DWORD, DWORD, DWORD, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            uint,
            uint,
            Guid*,
            void**,
            int> CreateStorageEx;

        [NativeTypeName(
            "HRESULT (LPCWSTR, DWORD, DWORD, DWORD, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            uint,
            uint,
            uint,
            Guid*,
            void**,
            int> OpenStorageEx;
    }

    /// <summary>Initializes a new instance of the <see cref = "IOplockStorage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IOplockStorage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IOplockStorage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IOplockStorage(Silk.NET.Windows.IUnknown value)
    {
        return new IOplockStorage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IOplockStorage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IOplockStorage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IOplockStorage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
