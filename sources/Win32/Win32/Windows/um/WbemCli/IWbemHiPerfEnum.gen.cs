// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WbemCli.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("2705C288-79AE-11D2-B348-00105A1F8177")]
[NativeTypeName("struct IWbemHiPerfEnum : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IWbemHiPerfEnum : IWbemHiPerfEnum.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IWbemHiPerfEnum));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IWbemHiPerfEnum, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IWbemHiPerfEnum, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IWbemHiPerfEnum, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT AddObjects(
        [NativeTypeName("long")] int lFlags,
        [NativeTypeName("ULONG")] uint uNumObjects,
        [NativeTypeName("long *")] int* apIds,
        IWbemObjectAccess* apObj
    )
    {
        return (
            (delegate* unmanaged<IWbemHiPerfEnum, int, uint, int*, IWbemObjectAccess*, int>)(
                (*lpVtbl)[3]
            )
        )(this, lFlags, uNumObjects, apIds, apObj);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT RemoveObjects(
        [NativeTypeName("long")] int lFlags,
        [NativeTypeName("ULONG")] uint uNumObjects,
        [NativeTypeName("long *")] int* apIds
    )
    {
        return ((delegate* unmanaged<IWbemHiPerfEnum, int, uint, int*, int>)((*lpVtbl)[4]))(
            this,
            lFlags,
            uNumObjects,
            apIds
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetObjects(
        [NativeTypeName("long")] int lFlags,
        [NativeTypeName("ULONG")] uint uNumObjects,
        IWbemObjectAccess* apObj,
        [NativeTypeName("ULONG *")] uint* puReturned
    )
    {
        return (
            (delegate* unmanaged<IWbemHiPerfEnum, int, uint, IWbemObjectAccess*, uint*, int>)(
                (*lpVtbl)[5]
            )
        )(this, lFlags, uNumObjects, apObj, puReturned);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT RemoveAll([NativeTypeName("long")] int lFlags)
    {
        return ((delegate* unmanaged<IWbemHiPerfEnum, int, int>)((*lpVtbl)[6]))(this, lFlags);
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT AddObjects(
            [NativeTypeName("long")] int lFlags,
            [NativeTypeName("ULONG")] uint uNumObjects,
            [NativeTypeName("long *")] int* apIds,
            IWbemObjectAccess* apObj
        );

        [VtblIndex(4)]
        HRESULT RemoveObjects(
            [NativeTypeName("long")] int lFlags,
            [NativeTypeName("ULONG")] uint uNumObjects,
            [NativeTypeName("long *")] int* apIds
        );

        [VtblIndex(5)]
        HRESULT GetObjects(
            [NativeTypeName("long")] int lFlags,
            [NativeTypeName("ULONG")] uint uNumObjects,
            IWbemObjectAccess* apObj,
            [NativeTypeName("ULONG *")] uint* puReturned
        );

        [VtblIndex(6)]
        HRESULT RemoveAll([NativeTypeName("long")] int lFlags);
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
            "HRESULT (long, ULONG, long *, IWbemObjectAccess **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, uint, int*, IWbemObjectAccess*, int> AddObjects;

        [NativeTypeName("HRESULT (long, ULONG, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, uint, int*, int> RemoveObjects;

        [NativeTypeName(
            "HRESULT (long, ULONG, IWbemObjectAccess **, ULONG *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, int, uint, IWbemObjectAccess*, uint*, int> GetObjects;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> RemoveAll;
    }

    /// <summary>Initializes a new instance of the <see cref = "IWbemHiPerfEnum"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IWbemHiPerfEnum(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IWbemHiPerfEnum"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IWbemHiPerfEnum(Silk.NET.Windows.IUnknown value)
    {
        return new IWbemHiPerfEnum(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IWbemHiPerfEnum"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IWbemHiPerfEnum"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IWbemHiPerfEnum value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
