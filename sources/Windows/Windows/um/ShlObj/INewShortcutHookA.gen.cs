// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShlObj.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='INewShortcutHookA.xml' path='doc/member[@name="INewShortcutHookA"]/*'/>
[Guid("000214E1-0000-0000-C000-000000000046")]
[NativeTypeName("struct INewShortcutHookA : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct INewShortcutHookA : INewShortcutHookA.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_INewShortcutHookA));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<INewShortcutHookA*, Guid*, void**, int> )(lpVtbl[0]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<INewShortcutHookA*, uint> )(lpVtbl[1]))((INewShortcutHookA*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<INewShortcutHookA*, uint> )(lpVtbl[2]))((INewShortcutHookA*)Unsafe.AsPointer(ref this));
    }

    /// <include file='INewShortcutHookA.xml' path='doc/member[@name="INewShortcutHookA.SetReferent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT SetReferent([NativeTypeName("PCSTR")] sbyte* pcszReferent, HWND hwnd)
    {
        return ((delegate* unmanaged<INewShortcutHookA*, sbyte*, HWND, int> )(lpVtbl[3]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), pcszReferent, hwnd);
    }

    /// <include file='INewShortcutHookA.xml' path='doc/member[@name="INewShortcutHookA.GetReferent"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetReferent([NativeTypeName("PSTR")] sbyte* pszReferent, int cchReferent)
    {
        return ((delegate* unmanaged<INewShortcutHookA*, sbyte*, int, int> )(lpVtbl[4]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), pszReferent, cchReferent);
    }

    /// <include file='INewShortcutHookA.xml' path='doc/member[@name="INewShortcutHookA.SetFolder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetFolder([NativeTypeName("PCSTR")] sbyte* pcszFolder)
    {
        return ((delegate* unmanaged<INewShortcutHookA*, sbyte*, int> )(lpVtbl[5]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), pcszFolder);
    }

    /// <include file='INewShortcutHookA.xml' path='doc/member[@name="INewShortcutHookA.GetFolder"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetFolder([NativeTypeName("PSTR")] sbyte* pszFolder, int cchFolder)
    {
        return ((delegate* unmanaged<INewShortcutHookA*, sbyte*, int, int> )(lpVtbl[6]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), pszFolder, cchFolder);
    }

    /// <include file='INewShortcutHookA.xml' path='doc/member[@name="INewShortcutHookA.GetName"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetName([NativeTypeName("PSTR")] sbyte* pszName, int cchName)
    {
        return ((delegate* unmanaged<INewShortcutHookA*, sbyte*, int, int> )(lpVtbl[7]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), pszName, cchName);
    }

    /// <include file='INewShortcutHookA.xml' path='doc/member[@name="INewShortcutHookA.GetExtension"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetExtension([NativeTypeName("PSTR")] sbyte* pszExtension, int cchExtension)
    {
        return ((delegate* unmanaged<INewShortcutHookA*, sbyte*, int, int> )(lpVtbl[8]))((INewShortcutHookA*)Unsafe.AsPointer(ref this), pszExtension, cchExtension);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT SetReferent([NativeTypeName("PCSTR")] sbyte* pcszReferent, HWND hwnd);
        [VtblIndex(4)]
        HRESULT GetReferent([NativeTypeName("PSTR")] sbyte* pszReferent, int cchReferent);
        [VtblIndex(5)]
        HRESULT SetFolder([NativeTypeName("PCSTR")] sbyte* pcszFolder);
        [VtblIndex(6)]
        HRESULT GetFolder([NativeTypeName("PSTR")] sbyte* pszFolder, int cchFolder);
        [VtblIndex(7)]
        HRESULT GetName([NativeTypeName("PSTR")] sbyte* pszName, int cchName);
        [VtblIndex(8)]
        HRESULT GetExtension([NativeTypeName("PSTR")] sbyte* pszExtension, int cchExtension);
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
        [NativeTypeName("HRESULT (PCSTR, HWND) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, HWND, int> SetReferent;
        [NativeTypeName("HRESULT (PSTR, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int, int> GetReferent;
        [NativeTypeName("HRESULT (PCSTR) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int> SetFolder;
        [NativeTypeName("HRESULT (PSTR, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int, int> GetFolder;
        [NativeTypeName("HRESULT (PSTR, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int, int> GetName;
        [NativeTypeName("HRESULT (PSTR, int) __attribute__((nothrow)) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int, int> GetExtension;
    }
}