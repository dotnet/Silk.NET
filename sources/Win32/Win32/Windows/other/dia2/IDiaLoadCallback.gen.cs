// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C32ADB82-73F4-421B-95D5-A4706EDF5DBE")]
[NativeTypeName("struct IDiaLoadCallback : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDiaLoadCallback : IDiaLoadCallback.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDiaLoadCallback));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDiaLoadCallback, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDiaLoadCallback, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDiaLoadCallback, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT NotifyDebugDir(
        BOOL fExecutable,
        [NativeTypeName("DWORD")] uint cbData,
        byte* pbData
    )
    {
        return ((delegate* unmanaged<IDiaLoadCallback, BOOL, uint, byte*, int>)((*lpVtbl)[3]))(
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
        return ((delegate* unmanaged<IDiaLoadCallback, ushort*, HRESULT, int>)((*lpVtbl)[4]))(
            this,
            dbgPath,
            resultCode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT NotifyOpenPDB([NativeTypeName("LPCOLESTR")] ushort* pdbPath, HRESULT resultCode)
    {
        return ((delegate* unmanaged<IDiaLoadCallback, ushort*, HRESULT, int>)((*lpVtbl)[5]))(
            this,
            pdbPath,
            resultCode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RestrictRegistryAccess()
    {
        return ((delegate* unmanaged<IDiaLoadCallback, int>)((*lpVtbl)[6]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT RestrictSymbolServerAccess()
    {
        return ((delegate* unmanaged<IDiaLoadCallback, int>)((*lpVtbl)[7]))(this);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT NotifyDebugDir(
            BOOL fExecutable,
            [NativeTypeName("DWORD")] uint cbData,
            byte* pbData
        );

        [VtblIndex(4)]
        HRESULT NotifyOpenDBG([NativeTypeName("LPCOLESTR")] ushort* dbgPath, HRESULT resultCode);

        [VtblIndex(5)]
        HRESULT NotifyOpenPDB([NativeTypeName("LPCOLESTR")] ushort* pdbPath, HRESULT resultCode);

        [VtblIndex(6)]
        HRESULT RestrictRegistryAccess();

        [VtblIndex(7)]
        HRESULT RestrictSymbolServerAccess();
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
    }

    /// <summary>Initializes a new instance of the <see cref = "IDiaLoadCallback"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDiaLoadCallback(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDiaLoadCallback"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDiaLoadCallback(Silk.NET.Windows.IUnknown value)
    {
        return new IDiaLoadCallback(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDiaLoadCallback"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDiaLoadCallback"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDiaLoadCallback value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
