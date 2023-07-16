// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;
/// <include file='ISpShortcut.xml' path='doc/member[@name="ISpShortcut"]/*'/>
[Guid("3DF681E2-EA56-11D9-8BDE-F66BAD1E3F3A")]
[NativeTypeName("struct ISpShortcut : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct ISpShortcut : ISpShortcut.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpShortcut));

    public void** lpVtbl;
    /// <inheritdoc cref = "IUnknown.QueryInterface"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpShortcut*, Guid*, void**, int> )(lpVtbl[0]))((ISpShortcut*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref = "IUnknown.AddRef"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ISpShortcut*, uint> )(lpVtbl[1]))((ISpShortcut*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref = "IUnknown.Release"/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpShortcut*, uint> )(lpVtbl[2]))((ISpShortcut*)Unsafe.AsPointer(ref this));
    }

    /// <include file='ISpShortcut.xml' path='doc/member[@name="ISpShortcut.AddShortcut"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddShortcut([NativeTypeName("LPCWSTR")] ushort* pszDisplay, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("LPCWSTR")] ushort* pszSpoken, SPSHORTCUTTYPE shType)
    {
        return ((delegate* unmanaged<ISpShortcut*, ushort*, ushort, ushort*, SPSHORTCUTTYPE, int> )(lpVtbl[3]))((ISpShortcut*)Unsafe.AsPointer(ref this), pszDisplay, LangID, pszSpoken, shType);
    }

    /// <include file='ISpShortcut.xml' path='doc/member[@name="ISpShortcut.RemoveShortcut"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveShortcut([NativeTypeName("LPCWSTR")] ushort* pszDisplay, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("LPCWSTR")] ushort* pszSpoken, SPSHORTCUTTYPE shType)
    {
        return ((delegate* unmanaged<ISpShortcut*, ushort*, ushort, ushort*, SPSHORTCUTTYPE, int> )(lpVtbl[4]))((ISpShortcut*)Unsafe.AsPointer(ref this), pszDisplay, LangID, pszSpoken, shType);
    }

    /// <include file='ISpShortcut.xml' path='doc/member[@name="ISpShortcut.GetShortcuts"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetShortcuts([NativeTypeName("WORD")] ushort LangID, SPSHORTCUTPAIRLIST* pShortcutpairList)
    {
        return ((delegate* unmanaged<ISpShortcut*, ushort, SPSHORTCUTPAIRLIST*, int> )(lpVtbl[5]))((ISpShortcut*)Unsafe.AsPointer(ref this), LangID, pShortcutpairList);
    }

    /// <include file='ISpShortcut.xml' path='doc/member[@name="ISpShortcut.GetGeneration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration)
    {
        return ((delegate* unmanaged<ISpShortcut*, uint*, int> )(lpVtbl[6]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration);
    }

    /// <include file='ISpShortcut.xml' path='doc/member[@name="ISpShortcut.GetWordsFromGenerationChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetWordsFromGenerationChange([NativeTypeName("DWORD *")] uint* pdwGeneration, SPWORDLIST* pWordList)
    {
        return ((delegate* unmanaged<ISpShortcut*, uint*, SPWORDLIST*, int> )(lpVtbl[7]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration, pWordList);
    }

    /// <include file='ISpShortcut.xml' path='doc/member[@name="ISpShortcut.GetWords"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWords([NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, SPWORDLIST* pWordList)
    {
        return ((delegate* unmanaged<ISpShortcut*, uint*, uint*, SPWORDLIST*, int> )(lpVtbl[8]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration, pdwCookie, pWordList);
    }

    /// <include file='ISpShortcut.xml' path='doc/member[@name="ISpShortcut.GetShortcutsForGeneration"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetShortcutsForGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, SPSHORTCUTPAIRLIST* pShortcutpairList)
    {
        return ((delegate* unmanaged<ISpShortcut*, uint*, uint*, SPSHORTCUTPAIRLIST*, int> )(lpVtbl[9]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration, pdwCookie, pShortcutpairList);
    }

    /// <include file='ISpShortcut.xml' path='doc/member[@name="ISpShortcut.GetGenerationChange"]/*'/>
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetGenerationChange([NativeTypeName("DWORD *")] uint* pdwGeneration, SPSHORTCUTPAIRLIST* pShortcutpairList)
    {
        return ((delegate* unmanaged<ISpShortcut*, uint*, SPSHORTCUTPAIRLIST*, int> )(lpVtbl[10]))((ISpShortcut*)Unsafe.AsPointer(ref this), pdwGeneration, pShortcutpairList);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddShortcut([NativeTypeName("LPCWSTR")] ushort* pszDisplay, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("LPCWSTR")] ushort* pszSpoken, SPSHORTCUTTYPE shType);
        [VtblIndex(4)]
        HRESULT RemoveShortcut([NativeTypeName("LPCWSTR")] ushort* pszDisplay, [NativeTypeName("WORD")] ushort LangID, [NativeTypeName("LPCWSTR")] ushort* pszSpoken, SPSHORTCUTTYPE shType);
        [VtblIndex(5)]
        HRESULT GetShortcuts([NativeTypeName("WORD")] ushort LangID, SPSHORTCUTPAIRLIST* pShortcutpairList);
        [VtblIndex(6)]
        HRESULT GetGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration);
        [VtblIndex(7)]
        HRESULT GetWordsFromGenerationChange([NativeTypeName("DWORD *")] uint* pdwGeneration, SPWORDLIST* pWordList);
        [VtblIndex(8)]
        HRESULT GetWords([NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, SPWORDLIST* pWordList);
        [VtblIndex(9)]
        HRESULT GetShortcutsForGeneration([NativeTypeName("DWORD *")] uint* pdwGeneration, [NativeTypeName("DWORD *")] uint* pdwCookie, SPSHORTCUTPAIRLIST* pShortcutpairList);
        [VtblIndex(10)]
        HRESULT GetGenerationChange([NativeTypeName("DWORD *")] uint* pdwGeneration, SPSHORTCUTPAIRLIST* pShortcutpairList);
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
        [NativeTypeName("HRESULT (LPCWSTR, WORD, LPCWSTR, SPSHORTCUTTYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort, ushort*, SPSHORTCUTTYPE, int> AddShortcut;
        [NativeTypeName("HRESULT (LPCWSTR, WORD, LPCWSTR, SPSHORTCUTTYPE) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort, ushort*, SPSHORTCUTTYPE, int> RemoveShortcut;
        [NativeTypeName("HRESULT (WORD, SPSHORTCUTPAIRLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, SPSHORTCUTPAIRLIST*, int> GetShortcuts;
        [NativeTypeName("HRESULT (DWORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetGeneration;
        [NativeTypeName("HRESULT (DWORD *, SPWORDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, SPWORDLIST*, int> GetWordsFromGenerationChange;
        [NativeTypeName("HRESULT (DWORD *, DWORD *, SPWORDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, SPWORDLIST*, int> GetWords;
        [NativeTypeName("HRESULT (DWORD *, DWORD *, SPSHORTCUTPAIRLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, uint*, SPSHORTCUTPAIRLIST*, int> GetShortcutsForGeneration;
        [NativeTypeName("HRESULT (DWORD *, SPSHORTCUTPAIRLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, SPSHORTCUTPAIRLIST*, int> GetGenerationChange;
    }
}