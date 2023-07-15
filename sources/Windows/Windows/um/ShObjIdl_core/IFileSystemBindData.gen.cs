// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFileSystemBindData.xml' path='doc/member[@name="IFileSystemBindData"]/*'/>
[Guid("01E18D10-4D8B-11D2-855D-006008059367")]
[NativeTypeName("struct IFileSystemBindData : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileSystemBindData : IFileSystemBindData.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSystemBindData));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSystemBindData*, Guid*, void**, int> )(lpVtbl[0]))((IFileSystemBindData*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileSystemBindData*, uint> )(lpVtbl[1]))((IFileSystemBindData*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSystemBindData*, uint> )(lpVtbl[2]))((IFileSystemBindData*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFileSystemBindData.xml' path='doc/member[@name="IFileSystemBindData.SetFindData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFindData([NativeTypeName("const WIN32_FIND_DATAW *")] WIN32_FIND_DATAW* pfd)
    {
        return ((delegate* unmanaged<IFileSystemBindData*, WIN32_FIND_DATAW*, int> )(lpVtbl[3]))((IFileSystemBindData*)Unsafe.AsPointer(ref this), pfd);
    }

    /// <include file='IFileSystemBindData.xml' path='doc/member[@name="IFileSystemBindData.GetFindData"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFindData(WIN32_FIND_DATAW* pfd)
    {
        return ((delegate* unmanaged<IFileSystemBindData*, WIN32_FIND_DATAW*, int> )(lpVtbl[4]))((IFileSystemBindData*)Unsafe.AsPointer(ref this), pfd);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetFindData([NativeTypeName("const WIN32_FIND_DATAW *")] WIN32_FIND_DATAW* pfd);
        [VtblIndex(4)]
        HRESULT GetFindData(WIN32_FIND_DATAW* pfd);
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
    }
}