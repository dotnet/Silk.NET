// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IWbemBackupRestoreEx.xml' path='doc/member[@name="IWbemBackupRestoreEx"]/*'/>
[Guid("A359DEC5-E813-4834-8A2A-BA7F1D777D76")]
[NativeTypeName("struct IWbemBackupRestoreEx : IWbemBackupRestore")]
[NativeInheritance("IWbemBackupRestore")]
public unsafe partial struct IWbemBackupRestoreEx : IWbemBackupRestoreEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemBackupRestoreEx));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx*, Guid*, void**, int> )(lpVtbl[0]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx*, uint> )(lpVtbl[1]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx*, uint> )(lpVtbl[2]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IWbemBackupRestore.Backup"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Backup([NativeTypeName("LPCWSTR")] ushort* strBackupToFile, [NativeTypeName("long")] int lFlags)
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx*, ushort*, int, int> )(lpVtbl[3]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this), strBackupToFile, lFlags);
    }

    /// <inheritdoc cref = "IWbemBackupRestore.Restore"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Restore([NativeTypeName("LPCWSTR")] ushort* strRestoreFromFile, [NativeTypeName("long")] int lFlags)
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx*, ushort*, int, int> )(lpVtbl[4]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this), strRestoreFromFile, lFlags);
    }

    /// <include file='IWbemBackupRestoreEx.xml' path='doc/member[@name="IWbemBackupRestoreEx.Pause"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx*, int> )(lpVtbl[5]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IWbemBackupRestoreEx.xml' path='doc/member[@name="IWbemBackupRestoreEx.Resume"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx*, int> )(lpVtbl[6]))((IWbemBackupRestoreEx*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IWbemBackupRestore.Interface
    {
        [VtblIndex(5)]
        HRESULT Pause();
        [VtblIndex(6)]
        HRESULT Resume();
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
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Pause;
        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Resume;
    }
}