// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;
/// <include file='IOplockStorage.xml' path='doc/member[@name="IOplockStorage"]/*'/>
[Guid("8D19C834-8879-11D1-83E9-00C04FC2C6D4")]
[NativeTypeName("struct IOplockStorage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IOplockStorage : IOplockStorage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IOplockStorage));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IOplockStorage*, Guid*, void**, int> )(lpVtbl[0]))((IOplockStorage*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IOplockStorage*, uint> )(lpVtbl[1]))((IOplockStorage*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IOplockStorage*, uint> )(lpVtbl[2]))((IOplockStorage*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IOplockStorage.xml' path='doc/member[@name="IOplockStorage.CreateStorageEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateStorageEx([NativeTypeName("LPCWSTR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, [NativeTypeName("const IID &")] Guid* riid, void** ppstgOpen)
    {
        return ((delegate* unmanaged<IOplockStorage*, ushort*, uint, uint, uint, Guid*, void**, int> )(lpVtbl[3]))((IOplockStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
    }

    /// <include file='IOplockStorage.xml' path='doc/member[@name="IOplockStorage.OpenStorageEx"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OpenStorageEx([NativeTypeName("LPCWSTR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, [NativeTypeName("const IID &")] Guid* riid, void** ppstgOpen)
    {
        return ((delegate* unmanaged<IOplockStorage*, ushort*, uint, uint, uint, Guid*, void**, int> )(lpVtbl[4]))((IOplockStorage*)Unsafe.AsPointer(ref this), pwcsName, grfMode, stgfmt, grfAttrs, riid, ppstgOpen);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateStorageEx([NativeTypeName("LPCWSTR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, [NativeTypeName("const IID &")] Guid* riid, void** ppstgOpen);
        [VtblIndex(4)]
        HRESULT OpenStorageEx([NativeTypeName("LPCWSTR")] ushort* pwcsName, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("DWORD")] uint stgfmt, [NativeTypeName("DWORD")] uint grfAttrs, [NativeTypeName("const IID &")] Guid* riid, void** ppstgOpen);
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
        [NativeTypeName("HRESULT (LPCWSTR, DWORD, DWORD, DWORD, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint, uint, Guid*, void**, int> CreateStorageEx;
        [NativeTypeName("HRESULT (LPCWSTR, DWORD, DWORD, DWORD, const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint, uint, Guid*, void**, int> OpenStorageEx;
    }
}