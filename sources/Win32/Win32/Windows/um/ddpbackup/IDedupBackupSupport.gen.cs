// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C719D963-2B2D-415E-ACF7-7EB7CA596FF4")]
[NativeTypeName("struct IDedupBackupSupport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDedupBackupSupport : IDedupBackupSupport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDedupBackupSupport));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDedupBackupSupport, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDedupBackupSupport, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDedupBackupSupport, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RestoreFiles(
        [NativeTypeName("ULONG")] uint NumberOfFiles,
        [NativeTypeName("BSTR *")] ushort** FileFullPaths,
        IDedupReadFileCallback Store,
        [NativeTypeName("DWORD")] uint Flags,
        HRESULT* FileResults
    )
    {
        return (
            (delegate* unmanaged<
                IDedupBackupSupport,
                uint,
                ushort**,
                IDedupReadFileCallback,
                uint,
                HRESULT*,
                int>)((*lpVtbl)[3])
        )(this, NumberOfFiles, FileFullPaths, Store, Flags, FileResults);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RestoreFiles(
            [NativeTypeName("ULONG")] uint NumberOfFiles,
            [NativeTypeName("BSTR *")] ushort** FileFullPaths,
            IDedupReadFileCallback Store,
            [NativeTypeName("DWORD")] uint Flags,
            HRESULT* FileResults
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
            "HRESULT (ULONG, BSTR *, IDedupReadFileCallback *, DWORD, HRESULT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            uint,
            ushort**,
            IDedupReadFileCallback,
            uint,
            HRESULT*,
            int> RestoreFiles;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDedupBackupSupport"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDedupBackupSupport(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDedupBackupSupport"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDedupBackupSupport(Silk.NET.Windows.IUnknown value)
    {
        return new IDedupBackupSupport(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDedupBackupSupport"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDedupBackupSupport"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDedupBackupSupport value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
