// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/DocObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='IProtectedModeMenuServices.xml' path='doc/member[@name="IProtectedModeMenuServices"]/*'/>
[Guid("73C105EE-9DFF-4A07-B83C-7EFF290C266E")]
[NativeTypeName("struct IProtectedModeMenuServices : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IProtectedModeMenuServices : IProtectedModeMenuServices.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IProtectedModeMenuServices));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IProtectedModeMenuServices*, Guid*, void**, int> )(lpVtbl[0]))((IProtectedModeMenuServices*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IProtectedModeMenuServices*, uint> )(lpVtbl[1]))((IProtectedModeMenuServices*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IProtectedModeMenuServices*, uint> )(lpVtbl[2]))((IProtectedModeMenuServices*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IProtectedModeMenuServices.xml' path='doc/member[@name="IProtectedModeMenuServices.CreateMenu"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateMenu(HMENU* phMenu)
    {
        return ((delegate* unmanaged<IProtectedModeMenuServices*, HMENU*, int> )(lpVtbl[3]))((IProtectedModeMenuServices*)Unsafe.AsPointer(ref this), phMenu);
    }

    /// <include file='IProtectedModeMenuServices.xml' path='doc/member[@name="IProtectedModeMenuServices.LoadMenuW"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LoadMenuW([NativeTypeName("LPCWSTR")] ushort* pszModuleName, [NativeTypeName("LPCWSTR")] ushort* pszMenuName, HMENU* phMenu)
    {
        return ((delegate* unmanaged<IProtectedModeMenuServices*, ushort*, ushort*, HMENU*, int> )(lpVtbl[4]))((IProtectedModeMenuServices*)Unsafe.AsPointer(ref this), pszModuleName, pszMenuName, phMenu);
    }

    /// <include file='IProtectedModeMenuServices.xml' path='doc/member[@name="IProtectedModeMenuServices.LoadMenuID"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT LoadMenuID([NativeTypeName("LPCWSTR")] ushort* pszModuleName, [NativeTypeName("WORD")] ushort wResourceID, HMENU* phMenu)
    {
        return ((delegate* unmanaged<IProtectedModeMenuServices*, ushort*, ushort, HMENU*, int> )(lpVtbl[5]))((IProtectedModeMenuServices*)Unsafe.AsPointer(ref this), pszModuleName, wResourceID, phMenu);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateMenu(HMENU* phMenu);
        [VtblIndex(4)]
        HRESULT LoadMenuW([NativeTypeName("LPCWSTR")] ushort* pszModuleName, [NativeTypeName("LPCWSTR")] ushort* pszMenuName, HMENU* phMenu);
        [VtblIndex(5)]
        HRESULT LoadMenuID([NativeTypeName("LPCWSTR")] ushort* pszModuleName, [NativeTypeName("WORD")] ushort wResourceID, HMENU* phMenu);
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
        [NativeTypeName("HRESULT (HMENU *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HMENU*, int> CreateMenu;
        [NativeTypeName("HRESULT (LPCWSTR, LPCWSTR, HMENU *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, HMENU*, int> LoadMenuW;
        [NativeTypeName("HRESULT (LPCWSTR, WORD, HMENU *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort, HMENU*, int> LoadMenuID;
    }
}