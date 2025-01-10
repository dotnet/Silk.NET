// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("0000000B-0000-0000-C000-000000000046")]
[NativeTypeName("struct IStorage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IStorage : IStorage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IStorage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IStorage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IStorage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IStorage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT CreateStream(
        [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("DWORD")] uint reserved1,
        [NativeTypeName("DWORD")] uint reserved2,
        IStream* ppstm
    )
    {
        return (
            (delegate* unmanaged<IStorage, ushort*, uint, uint, uint, IStream*, int>)((*lpVtbl)[3])
        )(this, pwcsName, grfMode, reserved1, reserved2, ppstm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT OpenStream(
        [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
        void* reserved1,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("DWORD")] uint reserved2,
        IStream* ppstm
    )
    {
        return (
            (delegate* unmanaged<IStorage, ushort*, void*, uint, uint, IStream*, int>)((*lpVtbl)[4])
        )(this, pwcsName, reserved1, grfMode, reserved2, ppstm);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT CreateStorage(
        [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("DWORD")] uint reserved1,
        [NativeTypeName("DWORD")] uint reserved2,
        IStorage* ppstg
    )
    {
        return (
            (delegate* unmanaged<IStorage, ushort*, uint, uint, uint, IStorage*, int>)((*lpVtbl)[5])
        )(this, pwcsName, grfMode, reserved1, reserved2, ppstg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT OpenStorage(
        [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
        IStorage pstgPriority,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("SNB")] ushort** snbExclude,
        [NativeTypeName("DWORD")] uint reserved,
        IStorage* ppstg
    )
    {
        return (
            (delegate* unmanaged<
                IStorage,
                ushort*,
                IStorage,
                uint,
                ushort**,
                uint,
                IStorage*,
                int>)((*lpVtbl)[6])
        )(this, pwcsName, pstgPriority, grfMode, snbExclude, reserved, ppstg);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT CopyTo(
        [NativeTypeName("DWORD")] uint ciidExclude,
        [NativeTypeName("const IID *")] Guid* rgiidExclude,
        [NativeTypeName("SNB")] ushort** snbExclude,
        IStorage pstgDest
    )
    {
        return (
            (delegate* unmanaged<IStorage, uint, Guid*, ushort**, IStorage, int>)((*lpVtbl)[7])
        )(this, ciidExclude, rgiidExclude, snbExclude, pstgDest);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT MoveElementTo(
        [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
        IStorage pstgDest,
        [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName,
        [NativeTypeName("DWORD")] uint grfFlags
    )
    {
        return (
            (delegate* unmanaged<IStorage, ushort*, IStorage, ushort*, uint, int>)((*lpVtbl)[8])
        )(this, pwcsName, pstgDest, pwcsNewName, grfFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        return ((delegate* unmanaged<IStorage, uint, int>)((*lpVtbl)[9]))(this, grfCommitFlags);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged<IStorage, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT EnumElements(
        [NativeTypeName("DWORD")] uint reserved1,
        void* reserved2,
        [NativeTypeName("DWORD")] uint reserved3,
        IEnumSTATSTG* ppenum
    )
    {
        return (
            (delegate* unmanaged<IStorage, uint, void*, uint, IEnumSTATSTG*, int>)((*lpVtbl)[11])
        )(this, reserved1, reserved2, reserved3, ppenum);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT DestroyElement([NativeTypeName("const OLECHAR *")] ushort* pwcsName)
    {
        return ((delegate* unmanaged<IStorage, ushort*, int>)((*lpVtbl)[12]))(this, pwcsName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT RenameElement(
        [NativeTypeName("const OLECHAR *")] ushort* pwcsOldName,
        [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName
    )
    {
        return ((delegate* unmanaged<IStorage, ushort*, ushort*, int>)((*lpVtbl)[13]))(
            this,
            pwcsOldName,
            pwcsNewName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT SetElementTimes(
        [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
        [NativeTypeName("const FILETIME *")] FILETIME* pctime,
        [NativeTypeName("const FILETIME *")] FILETIME* patime,
        [NativeTypeName("const FILETIME *")] FILETIME* pmtime
    )
    {
        return (
            (delegate* unmanaged<IStorage, ushort*, FILETIME*, FILETIME*, FILETIME*, int>)(
                (*lpVtbl)[14]
            )
        )(this, pwcsName, pctime, patime, pmtime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT SetClass([NativeTypeName("const IID &")] Guid* clsid)
    {
        return ((delegate* unmanaged<IStorage, Guid*, int>)((*lpVtbl)[15]))(this, clsid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT SetStateBits(
        [NativeTypeName("DWORD")] uint grfStateBits,
        [NativeTypeName("DWORD")] uint grfMask
    )
    {
        return ((delegate* unmanaged<IStorage, uint, uint, int>)((*lpVtbl)[16]))(
            this,
            grfStateBits,
            grfMask
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag)
    {
        return ((delegate* unmanaged<IStorage, STATSTG*, uint, int>)((*lpVtbl)[17]))(
            this,
            pstatstg,
            grfStatFlag
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT CreateStream(
            [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
            [NativeTypeName("DWORD")] uint grfMode,
            [NativeTypeName("DWORD")] uint reserved1,
            [NativeTypeName("DWORD")] uint reserved2,
            IStream* ppstm
        );

        [VtblIndex(4)]
        HRESULT OpenStream(
            [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
            void* reserved1,
            [NativeTypeName("DWORD")] uint grfMode,
            [NativeTypeName("DWORD")] uint reserved2,
            IStream* ppstm
        );

        [VtblIndex(5)]
        HRESULT CreateStorage(
            [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
            [NativeTypeName("DWORD")] uint grfMode,
            [NativeTypeName("DWORD")] uint reserved1,
            [NativeTypeName("DWORD")] uint reserved2,
            IStorage* ppstg
        );

        [VtblIndex(6)]
        HRESULT OpenStorage(
            [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
            IStorage pstgPriority,
            [NativeTypeName("DWORD")] uint grfMode,
            [NativeTypeName("SNB")] ushort** snbExclude,
            [NativeTypeName("DWORD")] uint reserved,
            IStorage* ppstg
        );

        [VtblIndex(7)]
        HRESULT CopyTo(
            [NativeTypeName("DWORD")] uint ciidExclude,
            [NativeTypeName("const IID *")] Guid* rgiidExclude,
            [NativeTypeName("SNB")] ushort** snbExclude,
            IStorage pstgDest
        );

        [VtblIndex(8)]
        HRESULT MoveElementTo(
            [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
            IStorage pstgDest,
            [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName,
            [NativeTypeName("DWORD")] uint grfFlags
        );

        [VtblIndex(9)]
        HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags);

        [VtblIndex(10)]
        HRESULT Revert();

        [VtblIndex(11)]
        HRESULT EnumElements(
            [NativeTypeName("DWORD")] uint reserved1,
            void* reserved2,
            [NativeTypeName("DWORD")] uint reserved3,
            IEnumSTATSTG* ppenum
        );

        [VtblIndex(12)]
        HRESULT DestroyElement([NativeTypeName("const OLECHAR *")] ushort* pwcsName);

        [VtblIndex(13)]
        HRESULT RenameElement(
            [NativeTypeName("const OLECHAR *")] ushort* pwcsOldName,
            [NativeTypeName("const OLECHAR *")] ushort* pwcsNewName
        );

        [VtblIndex(14)]
        HRESULT SetElementTimes(
            [NativeTypeName("const OLECHAR *")] ushort* pwcsName,
            [NativeTypeName("const FILETIME *")] FILETIME* pctime,
            [NativeTypeName("const FILETIME *")] FILETIME* patime,
            [NativeTypeName("const FILETIME *")] FILETIME* pmtime
        );

        [VtblIndex(15)]
        HRESULT SetClass([NativeTypeName("const IID &")] Guid* clsid);

        [VtblIndex(16)]
        HRESULT SetStateBits(
            [NativeTypeName("DWORD")] uint grfStateBits,
            [NativeTypeName("DWORD")] uint grfMask
        );

        [VtblIndex(17)]
        HRESULT Stat(STATSTG* pstatstg, [NativeTypeName("DWORD")] uint grfStatFlag);
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
            "HRESULT (const OLECHAR *, DWORD, DWORD, DWORD, IStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint, uint, IStream*, int> CreateStream;

        [NativeTypeName(
            "HRESULT (const OLECHAR *, void *, DWORD, DWORD, IStream **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, void*, uint, uint, IStream*, int> OpenStream;

        [NativeTypeName(
            "HRESULT (const OLECHAR *, DWORD, DWORD, DWORD, IStorage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, uint, uint, uint, IStorage*, int> CreateStorage;

        [NativeTypeName(
            "HRESULT (const OLECHAR *, IStorage *, DWORD, SNB, DWORD, IStorage **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            IStorage,
            uint,
            ushort**,
            uint,
            IStorage*,
            int> OpenStorage;

        [NativeTypeName("HRESULT (DWORD, const IID *, SNB, IStorage *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, Guid*, ushort**, IStorage, int> CopyTo;

        [NativeTypeName(
            "HRESULT (const OLECHAR *, IStorage *, const OLECHAR *, DWORD) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, IStorage, ushort*, uint, int> MoveElementTo;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Commit;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Revert;

        [NativeTypeName("HRESULT (DWORD, void *, DWORD, IEnumSTATSTG **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, void*, uint, IEnumSTATSTG*, int> EnumElements;

        [NativeTypeName("HRESULT (const OLECHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> DestroyElement;

        [NativeTypeName("HRESULT (const OLECHAR *, const OLECHAR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, int> RenameElement;

        [NativeTypeName(
            "HRESULT (const OLECHAR *, const FILETIME *, const FILETIME *, const FILETIME *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            FILETIME*,
            FILETIME*,
            FILETIME*,
            int> SetElementTimes;

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetClass;

        [NativeTypeName("HRESULT (DWORD, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, int> SetStateBits;

        [NativeTypeName("HRESULT (STATSTG *, DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, STATSTG*, uint, int> Stat;
    }

    /// <summary>Initializes a new instance of the <see cref = "IStorage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IStorage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IStorage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IStorage(Silk.NET.Windows.IUnknown value)
    {
        return new IStorage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IStorage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IStorage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IStorage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
