// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/PropIdlBase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("00000138-0000-0000-C000-000000000046")]
[NativeTypeName("struct IPropertyStorage : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IPropertyStorage : IPropertyStorage.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IPropertyStorage));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IPropertyStorage, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IPropertyStorage, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IPropertyStorage, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT ReadMultiple(
        [NativeTypeName("ULONG")] uint cpspec,
        [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec,
        [NativeTypeName("PROPVARIANT[]")] PROPVARIANT* rgpropvar
    )
    {
        return (
            (delegate* unmanaged<IPropertyStorage, uint, PROPSPEC*, PROPVARIANT*, int>)(
                (*lpVtbl)[3]
            )
        )(this, cpspec, rgpspec, rgpropvar);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WriteMultiple(
        [NativeTypeName("ULONG")] uint cpspec,
        [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec,
        [NativeTypeName("const PROPVARIANT[]")] PROPVARIANT* rgpropvar,
        [NativeTypeName("PROPID")] uint propidNameFirst
    )
    {
        return (
            (delegate* unmanaged<IPropertyStorage, uint, PROPSPEC*, PROPVARIANT*, uint, int>)(
                (*lpVtbl)[4]
            )
        )(this, cpspec, rgpspec, rgpropvar, propidNameFirst);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT DeleteMultiple(
        [NativeTypeName("ULONG")] uint cpspec,
        [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec
    )
    {
        return ((delegate* unmanaged<IPropertyStorage, uint, PROPSPEC*, int>)((*lpVtbl)[5]))(
            this,
            cpspec,
            rgpspec
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT ReadPropertyNames(
        [NativeTypeName("ULONG")] uint cpropid,
        [NativeTypeName("const PROPID[]")] uint* rgpropid,
        [NativeTypeName("LPOLESTR[]")] ushort** rglpwstrName
    )
    {
        return ((delegate* unmanaged<IPropertyStorage, uint, uint*, ushort**, int>)((*lpVtbl)[6]))(
            this,
            cpropid,
            rgpropid,
            rglpwstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT WritePropertyNames(
        [NativeTypeName("ULONG")] uint cpropid,
        [NativeTypeName("const PROPID[]")] uint* rgpropid,
        [NativeTypeName("const LPOLESTR[]")] ushort** rglpwstrName
    )
    {
        return ((delegate* unmanaged<IPropertyStorage, uint, uint*, ushort**, int>)((*lpVtbl)[7]))(
            this,
            cpropid,
            rgpropid,
            rglpwstrName
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT DeletePropertyNames(
        [NativeTypeName("ULONG")] uint cpropid,
        [NativeTypeName("const PROPID[]")] uint* rgpropid
    )
    {
        return ((delegate* unmanaged<IPropertyStorage, uint, uint*, int>)((*lpVtbl)[8]))(
            this,
            cpropid,
            rgpropid
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags)
    {
        return ((delegate* unmanaged<IPropertyStorage, uint, int>)((*lpVtbl)[9]))(
            this,
            grfCommitFlags
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT Revert()
    {
        return ((delegate* unmanaged<IPropertyStorage, int>)((*lpVtbl)[10]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT Enum(IEnumSTATPROPSTG* ppenum)
    {
        return ((delegate* unmanaged<IPropertyStorage, IEnumSTATPROPSTG*, int>)((*lpVtbl)[11]))(
            this,
            ppenum
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT SetTimes(
        [NativeTypeName("const FILETIME *")] FILETIME* pctime,
        [NativeTypeName("const FILETIME *")] FILETIME* patime,
        [NativeTypeName("const FILETIME *")] FILETIME* pmtime
    )
    {
        return (
            (delegate* unmanaged<IPropertyStorage, FILETIME*, FILETIME*, FILETIME*, int>)(
                (*lpVtbl)[12]
            )
        )(this, pctime, patime, pmtime);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT SetClass([NativeTypeName("const IID &")] Guid* clsid)
    {
        return ((delegate* unmanaged<IPropertyStorage, Guid*, int>)((*lpVtbl)[13]))(this, clsid);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Stat(STATPROPSETSTG* pstatpsstg)
    {
        return ((delegate* unmanaged<IPropertyStorage, STATPROPSETSTG*, int>)((*lpVtbl)[14]))(
            this,
            pstatpsstg
        );
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT ReadMultiple(
            [NativeTypeName("ULONG")] uint cpspec,
            [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec,
            [NativeTypeName("PROPVARIANT[]")] PROPVARIANT* rgpropvar
        );

        [VtblIndex(4)]
        HRESULT WriteMultiple(
            [NativeTypeName("ULONG")] uint cpspec,
            [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec,
            [NativeTypeName("const PROPVARIANT[]")] PROPVARIANT* rgpropvar,
            [NativeTypeName("PROPID")] uint propidNameFirst
        );

        [VtblIndex(5)]
        HRESULT DeleteMultiple(
            [NativeTypeName("ULONG")] uint cpspec,
            [NativeTypeName("const PROPSPEC[]")] PROPSPEC* rgpspec
        );

        [VtblIndex(6)]
        HRESULT ReadPropertyNames(
            [NativeTypeName("ULONG")] uint cpropid,
            [NativeTypeName("const PROPID[]")] uint* rgpropid,
            [NativeTypeName("LPOLESTR[]")] ushort** rglpwstrName
        );

        [VtblIndex(7)]
        HRESULT WritePropertyNames(
            [NativeTypeName("ULONG")] uint cpropid,
            [NativeTypeName("const PROPID[]")] uint* rgpropid,
            [NativeTypeName("const LPOLESTR[]")] ushort** rglpwstrName
        );

        [VtblIndex(8)]
        HRESULT DeletePropertyNames(
            [NativeTypeName("ULONG")] uint cpropid,
            [NativeTypeName("const PROPID[]")] uint* rgpropid
        );

        [VtblIndex(9)]
        HRESULT Commit([NativeTypeName("DWORD")] uint grfCommitFlags);

        [VtblIndex(10)]
        HRESULT Revert();

        [VtblIndex(11)]
        HRESULT Enum(IEnumSTATPROPSTG* ppenum);

        [VtblIndex(12)]
        HRESULT SetTimes(
            [NativeTypeName("const FILETIME *")] FILETIME* pctime,
            [NativeTypeName("const FILETIME *")] FILETIME* patime,
            [NativeTypeName("const FILETIME *")] FILETIME* pmtime
        );

        [VtblIndex(13)]
        HRESULT SetClass([NativeTypeName("const IID &")] Guid* clsid);

        [VtblIndex(14)]
        HRESULT Stat(STATPROPSETSTG* pstatpsstg);
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
            "HRESULT (ULONG, const PROPSPEC *, PROPVARIANT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, PROPSPEC*, PROPVARIANT*, int> ReadMultiple;

        [NativeTypeName(
            "HRESULT (ULONG, const PROPSPEC *, const PROPVARIANT *, PROPID) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, PROPSPEC*, PROPVARIANT*, uint, int> WriteMultiple;

        [NativeTypeName("HRESULT (ULONG, const PROPSPEC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, PROPSPEC*, int> DeleteMultiple;

        [NativeTypeName("HRESULT (ULONG, const PROPID *, LPOLESTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, ushort**, int> ReadPropertyNames;

        [NativeTypeName(
            "HRESULT (ULONG, const PROPID *, const LPOLESTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, uint, uint*, ushort**, int> WritePropertyNames;

        [NativeTypeName("HRESULT (ULONG, const PROPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint*, int> DeletePropertyNames;

        [NativeTypeName("HRESULT (DWORD) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, int> Commit;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Revert;

        [NativeTypeName("HRESULT (IEnumSTATPROPSTG **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IEnumSTATPROPSTG*, int> Enum;

        [NativeTypeName(
            "HRESULT (const FILETIME *, const FILETIME *, const FILETIME *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, FILETIME*, FILETIME*, FILETIME*, int> SetTimes;

        [NativeTypeName("HRESULT (const IID &) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, int> SetClass;

        [NativeTypeName("HRESULT (STATPROPSETSTG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, STATPROPSETSTG*, int> Stat;
    }

    /// <summary>Initializes a new instance of the <see cref = "IPropertyStorage"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IPropertyStorage(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IPropertyStorage"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IPropertyStorage(Silk.NET.Windows.IUnknown value)
    {
        return new IPropertyStorage(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IPropertyStorage"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IPropertyStorage"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IPropertyStorage value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
