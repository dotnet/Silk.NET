// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ddpbackup.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IDedupBackupSupport.xml' path='doc/member[@name="IDedupBackupSupport"]/*'/>
[Guid("C719D963-2B2D-415E-ACF7-7EB7CA596FF4")]
[NativeTypeName("struct IDedupBackupSupport : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDedupBackupSupport : IDedupBackupSupport.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDedupBackupSupport));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDedupBackupSupport*, Guid*, void**, int> )(lpVtbl[0]))((IDedupBackupSupport*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDedupBackupSupport*, uint> )(lpVtbl[1]))((IDedupBackupSupport*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDedupBackupSupport*, uint> )(lpVtbl[2]))((IDedupBackupSupport*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDedupBackupSupport.xml' path='doc/member[@name="IDedupBackupSupport.RestoreFiles"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT RestoreFiles([NativeTypeName("ULONG")] uint NumberOfFiles, [NativeTypeName("BSTR *")] ushort** FileFullPaths, IDedupReadFileCallback* Store, [NativeTypeName("DWORD")] uint Flags, HRESULT* FileResults)
    {
        return ((delegate* unmanaged<IDedupBackupSupport*, uint, ushort**, IDedupReadFileCallback*, uint, HRESULT*, int> )(lpVtbl[3]))((IDedupBackupSupport*)Unsafe.AsPointer(ref this), NumberOfFiles, FileFullPaths, Store, Flags, FileResults);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT RestoreFiles([NativeTypeName("ULONG")] uint NumberOfFiles, [NativeTypeName("BSTR *")] ushort** FileFullPaths, IDedupReadFileCallback* Store, [NativeTypeName("DWORD")] uint Flags, HRESULT* FileResults);
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
        [NativeTypeName("HRESULT (ULONG, BSTR *, IDedupReadFileCallback *, DWORD, HRESULT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, ushort**, IDedupReadFileCallback*, uint, HRESULT*, int> RestoreFiles;
    }
}