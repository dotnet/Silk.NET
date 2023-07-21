// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IFileSystemBindData2.xml' path='doc/member[@name="IFileSystemBindData2"]/*' />
[Guid("3ACF075F-71DB-4AFA-81F0-3FC4FDF2A5B8")]
[NativeTypeName("struct IFileSystemBindData2 : IFileSystemBindData")]
[NativeInheritance("IFileSystemBindData")]
public unsafe partial struct IFileSystemBindData2 : IFileSystemBindData2.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSystemBindData2));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSystemBindData2*, Guid*, void**, int>)(lpVtbl[0]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileSystemBindData2*, uint>)(lpVtbl[1]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSystemBindData2*, uint>)(lpVtbl[2]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IFileSystemBindData.SetFindData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFindData([NativeTypeName("const WIN32_FIND_DATAW *")] WIN32_FIND_DATAW* pfd)
    {
        return ((delegate* unmanaged<IFileSystemBindData2*, WIN32_FIND_DATAW*, int>)(lpVtbl[3]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), pfd);
    }

    /// <inheritdoc cref="IFileSystemBindData.GetFindData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFindData(WIN32_FIND_DATAW* pfd)
    {
        return ((delegate* unmanaged<IFileSystemBindData2*, WIN32_FIND_DATAW*, int>)(lpVtbl[4]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), pfd);
    }

    /// <include file='IFileSystemBindData2.xml' path='doc/member[@name="IFileSystemBindData2.SetFileID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFileID(LARGE_INTEGER liFileID)
    {
        return ((delegate* unmanaged<IFileSystemBindData2*, LARGE_INTEGER, int>)(lpVtbl[5]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), liFileID);
    }

    /// <include file='IFileSystemBindData2.xml' path='doc/member[@name="IFileSystemBindData2.GetFileID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFileID(LARGE_INTEGER* pliFileID)
    {
        return ((delegate* unmanaged<IFileSystemBindData2*, LARGE_INTEGER*, int>)(lpVtbl[6]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), pliFileID);
    }

    /// <include file='IFileSystemBindData2.xml' path='doc/member[@name="IFileSystemBindData2.SetJunctionCLSID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetJunctionCLSID([NativeTypeName("const IID &")] Guid* clsid)
    {
        return ((delegate* unmanaged<IFileSystemBindData2*, Guid*, int>)(lpVtbl[7]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), clsid);
    }

    /// <include file='IFileSystemBindData2.xml' path='doc/member[@name="IFileSystemBindData2.GetJunctionCLSID"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetJunctionCLSID([NativeTypeName("CLSID *")] Guid* pclsid)
    {
        return ((delegate* unmanaged<IFileSystemBindData2*, Guid*, int>)(lpVtbl[8]))((IFileSystemBindData2*)Unsafe.AsPointer(ref this), pclsid);
    }

    public interface Interface : IFileSystemBindData.Interface
    {
        [VtblIndex(5)]
        HRESULT SetFileID(LARGE_INTEGER liFileID);

        [VtblIndex(6)]
        HRESULT GetFileID(LARGE_INTEGER* pliFileID);

        [VtblIndex(7)]
        HRESULT SetJunctionCLSID([NativeTypeName("const IID &")] Guid* clsid);

        [VtblIndex(8)]
        HRESULT GetJunctionCLSID([NativeTypeName("CLSID *")] Guid* pclsid);
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

        [NativeTypeName("HRESULT (const WIN32_FIND_DATAW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WIN32_FIND_DATAW*, int> SetFindData;

        [NativeTypeName("HRESULT (WIN32_FIND_DATAW *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, WIN32_FIND_DATAW*, int> GetFindData;

        [NativeTypeName("HRESULT (LARGE_INTEGER) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LARGE_INTEGER, int> SetFileID;

        [NativeTypeName("HRESULT (LARGE_INTEGER *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LARGE_INTEGER*, int> GetFileID;

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetJunctionCLSID;

        [NativeTypeName("HRESULT (CLSID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetJunctionCLSID;
    }
}
