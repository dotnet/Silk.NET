// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("A359DEC5-E813-4834-8A2A-BA7F1D777D76")]
[NativeTypeName("struct IWbemBackupRestoreEx : IWbemBackupRestore")]
[NativeInheritance("IWbemBackupRestore")]
public unsafe partial struct IWbemBackupRestoreEx : IWbemBackupRestoreEx.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemBackupRestoreEx));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWbemBackupRestoreEx, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Backup(
        [NativeTypeName("LPCWSTR")] ushort* strBackupToFile,
        [NativeTypeName("long")] int lFlags
    )
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx, ushort*, int, int>)((*lpVtbl)[3]))(
            this,
            strBackupToFile,
            lFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT Restore(
        [NativeTypeName("LPCWSTR")] ushort* strRestoreFromFile,
        [NativeTypeName("long")] int lFlags
    )
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx, ushort*, int, int>)((*lpVtbl)[4]))(
            this,
            strRestoreFromFile,
            lFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT Pause()
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx, int>)((*lpVtbl)[5]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Resume()
    {
        return ((delegate* unmanaged<IWbemBackupRestoreEx, int>)((*lpVtbl)[6]))(this);
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

    /// <summary>Initializes a new instance of the <see cref = "IWbemBackupRestoreEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWbemBackupRestoreEx(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IWbemBackupRestore"/> to <see cref = "IWbemBackupRestoreEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IWbemBackupRestore"/> instance to be converted </param>
    public static explicit operator IWbemBackupRestoreEx(Silk.NET.Windows.IWbemBackupRestore value)
    {
        return new IWbemBackupRestoreEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemBackupRestoreEx"/> to <see cref = "Silk.NET.Windows.IWbemBackupRestore"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemBackupRestoreEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IWbemBackupRestore(IWbemBackupRestoreEx value)
    {
        return new Silk.NET.Windows.IWbemBackupRestore(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWbemBackupRestoreEx"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWbemBackupRestoreEx(Silk.NET.Windows.IUnknown value)
    {
        return new IWbemBackupRestoreEx(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemBackupRestoreEx"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemBackupRestoreEx"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWbemBackupRestoreEx value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
