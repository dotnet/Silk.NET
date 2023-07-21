// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows;

/// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA"]/*' />
[Guid("000214EE-0000-0000-C000-000000000046")]
[NativeTypeName("struct IShellLinkA : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellLinkA : IShellLinkA.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellLinkA));

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellLinkA*, Guid*, void**, int>)(lpVtbl[0]))((IShellLinkA*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IShellLinkA*, uint>)(lpVtbl[1]))((IShellLinkA*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellLinkA*, uint>)(lpVtbl[2]))((IShellLinkA*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.GetPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPath([NativeTypeName("LPSTR")] sbyte* pszFile, int cch, WIN32_FIND_DATAA* pfd, [NativeTypeName("DWORD")] uint fFlags)
    {
        return ((delegate* unmanaged<IShellLinkA*, sbyte*, int, WIN32_FIND_DATAA*, uint, int>)(lpVtbl[3]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszFile, cch, pfd, fFlags);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.GetIDList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<IShellLinkA*, ITEMIDLIST**, int>)(lpVtbl[4]))((IShellLinkA*)Unsafe.AsPointer(ref this), ppidl);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.SetIDList"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<IShellLinkA*, ITEMIDLIST*, int>)(lpVtbl[5]))((IShellLinkA*)Unsafe.AsPointer(ref this), pidl);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.GetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDescription([NativeTypeName("LPSTR")] sbyte* pszName, int cch)
    {
        return ((delegate* unmanaged<IShellLinkA*, sbyte*, int, int>)(lpVtbl[6]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszName, cch);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.SetDescription"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDescription([NativeTypeName("LPCSTR")] sbyte* pszName)
    {
        return ((delegate* unmanaged<IShellLinkA*, sbyte*, int>)(lpVtbl[7]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszName);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.GetWorkingDirectory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWorkingDirectory([NativeTypeName("LPSTR")] sbyte* pszDir, int cch)
    {
        return ((delegate* unmanaged<IShellLinkA*, sbyte*, int, int>)(lpVtbl[8]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszDir, cch);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.SetWorkingDirectory"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetWorkingDirectory([NativeTypeName("LPCSTR")] sbyte* pszDir)
    {
        return ((delegate* unmanaged<IShellLinkA*, sbyte*, int>)(lpVtbl[9]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszDir);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.GetArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetArguments([NativeTypeName("LPSTR")] sbyte* pszArgs, int cch)
    {
        return ((delegate* unmanaged<IShellLinkA*, sbyte*, int, int>)(lpVtbl[10]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszArgs, cch);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.SetArguments"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetArguments([NativeTypeName("LPCSTR")] sbyte* pszArgs)
    {
        return ((delegate* unmanaged<IShellLinkA*, sbyte*, int>)(lpVtbl[11]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszArgs);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.GetHotkey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetHotkey([NativeTypeName("WORD *")] ushort* pwHotkey)
    {
        return ((delegate* unmanaged<IShellLinkA*, ushort*, int>)(lpVtbl[12]))((IShellLinkA*)Unsafe.AsPointer(ref this), pwHotkey);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.SetHotkey"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetHotkey([NativeTypeName("WORD")] ushort wHotkey)
    {
        return ((delegate* unmanaged<IShellLinkA*, ushort, int>)(lpVtbl[13]))((IShellLinkA*)Unsafe.AsPointer(ref this), wHotkey);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.GetShowCmd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetShowCmd(int* piShowCmd)
    {
        return ((delegate* unmanaged<IShellLinkA*, int*, int>)(lpVtbl[14]))((IShellLinkA*)Unsafe.AsPointer(ref this), piShowCmd);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.SetShowCmd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetShowCmd(int iShowCmd)
    {
        return ((delegate* unmanaged<IShellLinkA*, int, int>)(lpVtbl[15]))((IShellLinkA*)Unsafe.AsPointer(ref this), iShowCmd);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.GetIconLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetIconLocation([NativeTypeName("LPSTR")] sbyte* pszIconPath, int cch, int* piIcon)
    {
        return ((delegate* unmanaged<IShellLinkA*, sbyte*, int, int*, int>)(lpVtbl[16]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszIconPath, cch, piIcon);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.SetIconLocation"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetIconLocation([NativeTypeName("LPCSTR")] sbyte* pszIconPath, int iIcon)
    {
        return ((delegate* unmanaged<IShellLinkA*, sbyte*, int, int>)(lpVtbl[17]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszIconPath, iIcon);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.SetRelativePath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetRelativePath([NativeTypeName("LPCSTR")] sbyte* pszPathRel, [NativeTypeName("DWORD")] uint dwReserved)
    {
        return ((delegate* unmanaged<IShellLinkA*, sbyte*, uint, int>)(lpVtbl[18]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszPathRel, dwReserved);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.Resolve"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Resolve(HWND hwnd, [NativeTypeName("DWORD")] uint fFlags)
    {
        return ((delegate* unmanaged<IShellLinkA*, HWND, uint, int>)(lpVtbl[19]))((IShellLinkA*)Unsafe.AsPointer(ref this), hwnd, fFlags);
    }

    /// <include file='IShellLinkA.xml' path='doc/member[@name="IShellLinkA.SetPath"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetPath([NativeTypeName("LPCSTR")] sbyte* pszFile)
    {
        return ((delegate* unmanaged<IShellLinkA*, sbyte*, int>)(lpVtbl[20]))((IShellLinkA*)Unsafe.AsPointer(ref this), pszFile);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPath([NativeTypeName("LPSTR")] sbyte* pszFile, int cch, WIN32_FIND_DATAA* pfd, [NativeTypeName("DWORD")] uint fFlags);

        [VtblIndex(4)]
        HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);

        [VtblIndex(5)]
        HRESULT SetIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

        [VtblIndex(6)]
        HRESULT GetDescription([NativeTypeName("LPSTR")] sbyte* pszName, int cch);

        [VtblIndex(7)]
        HRESULT SetDescription([NativeTypeName("LPCSTR")] sbyte* pszName);

        [VtblIndex(8)]
        HRESULT GetWorkingDirectory([NativeTypeName("LPSTR")] sbyte* pszDir, int cch);

        [VtblIndex(9)]
        HRESULT SetWorkingDirectory([NativeTypeName("LPCSTR")] sbyte* pszDir);

        [VtblIndex(10)]
        HRESULT GetArguments([NativeTypeName("LPSTR")] sbyte* pszArgs, int cch);

        [VtblIndex(11)]
        HRESULT SetArguments([NativeTypeName("LPCSTR")] sbyte* pszArgs);

        [VtblIndex(12)]
        HRESULT GetHotkey([NativeTypeName("WORD *")] ushort* pwHotkey);

        [VtblIndex(13)]
        HRESULT SetHotkey([NativeTypeName("WORD")] ushort wHotkey);

        [VtblIndex(14)]
        HRESULT GetShowCmd(int* piShowCmd);

        [VtblIndex(15)]
        HRESULT SetShowCmd(int iShowCmd);

        [VtblIndex(16)]
        HRESULT GetIconLocation([NativeTypeName("LPSTR")] sbyte* pszIconPath, int cch, int* piIcon);

        [VtblIndex(17)]
        HRESULT SetIconLocation([NativeTypeName("LPCSTR")] sbyte* pszIconPath, int iIcon);

        [VtblIndex(18)]
        HRESULT SetRelativePath([NativeTypeName("LPCSTR")] sbyte* pszPathRel, [NativeTypeName("DWORD")] uint dwReserved);

        [VtblIndex(19)]
        HRESULT Resolve(HWND hwnd, [NativeTypeName("DWORD")] uint fFlags);

        [VtblIndex(20)]
        HRESULT SetPath([NativeTypeName("LPCSTR")] sbyte* pszFile);
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

        [NativeTypeName("HRESULT (LPSTR, int, WIN32_FIND_DATAA *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int, WIN32_FIND_DATAA*, uint, int> GetPath;

        [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST**, int> GetIDList;

        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> SetIDList;

        [NativeTypeName("HRESULT (LPSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int, int> GetDescription;

        [NativeTypeName("HRESULT (LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int> SetDescription;

        [NativeTypeName("HRESULT (LPSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int, int> GetWorkingDirectory;

        [NativeTypeName("HRESULT (LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int> SetWorkingDirectory;

        [NativeTypeName("HRESULT (LPSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int, int> GetArguments;

        [NativeTypeName("HRESULT (LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int> SetArguments;

        [NativeTypeName("HRESULT (WORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetHotkey;

        [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> SetHotkey;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetShowCmd;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetShowCmd;

        [NativeTypeName("HRESULT (LPSTR, int, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int, int*, int> GetIconLocation;

        [NativeTypeName("HRESULT (LPCSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int, int> SetIconLocation;

        [NativeTypeName("HRESULT (LPCSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, uint, int> SetRelativePath;

        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> Resolve;

        [NativeTypeName("HRESULT (LPCSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, sbyte*, int> SetPath;
    }
}
