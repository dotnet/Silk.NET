// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IShellIconOverlayIdentifier.xml' path='doc/member[@name="IShellIconOverlayIdentifier"]/*'/>
[Guid("0C6C4200-C589-11D0-999A-00C04FD655E1")]
[NativeTypeName("struct IShellIconOverlayIdentifier : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellIconOverlayIdentifier : IShellIconOverlayIdentifier.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellIconOverlayIdentifier));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellIconOverlayIdentifier*, Guid*, void**, int> )(lpVtbl[0]))((IShellIconOverlayIdentifier*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellIconOverlayIdentifier*, uint> )(lpVtbl[1]))((IShellIconOverlayIdentifier*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellIconOverlayIdentifier*, uint> )(lpVtbl[2]))((IShellIconOverlayIdentifier*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellIconOverlayIdentifier.xml' path='doc/member[@name="IShellIconOverlayIdentifier.IsMemberOf"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT IsMemberOf([NativeTypeName("LPCWSTR")] ushort* pwszPath, [NativeTypeName("DWORD")] uint dwAttrib)
    {
        return ((delegate* unmanaged<IShellIconOverlayIdentifier*, ushort*, uint, int> )(lpVtbl[3]))((IShellIconOverlayIdentifier*)Unsafe.AsPointer(ref this), pwszPath, dwAttrib);
    }

    /// <include file='IShellIconOverlayIdentifier.xml' path='doc/member[@name="IShellIconOverlayIdentifier.GetOverlayInfo"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetOverlayInfo([NativeTypeName("LPWSTR")] ushort* pwszIconFile, int cchMax, int* pIndex, [NativeTypeName("DWORD *")] uint* pdwFlags)
    {
        return ((delegate* unmanaged<IShellIconOverlayIdentifier*, ushort*, int, int*, uint*, int> )(lpVtbl[4]))((IShellIconOverlayIdentifier*)Unsafe.AsPointer(ref this), pwszIconFile, cchMax, pIndex, pdwFlags);
    }

    /// <include file='IShellIconOverlayIdentifier.xml' path='doc/member[@name="IShellIconOverlayIdentifier.GetPriority"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetPriority(int* pPriority)
    {
        return ((delegate* unmanaged<IShellIconOverlayIdentifier*, int*, int> )(lpVtbl[5]))((IShellIconOverlayIdentifier*)Unsafe.AsPointer(ref this), pPriority);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT IsMemberOf([NativeTypeName("LPCWSTR")] ushort* pwszPath, [NativeTypeName("DWORD")] uint dwAttrib);
        [VtblIndex(4)]
        HRESULT GetOverlayInfo([NativeTypeName("LPWSTR")] ushort* pwszIconFile, int cchMax, int* pIndex, [NativeTypeName("DWORD *")] uint* pdwFlags);
        [VtblIndex(5)]
        HRESULT GetPriority(int* pPriority);
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
        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> IsMemberOf;
        [NativeTypeName("HRESULT (LPWSTR, int, int *, DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, uint*, int> GetOverlayInfo;
        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetPriority;
    }
}