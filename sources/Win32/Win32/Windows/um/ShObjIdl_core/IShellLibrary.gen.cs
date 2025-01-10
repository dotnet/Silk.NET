// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("11A66EFA-382E-451A-9234-1E0E12EF3085")]
[NativeTypeName("struct IShellLibrary : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IShellLibrary : IShellLibrary.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IShellLibrary));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IShellLibrary, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IShellLibrary, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IShellLibrary, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT LoadLibraryFromItem(
        IShellItem psiLibrary,
        [NativeTypeName("DWORD")] uint grfMode
    )
    {
        return ((delegate* unmanaged<IShellLibrary, IShellItem, uint, int>)((*lpVtbl)[3]))(
            this,
            psiLibrary,
            grfMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT LoadLibraryFromKnownFolder(
        [NativeTypeName("const KNOWNFOLDERID &")] Guid* kfidLibrary,
        [NativeTypeName("DWORD")] uint grfMode
    )
    {
        return ((delegate* unmanaged<IShellLibrary, Guid*, uint, int>)((*lpVtbl)[4]))(
            this,
            kfidLibrary,
            grfMode
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT AddFolder(IShellItem psiLocation)
    {
        return ((delegate* unmanaged<IShellLibrary, IShellItem, int>)((*lpVtbl)[5]))(
            this,
            psiLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveFolder(IShellItem psiLocation)
    {
        return ((delegate* unmanaged<IShellLibrary, IShellItem, int>)((*lpVtbl)[6]))(
            this,
            psiLocation
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT GetFolders(
        LIBRARYFOLDERFILTER lff,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IShellLibrary, LIBRARYFOLDERFILTER, Guid*, void**, int>)(
                (*lpVtbl)[7]
            )
        )(this, lff, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT ResolveFolder(
        IShellItem psiFolderToResolve,
        [NativeTypeName("DWORD")] uint dwTimeout,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IShellLibrary, IShellItem, uint, Guid*, void**, int>)((*lpVtbl)[8])
        )(this, psiFolderToResolve, dwTimeout, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetDefaultSaveFolder(
        DEFAULTSAVEFOLDERTYPE dsft,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    )
    {
        return (
            (delegate* unmanaged<IShellLibrary, DEFAULTSAVEFOLDERTYPE, Guid*, void**, int>)(
                (*lpVtbl)[9]
            )
        )(this, dsft, riid, ppv);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT SetDefaultSaveFolder(DEFAULTSAVEFOLDERTYPE dsft, IShellItem psi)
    {
        return (
            (delegate* unmanaged<IShellLibrary, DEFAULTSAVEFOLDERTYPE, IShellItem, int>)(
                (*lpVtbl)[10]
            )
        )(this, dsft, psi);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetOptions(LIBRARYOPTIONFLAGS* plofOptions)
    {
        return ((delegate* unmanaged<IShellLibrary, LIBRARYOPTIONFLAGS*, int>)((*lpVtbl)[11]))(
            this,
            plofOptions
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetOptions(LIBRARYOPTIONFLAGS lofMask, LIBRARYOPTIONFLAGS lofOptions)
    {
        return (
            (delegate* unmanaged<IShellLibrary, LIBRARYOPTIONFLAGS, LIBRARYOPTIONFLAGS, int>)(
                (*lpVtbl)[12]
            )
        )(this, lofMask, lofOptions);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT GetFolderType([NativeTypeName("FOLDERTYPEID *")] Guid* pftid)
    {
        return ((delegate* unmanaged<IShellLibrary, Guid*, int>)((*lpVtbl)[13]))(this, pftid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetFolderType([NativeTypeName("const FOLDERTYPEID &")] Guid* ftid)
    {
        return ((delegate* unmanaged<IShellLibrary, Guid*, int>)((*lpVtbl)[14]))(this, ftid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetIcon([NativeTypeName("LPWSTR *")] ushort** ppszIcon)
    {
        return ((delegate* unmanaged<IShellLibrary, ushort**, int>)((*lpVtbl)[15]))(this, ppszIcon);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetIcon([NativeTypeName("LPCWSTR")] ushort* pszIcon)
    {
        return ((delegate* unmanaged<IShellLibrary, ushort*, int>)((*lpVtbl)[16]))(this, pszIcon);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Commit()
    {
        return ((delegate* unmanaged<IShellLibrary, int>)((*lpVtbl)[17]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT Save(
        IShellItem psiFolderToSaveIn,
        [NativeTypeName("LPCWSTR")] ushort* pszLibraryName,
        LIBRARYSAVEFLAGS lsf,
        IShellItem* ppsiSavedTo
    )
    {
        return (
            (delegate* unmanaged<
                IShellLibrary,
                IShellItem,
                ushort*,
                LIBRARYSAVEFLAGS,
                IShellItem*,
                int>)((*lpVtbl)[18])
        )(this, psiFolderToSaveIn, pszLibraryName, lsf, ppsiSavedTo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT SaveInKnownFolder(
        [NativeTypeName("const KNOWNFOLDERID &")] Guid* kfidToSaveIn,
        [NativeTypeName("LPCWSTR")] ushort* pszLibraryName,
        LIBRARYSAVEFLAGS lsf,
        IShellItem* ppsiSavedTo
    )
    {
        return (
            (delegate* unmanaged<
                IShellLibrary,
                Guid*,
                ushort*,
                LIBRARYSAVEFLAGS,
                IShellItem*,
                int>)((*lpVtbl)[19])
        )(this, kfidToSaveIn, pszLibraryName, lsf, ppsiSavedTo);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT LoadLibraryFromItem(IShellItem psiLibrary, [NativeTypeName("DWORD")] uint grfMode);

        [VtblIndex(4)]
        HRESULT LoadLibraryFromKnownFolder(
            [NativeTypeName("const KNOWNFOLDERID &")] Guid* kfidLibrary,
            [NativeTypeName("DWORD")] uint grfMode
        );

        [VtblIndex(5)]
        HRESULT AddFolder(IShellItem psiLocation);

        [VtblIndex(6)]
        HRESULT RemoveFolder(IShellItem psiLocation);

        [VtblIndex(7)]
        HRESULT GetFolders(
            LIBRARYFOLDERFILTER lff,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(8)]
        HRESULT ResolveFolder(
            IShellItem psiFolderToResolve,
            [NativeTypeName("DWORD")] uint dwTimeout,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(9)]
        HRESULT GetDefaultSaveFolder(
            DEFAULTSAVEFOLDERTYPE dsft,
            [NativeTypeName("const IID &")] Guid* riid,
            void** ppv
        );

        [VtblIndex(10)]
        HRESULT SetDefaultSaveFolder(DEFAULTSAVEFOLDERTYPE dsft, IShellItem psi);

        [VtblIndex(11)]
        HRESULT GetOptions(LIBRARYOPTIONFLAGS* plofOptions);

        [VtblIndex(12)]
        HRESULT SetOptions(LIBRARYOPTIONFLAGS lofMask, LIBRARYOPTIONFLAGS lofOptions);

        [VtblIndex(13)]
        HRESULT GetFolderType([NativeTypeName("FOLDERTYPEID *")] Guid* pftid);

        [VtblIndex(14)]
        HRESULT SetFolderType([NativeTypeName("const FOLDERTYPEID &")] Guid* ftid);

        [VtblIndex(15)]
        HRESULT GetIcon([NativeTypeName("LPWSTR *")] ushort** ppszIcon);

        [VtblIndex(16)]
        HRESULT SetIcon([NativeTypeName("LPCWSTR")] ushort* pszIcon);

        [VtblIndex(17)]
        HRESULT Commit();

        [VtblIndex(18)]
        HRESULT Save(
            IShellItem psiFolderToSaveIn,
            [NativeTypeName("LPCWSTR")] ushort* pszLibraryName,
            LIBRARYSAVEFLAGS lsf,
            IShellItem* ppsiSavedTo
        );

        [VtblIndex(19)]
        HRESULT SaveInKnownFolder(
            [NativeTypeName("const KNOWNFOLDERID &")] Guid* kfidToSaveIn,
            [NativeTypeName("LPCWSTR")] ushort* pszLibraryName,
            LIBRARYSAVEFLAGS lsf,
            IShellItem* ppsiSavedTo
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

        [NativeTypeName("HRESULT (IShellItem *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, uint, int> LoadLibraryFromItem;

        [NativeTypeName("HRESULT (const KNOWNFOLDERID &, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, int> LoadLibraryFromKnownFolder;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> AddFolder;

        [NativeTypeName("HRESULT (IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IShellItem, int> RemoveFolder;

        [NativeTypeName(
            "HRESULT (LIBRARYFOLDERFILTER, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, LIBRARYFOLDERFILTER, Guid*, void**, int> GetFolders;

        [NativeTypeName(
            "HRESULT (IShellItem *, DWORD, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, IShellItem, uint, Guid*, void**, int> ResolveFolder;

        [NativeTypeName(
            "HRESULT (DEFAULTSAVEFOLDERTYPE, const IID &, void **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            DEFAULTSAVEFOLDERTYPE,
            Guid*,
            void**,
            int> GetDefaultSaveFolder;

        [NativeTypeName("HRESULT (DEFAULTSAVEFOLDERTYPE, IShellItem *) __attribute__((stdcall))")]
        public delegate* unmanaged<
            TSelf*,
            DEFAULTSAVEFOLDERTYPE,
            IShellItem,
            int> SetDefaultSaveFolder;

        [NativeTypeName("HRESULT (LIBRARYOPTIONFLAGS *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, LIBRARYOPTIONFLAGS*, int> GetOptions;

        [NativeTypeName(
            "HRESULT (LIBRARYOPTIONFLAGS, LIBRARYOPTIONFLAGS) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, LIBRARYOPTIONFLAGS, LIBRARYOPTIONFLAGS, int> SetOptions;

        [NativeTypeName("HRESULT (FOLDERTYPEID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> GetFolderType;

        [NativeTypeName("HRESULT (const FOLDERTYPEID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetFolderType;

        [NativeTypeName("HRESULT (LPWSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> GetIcon;

        [NativeTypeName("HRESULT (LPCWSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> SetIcon;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Commit;

        [NativeTypeName(
            "HRESULT (IShellItem *, LPCWSTR, LIBRARYSAVEFLAGS, IShellItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IShellItem,
            ushort*,
            LIBRARYSAVEFLAGS,
            IShellItem*,
            int> Save;

        [NativeTypeName(
            "HRESULT (const KNOWNFOLDERID &, LPCWSTR, LIBRARYSAVEFLAGS, IShellItem **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            Guid*,
            ushort*,
            LIBRARYSAVEFLAGS,
            IShellItem*,
            int> SaveInKnownFolder;
    }

    /// <summary>Initializes a new instance of the <see cref = "IShellLibrary"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IShellLibrary(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IShellLibrary"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IShellLibrary(Silk.NET.Windows.IUnknown value)
    {
        return new IShellLibrary(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IShellLibrary"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IShellLibrary"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IShellLibrary value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
