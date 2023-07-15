// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IFileSyncMergeHandler.xml' path='doc/member[@name="IFileSyncMergeHandler"]/*'/>
[Guid("D97B5AAC-C792-433C-975D-35C4EADC7A9D")]
[NativeTypeName("struct IFileSyncMergeHandler : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFileSyncMergeHandler : IFileSyncMergeHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSyncMergeHandler));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSyncMergeHandler*, Guid*, void**, int> )(lpVtbl[0]))((IFileSyncMergeHandler*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFileSyncMergeHandler*, uint> )(lpVtbl[1]))((IFileSyncMergeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSyncMergeHandler*, uint> )(lpVtbl[2]))((IFileSyncMergeHandler*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFileSyncMergeHandler.xml' path='doc/member[@name="IFileSyncMergeHandler.Merge"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Merge([NativeTypeName("LPCWSTR")] ushort* localFilePath, [NativeTypeName("LPCWSTR")] ushort* serverFilePath, MERGE_UPDATE_STATUS* updateStatus)
    {
        return ((delegate* unmanaged<IFileSyncMergeHandler*, ushort*, ushort*, MERGE_UPDATE_STATUS*, int> )(lpVtbl[3]))((IFileSyncMergeHandler*)Unsafe.AsPointer(ref this), localFilePath, serverFilePath, updateStatus);
    }

    /// <include file='IFileSyncMergeHandler.xml' path='doc/member[@name="IFileSyncMergeHandler.ShowResolveConflictUIAsync"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ShowResolveConflictUIAsync([NativeTypeName("LPCWSTR")] ushort* localFilePath, HMONITOR monitorToDisplayOn)
    {
        return ((delegate* unmanaged<IFileSyncMergeHandler*, ushort*, HMONITOR, int> )(lpVtbl[4]))((IFileSyncMergeHandler*)Unsafe.AsPointer(ref this), localFilePath, monitorToDisplayOn);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Merge([NativeTypeName("LPCWSTR")] ushort* localFilePath, [NativeTypeName("LPCWSTR")] ushort* serverFilePath, MERGE_UPDATE_STATUS* updateStatus);
        [VtblIndex(4)]
        HRESULT ShowResolveConflictUIAsync([NativeTypeName("LPCWSTR")] ushort* localFilePath, HMONITOR monitorToDisplayOn);
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
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, MERGE_UPDATE_STATUS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, MERGE_UPDATE_STATUS*, int> Merge;
        [NativeTypeName("HRESULT (LPCWSTR, HMONITOR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, HMONITOR, int> ShowResolveConflictUIAsync;
    }
}