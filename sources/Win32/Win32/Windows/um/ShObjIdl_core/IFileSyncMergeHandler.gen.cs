// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("D97B5AAC-C792-433C-975D-35C4EADC7A9D")]
[NativeTypeName("struct IFileSyncMergeHandler : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows6.3")]
public unsafe partial struct IFileSyncMergeHandler : IFileSyncMergeHandler.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFileSyncMergeHandler));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFileSyncMergeHandler, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IFileSyncMergeHandler, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFileSyncMergeHandler, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Merge(
        [NativeTypeName("LPCWSTR")] ushort* localFilePath,
        [NativeTypeName("LPCWSTR")] ushort* serverFilePath,
        MERGE_UPDATE_STATUS* updateStatus
    )
    {
        return (
            (delegate* unmanaged<
                IFileSyncMergeHandler,
                ushort*,
                ushort*,
                MERGE_UPDATE_STATUS*,
                int>)((*lpVtbl)[3])
        )(this, localFilePath, serverFilePath, updateStatus);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT ShowResolveConflictUIAsync(
        [NativeTypeName("LPCWSTR")] ushort* localFilePath,
        HMONITOR monitorToDisplayOn
    )
    {
        return ((delegate* unmanaged<IFileSyncMergeHandler, ushort*, HMONITOR, int>)((*lpVtbl)[4]))(
            this,
            localFilePath,
            monitorToDisplayOn
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Merge(
            [NativeTypeName("LPCWSTR")] ushort* localFilePath,
            [NativeTypeName("LPCWSTR")] ushort* serverFilePath,
            MERGE_UPDATE_STATUS* updateStatus
        );

        [VtblIndex(4)]
        HRESULT ShowResolveConflictUIAsync(
            [NativeTypeName("LPCWSTR")] ushort* localFilePath,
            HMONITOR monitorToDisplayOn
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
            "HRESULT (LPCWSTR, LPCWSTR, MERGE_UPDATE_STATUS *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, MERGE_UPDATE_STATUS*, int> Merge;

        [NativeTypeName("HRESULT (LPCWSTR, HMONITOR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, HMONITOR, int> ShowResolveConflictUIAsync;
    }

    /// <summary>Initializes a new instance of the <see cref = "IFileSyncMergeHandler"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IFileSyncMergeHandler(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IFileSyncMergeHandler"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IFileSyncMergeHandler(Silk.NET.Windows.IUnknown value)
    {
        return new IFileSyncMergeHandler(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IFileSyncMergeHandler"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IFileSyncMergeHandler"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IFileSyncMergeHandler value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
