// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("4688A074-5A4D-4486-AEA8-7B90711D9F7C")]
[NativeTypeName("struct IDiaLoadCallback2 : IDiaLoadCallback")]
[NativeInheritance("IDiaLoadCallback")]
public unsafe partial struct IDiaLoadCallback2 : IDiaLoadCallback2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaLoadCallback2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaLoadCallback2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaLoadCallback2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaLoadCallback2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT NotifyDebugDir(
        BOOL fExecutable,
        [NativeTypeName("DWORD")] uint cbData,
        byte* pbData
    )
    {
        return ((delegate* unmanaged<IDiaLoadCallback2, BOOL, uint, byte*, int>)((*lpVtbl)[3]))(
            this,
            fExecutable,
            cbData,
            pbData
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT NotifyOpenDBG([NativeTypeName("LPCOLESTR")] ushort* dbgPath, HRESULT resultCode)
    {
        return ((delegate* unmanaged<IDiaLoadCallback2, ushort*, HRESULT, int>)((*lpVtbl)[4]))(
            this,
            dbgPath,
            resultCode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT NotifyOpenPDB([NativeTypeName("LPCOLESTR")] ushort* pdbPath, HRESULT resultCode)
    {
        return ((delegate* unmanaged<IDiaLoadCallback2, ushort*, HRESULT, int>)((*lpVtbl)[5]))(
            this,
            pdbPath,
            resultCode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RestrictRegistryAccess()
    {
        return ((delegate* unmanaged<IDiaLoadCallback2, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RestrictSymbolServerAccess()
    {
        return ((delegate* unmanaged<IDiaLoadCallback2, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT RestrictOriginalPathAccess()
    {
        return ((delegate* unmanaged<IDiaLoadCallback2, int>)((*lpVtbl)[8]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT RestrictReferencePathAccess()
    {
        return ((delegate* unmanaged<IDiaLoadCallback2, int>)((*lpVtbl)[9]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT RestrictDBGAccess()
    {
        return ((delegate* unmanaged<IDiaLoadCallback2, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT RestrictSystemRootAccess()
    {
        return ((delegate* unmanaged<IDiaLoadCallback2, int>)((*lpVtbl)[11]))(this);
    }

    public interface Interface : IDiaLoadCallback.Interface
    {
        [VtblIndex(8)]
        HRESULT RestrictOriginalPathAccess();

        [VtblIndex(9)]
        HRESULT RestrictReferencePathAccess();

        [VtblIndex(10)]
        HRESULT RestrictDBGAccess();

        [VtblIndex(11)]
        HRESULT RestrictSystemRootAccess();
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

        [NativeTypeName("HRESULT (BOOL, DWORD, BYTE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, BOOL, uint, byte*, int> NotifyDebugDir;

        [NativeTypeName("HRESULT (LPCOLESTR, HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, HRESULT, int> NotifyOpenDBG;

        [NativeTypeName("HRESULT (LPCOLESTR, HRESULT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, HRESULT, int> NotifyOpenPDB;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RestrictRegistryAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RestrictSymbolServerAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RestrictOriginalPathAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RestrictReferencePathAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RestrictDBGAccess;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> RestrictSystemRootAccess;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaLoadCallback2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaLoadCallback2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDiaLoadCallback"/> to <see cref = "IDiaLoadCallback2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDiaLoadCallback"/> instance to be converted </param>
    public static explicit operator IDiaLoadCallback2(Silk.NET.Windows.IDiaLoadCallback value)
    {
        return new IDiaLoadCallback2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaLoadCallback2"/> to <see cref = "Silk.NET.Windows.IDiaLoadCallback"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaLoadCallback2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDiaLoadCallback(IDiaLoadCallback2 value)
    {
        return new Silk.NET.Windows.IDiaLoadCallback(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaLoadCallback2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaLoadCallback2(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaLoadCallback2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaLoadCallback2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaLoadCallback2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaLoadCallback2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
