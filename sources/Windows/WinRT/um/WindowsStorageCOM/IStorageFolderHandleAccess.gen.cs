// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WindowsStorageCOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using Silk.NET.Windows;
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT;
/// <include file='IStorageFolderHandleAccess.xml' path='doc/member[@name="IStorageFolderHandleAccess"]/*'/>
[Guid("DF19938F-5462-48A0-BE65-D2A3271A08D6")]
[NativeTypeName("struct IStorageFolderHandleAccess : IUnknown")]
[NativeInheritance("IUnknown")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct IStorageFolderHandleAccess : IStorageFolderHandleAccess.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorageFolderHandleAccess));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorageFolderHandleAccess*, Guid*, void**, int> )(lpVtbl[0]))((IStorageFolderHandleAccess*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IStorageFolderHandleAccess*, uint> )(lpVtbl[1]))((IStorageFolderHandleAccess*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorageFolderHandleAccess*, uint> )(lpVtbl[2]))((IStorageFolderHandleAccess*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IStorageFolderHandleAccess.xml' path='doc/member[@name="IStorageFolderHandleAccess.Create"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT Create([NativeTypeName("LPCWSTR")] ushort* fileName, HANDLE_CREATION_OPTIONS creationOptions, HANDLE_ACCESS_OPTIONS accessOptions, HANDLE_SHARING_OPTIONS sharingOptions, HANDLE_OPTIONS options, IOplockBreakingHandler* oplockBreakingHandler, HANDLE* interopHandle)
    {
        return ((delegate* unmanaged<IStorageFolderHandleAccess*, ushort*, HANDLE_CREATION_OPTIONS, HANDLE_ACCESS_OPTIONS, HANDLE_SHARING_OPTIONS, HANDLE_OPTIONS, IOplockBreakingHandler*, HANDLE*, int> )(lpVtbl[3]))((IStorageFolderHandleAccess*)Unsafe.AsPointer(ref this), fileName, creationOptions, accessOptions, sharingOptions, options, oplockBreakingHandler, interopHandle);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT Create([NativeTypeName("LPCWSTR")] ushort* fileName, HANDLE_CREATION_OPTIONS creationOptions, HANDLE_ACCESS_OPTIONS accessOptions, HANDLE_SHARING_OPTIONS sharingOptions, HANDLE_OPTIONS options, IOplockBreakingHandler* oplockBreakingHandler, HANDLE* interopHandle);
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
        [NativeTypeName("HRESULT (LPCWSTR, HANDLE_CREATION_OPTIONS, HANDLE_ACCESS_OPTIONS, HANDLE_SHARING_OPTIONS, HANDLE_OPTIONS, IOplockBreakingHandler *, HANDLE *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, HANDLE_CREATION_OPTIONS, HANDLE_ACCESS_OPTIONS, HANDLE_SHARING_OPTIONS, HANDLE_OPTIONS, IOplockBreakingHandler*, HANDLE*, int> Create;
    }
}