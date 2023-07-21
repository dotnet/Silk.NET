// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IFolderViewOptions.xml' path='doc/member[@name="IFolderViewOptions"]/*' />
[Guid("3CC974D2-B302-4D36-AD3E-06D93F695D3F")]
[NativeTypeName("struct IFolderViewOptions : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IFolderViewOptions : IFolderViewOptions.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IFolderViewOptions));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IFolderViewOptions*, Guid*, void**, int>)(lpVtbl[0]))((IFolderViewOptions*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IFolderViewOptions*, uint>)(lpVtbl[1]))((IFolderViewOptions*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IFolderViewOptions*, uint>)(lpVtbl[2]))((IFolderViewOptions*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IFolderViewOptions.xml' path='doc/member[@name="IFolderViewOptions.SetFolderViewOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetFolderViewOptions(FOLDERVIEWOPTIONS fvoMask, FOLDERVIEWOPTIONS fvoFlags)
    {
        return ((delegate* unmanaged<IFolderViewOptions*, FOLDERVIEWOPTIONS, FOLDERVIEWOPTIONS, int>)(lpVtbl[3]))((IFolderViewOptions*)Unsafe.AsPointer(ref this), fvoMask, fvoFlags);
    }

    /// <include file='IFolderViewOptions.xml' path='doc/member[@name="IFolderViewOptions.GetFolderViewOptions"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetFolderViewOptions(FOLDERVIEWOPTIONS* pfvoFlags)
    {
        return ((delegate* unmanaged<IFolderViewOptions*, FOLDERVIEWOPTIONS*, int>)(lpVtbl[4]))((IFolderViewOptions*)Unsafe.AsPointer(ref this), pfvoFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetFolderViewOptions(FOLDERVIEWOPTIONS fvoMask, FOLDERVIEWOPTIONS fvoFlags);

        [VtblIndex(4)]
        HRESULT GetFolderViewOptions(FOLDERVIEWOPTIONS* pfvoFlags);
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

        [NativeTypeName("HRESULT (FOLDERVIEWOPTIONS, FOLDERVIEWOPTIONS) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FOLDERVIEWOPTIONS, FOLDERVIEWOPTIONS, int> SetFolderViewOptions;

        [NativeTypeName("HRESULT (FOLDERVIEWOPTIONS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, FOLDERVIEWOPTIONS*, int> GetFolderViewOptions;
    }
}
