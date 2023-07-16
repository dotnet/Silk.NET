// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWbemBackupRestore.xml' path='doc/member[@name="IWbemBackupRestore"]/*'/>
[Guid("C49E32C7-BC8B-11D2-85D4-00105A1F8304")]
[NativeTypeName("struct IWbemBackupRestore : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemBackupRestore : IWbemBackupRestore.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemBackupRestore));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemBackupRestore*, Guid*, void**, int> )(lpVtbl[0]))((IWbemBackupRestore*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWbemBackupRestore*, uint> )(lpVtbl[1]))((IWbemBackupRestore*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemBackupRestore*, uint> )(lpVtbl[2]))((IWbemBackupRestore*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWbemBackupRestore.xml' path='doc/member[@name="IWbemBackupRestore.Backup"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Backup([NativeTypeName("LPCWSTR")] ushort* strBackupToFile, [NativeTypeName("long")] int lFlags)
    {
        return ((delegate* unmanaged<IWbemBackupRestore*, ushort*, int, int> )(lpVtbl[3]))((IWbemBackupRestore*)Unsafe.AsPointer(ref this), strBackupToFile, lFlags);
    }

    /// <include file='IWbemBackupRestore.xml' path='doc/member[@name="IWbemBackupRestore.Restore"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Restore([NativeTypeName("LPCWSTR")] ushort* strRestoreFromFile, [NativeTypeName("long")] int lFlags)
    {
        return ((delegate* unmanaged<IWbemBackupRestore*, ushort*, int, int> )(lpVtbl[4]))((IWbemBackupRestore*)Unsafe.AsPointer(ref this), strRestoreFromFile, lFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Backup([NativeTypeName("LPCWSTR")] ushort* strBackupToFile, [NativeTypeName("long")] int lFlags);
        [VtblIndex(4)]
        HRESULT Restore([NativeTypeName("LPCWSTR")] ushort* strRestoreFromFile, [NativeTypeName("long")] int lFlags);
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
        [NativeTypeName("HRESULT (LPCWSTR, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> Backup;
        [NativeTypeName("HRESULT (LPCWSTR, long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> Restore;
    }
}