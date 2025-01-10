// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("000214F9-0000-0000-C000-000000000046")]
[NativeTypeName("struct IShellLinkW : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellLinkW : IShellLinkW.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellLinkW));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellLinkW, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellLinkW, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellLinkW, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetPath(
        [NativeTypeName("LPWSTR")] ushort* pszFile,
        int cch,
        WIN32_FIND_DATAW* pfd,
        [NativeTypeName("DWORD")] uint fFlags
    )
    {
        return (
            (delegate* unmanaged<IShellLinkW, ushort*, int, WIN32_FIND_DATAW*, uint, int>)(
                (*lpVtbl)[3]
            )
        )(this, pszFile, cch, pfd, fFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl)
    {
        return ((delegate* unmanaged<IShellLinkW, ITEMIDLIST**, int>)((*lpVtbl)[4]))(this, ppidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl)
    {
        return ((delegate* unmanaged<IShellLinkW, ITEMIDLIST*, int>)((*lpVtbl)[5]))(this, pidl);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT GetDescription([NativeTypeName("LPWSTR")] ushort* pszName, int cch)
    {
        return ((delegate* unmanaged<IShellLinkW, ushort*, int, int>)((*lpVtbl)[6]))(
            this,
            pszName,
            cch
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT SetDescription([NativeTypeName("LPCWSTR")] ushort* pszName)
    {
        return ((delegate* unmanaged<IShellLinkW, ushort*, int>)((*lpVtbl)[7]))(this, pszName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT GetWorkingDirectory([NativeTypeName("LPWSTR")] ushort* pszDir, int cch)
    {
        return ((delegate* unmanaged<IShellLinkW, ushort*, int, int>)((*lpVtbl)[8]))(
            this,
            pszDir,
            cch
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT SetWorkingDirectory([NativeTypeName("LPCWSTR")] ushort* pszDir)
    {
        return ((delegate* unmanaged<IShellLinkW, ushort*, int>)((*lpVtbl)[9]))(this, pszDir);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetArguments([NativeTypeName("LPWSTR")] ushort* pszArgs, int cch)
    {
        return ((delegate* unmanaged<IShellLinkW, ushort*, int, int>)((*lpVtbl)[10]))(
            this,
            pszArgs,
            cch
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetArguments([NativeTypeName("LPCWSTR")] ushort* pszArgs)
    {
        return ((delegate* unmanaged<IShellLinkW, ushort*, int>)((*lpVtbl)[11]))(this, pszArgs);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetHotkey([NativeTypeName("WORD *")] ushort* pwHotkey)
    {
        return ((delegate* unmanaged<IShellLinkW, ushort*, int>)((*lpVtbl)[12]))(this, pwHotkey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetHotkey([NativeTypeName("WORD")] ushort wHotkey)
    {
        return ((delegate* unmanaged<IShellLinkW, ushort, int>)((*lpVtbl)[13]))(this, wHotkey);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT GetShowCmd(int* piShowCmd)
    {
        return ((delegate* unmanaged<IShellLinkW, int*, int>)((*lpVtbl)[14]))(this, piShowCmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetShowCmd(int iShowCmd)
    {
        return ((delegate* unmanaged<IShellLinkW, int, int>)((*lpVtbl)[15]))(this, iShowCmd);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT GetIconLocation(
        [NativeTypeName("LPWSTR")] ushort* pszIconPath,
        int cch,
        int* piIcon
    )
    {
        return ((delegate* unmanaged<IShellLinkW, ushort*, int, int*, int>)((*lpVtbl)[16]))(
            this,
            pszIconPath,
            cch,
            piIcon
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT SetIconLocation([NativeTypeName("LPCWSTR")] ushort* pszIconPath, int iIcon)
    {
        return ((delegate* unmanaged<IShellLinkW, ushort*, int, int>)((*lpVtbl)[17]))(
            this,
            pszIconPath,
            iIcon
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT SetRelativePath(
        [NativeTypeName("LPCWSTR")] ushort* pszPathRel,
        [NativeTypeName("DWORD")] uint dwReserved
    )
    {
        return ((delegate* unmanaged<IShellLinkW, ushort*, uint, int>)((*lpVtbl)[18]))(
            this,
            pszPathRel,
            dwReserved
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT Resolve(HWND hwnd, [NativeTypeName("DWORD")] uint fFlags)
    {
        return ((delegate* unmanaged<IShellLinkW, HWND, uint, int>)((*lpVtbl)[19]))(
            this,
            hwnd,
            fFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT SetPath([NativeTypeName("LPCWSTR")] ushort* pszFile)
    {
        return ((delegate* unmanaged<IShellLinkW, ushort*, int>)((*lpVtbl)[20]))(this, pszFile);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT GetPath(
            [NativeTypeName("LPWSTR")] ushort* pszFile,
            int cch,
            WIN32_FIND_DATAW* pfd,
            [NativeTypeName("DWORD")] uint fFlags
        );

        [VtblIndex(4)]
        HRESULT GetIDList([NativeTypeName("LPITEMIDLIST *")] ITEMIDLIST** ppidl);

        [VtblIndex(5)]
        HRESULT SetIDList([NativeTypeName("LPCITEMIDLIST")] ITEMIDLIST* pidl);

        [VtblIndex(6)]
        HRESULT GetDescription([NativeTypeName("LPWSTR")] ushort* pszName, int cch);

        [VtblIndex(7)]
        HRESULT SetDescription([NativeTypeName("LPCWSTR")] ushort* pszName);

        [VtblIndex(8)]
        HRESULT GetWorkingDirectory([NativeTypeName("LPWSTR")] ushort* pszDir, int cch);

        [VtblIndex(9)]
        HRESULT SetWorkingDirectory([NativeTypeName("LPCWSTR")] ushort* pszDir);

        [VtblIndex(10)]
        HRESULT GetArguments([NativeTypeName("LPWSTR")] ushort* pszArgs, int cch);

        [VtblIndex(11)]
        HRESULT SetArguments([NativeTypeName("LPCWSTR")] ushort* pszArgs);

        [VtblIndex(12)]
        HRESULT GetHotkey([NativeTypeName("WORD *")] ushort* pwHotkey);

        [VtblIndex(13)]
        HRESULT SetHotkey([NativeTypeName("WORD")] ushort wHotkey);

        [VtblIndex(14)]
        HRESULT GetShowCmd(int* piShowCmd);

        [VtblIndex(15)]
        HRESULT SetShowCmd(int iShowCmd);

        [VtblIndex(16)]
        HRESULT GetIconLocation(
            [NativeTypeName("LPWSTR")] ushort* pszIconPath,
            int cch,
            int* piIcon
        );

        [VtblIndex(17)]
        HRESULT SetIconLocation([NativeTypeName("LPCWSTR")] ushort* pszIconPath, int iIcon);

        [VtblIndex(18)]
        HRESULT SetRelativePath(
            [NativeTypeName("LPCWSTR")] ushort* pszPathRel,
            [NativeTypeName("DWORD")] uint dwReserved
        );

        [VtblIndex(19)]
        HRESULT Resolve(HWND hwnd, [NativeTypeName("DWORD")] uint fFlags);

        [VtblIndex(20)]
        HRESULT SetPath([NativeTypeName("LPCWSTR")] ushort* pszFile);
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
            "HRESULT (LPWSTR, int, WIN32_FIND_DATAW *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, int, WIN32_FIND_DATAW*, uint, int> GetPath;

        [NativeTypeName("HRESULT (LPITEMIDLIST *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST**, int> GetIDList;

        [NativeTypeName("HRESULT (LPCITEMIDLIST) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ITEMIDLIST*, int> SetIDList;

        [NativeTypeName("HRESULT (LPWSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> GetDescription;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetDescription;

        [NativeTypeName("HRESULT (LPWSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> GetWorkingDirectory;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetWorkingDirectory;

        [NativeTypeName("HRESULT (LPWSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> GetArguments;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetArguments;

        [NativeTypeName("HRESULT (WORD *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> GetHotkey;

        [NativeTypeName("HRESULT (WORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort, int> SetHotkey;

        [NativeTypeName("HRESULT (int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> GetShowCmd;

        [NativeTypeName("HRESULT (int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> SetShowCmd;

        [NativeTypeName("HRESULT (LPWSTR, int, int *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, int> GetIconLocation;

        [NativeTypeName("HRESULT (LPCWSTR, int) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int> SetIconLocation;

        [NativeTypeName("HRESULT (LPCWSTR, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, uint, int> SetRelativePath;

        [NativeTypeName("HRESULT (HWND, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, HWND, uint, int> Resolve;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetPath;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellLinkW"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellLinkW(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellLinkW"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellLinkW(Silk.NET.Windows.IUnknown value)
    {
        return new IShellLinkW(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellLinkW"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellLinkW"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellLinkW value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
