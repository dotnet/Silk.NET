// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/control.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("BC9BCF80-DCD2-11D2-ABF6-00A0C905F375")]
[NativeTypeName("struct IAMStats : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IAMStats : IAMStats.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IAMStats));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IAMStats, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IAMStats, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IAMStats, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IAMStats, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return ((delegate* unmanaged<IAMStats, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4]))(
            this,
            iTInfo,
            lcid,
            ppTInfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    )
    {
        return (
            (delegate* unmanaged<IAMStats, Guid*, ushort**, uint, uint, int*, int>)((*lpVtbl)[5])
        )(this, riid, rgszNames, cNames, lcid, rgDispId);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        DISPPARAMS* pDispParams,
        VARIANT* pVarResult,
        EXCEPINFO* pExcepInfo,
        uint* puArgErr
    )
    {
        return (
            (delegate* unmanaged<
                IAMStats,
                int,
                Guid*,
                uint,
                ushort,
                DISPPARAMS*,
                VARIANT*,
                EXCEPINFO*,
                uint*,
                int>)((*lpVtbl)[6])
        )(this, dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT Reset()
    {
        return ((delegate* unmanaged<IAMStats, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_Count([NativeTypeName("LONG *")] int* plCount)
    {
        return ((delegate* unmanaged<IAMStats, int*, int>)((*lpVtbl)[8]))(this, plCount);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT GetValueByIndex(
        [NativeTypeName("long")] int lIndex,
        [NativeTypeName("BSTR *")] ushort** szName,
        [NativeTypeName("long *")] int* lCount,
        double* dLast,
        double* dAverage,
        double* dStdDev,
        double* dMin,
        double* dMax
    )
    {
        return (
            (delegate* unmanaged<
                IAMStats,
                int,
                ushort**,
                int*,
                double*,
                double*,
                double*,
                double*,
                double*,
                int>)((*lpVtbl)[9])
        )(this, lIndex, szName, lCount, dLast, dAverage, dStdDev, dMin, dMax);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetValueByName(
        [NativeTypeName("BSTR")] ushort* szName,
        [NativeTypeName("long *")] int* lIndex,
        [NativeTypeName("long *")] int* lCount,
        double* dLast,
        double* dAverage,
        double* dStdDev,
        double* dMin,
        double* dMax
    )
    {
        return (
            (delegate* unmanaged<
                IAMStats,
                ushort*,
                int*,
                int*,
                double*,
                double*,
                double*,
                double*,
                double*,
                int>)((*lpVtbl)[10])
        )(this, szName, lIndex, lCount, dLast, dAverage, dStdDev, dMin, dMax);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT GetIndex(
        [NativeTypeName("BSTR")] ushort* szName,
        [NativeTypeName("long")] int lCreate,
        [NativeTypeName("long *")] int* plIndex
    )
    {
        return ((delegate* unmanaged<IAMStats, ushort*, int, int*, int>)((*lpVtbl)[11]))(
            this,
            szName,
            lCreate,
            plIndex
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT AddValue([NativeTypeName("long")] int lIndex, double dValue)
    {
        return ((delegate* unmanaged<IAMStats, int, double, int>)((*lpVtbl)[12]))(
            this,
            lIndex,
            dValue
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT Reset();

        [VtblIndex(8)]
        HRESULT get_Count([NativeTypeName("LONG *")] int* plCount);

        [VtblIndex(9)]
        HRESULT GetValueByIndex(
            [NativeTypeName("long")] int lIndex,
            [NativeTypeName("BSTR *")] ushort** szName,
            [NativeTypeName("long *")] int* lCount,
            double* dLast,
            double* dAverage,
            double* dStdDev,
            double* dMin,
            double* dMax
        );

        [VtblIndex(10)]
        HRESULT GetValueByName(
            [NativeTypeName("BSTR")] ushort* szName,
            [NativeTypeName("long *")] int* lIndex,
            [NativeTypeName("long *")] int* lCount,
            double* dLast,
            double* dAverage,
            double* dStdDev,
            double* dMin,
            double* dMax
        );

        [VtblIndex(11)]
        HRESULT GetIndex(
            [NativeTypeName("BSTR")] ushort* szName,
            [NativeTypeName("long")] int lCreate,
            [NativeTypeName("long *")] int* plIndex
        );

        [VtblIndex(12)]
        HRESULT AddValue([NativeTypeName("long")] int lIndex, double dValue);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo*, int> GetTypeInfo;

        [NativeTypeName(
            "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName(
            "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            Guid*,
            uint,
            ushort,
            DISPPARAMS*,
            VARIANT*,
            EXCEPINFO*,
            uint*,
            int> Invoke;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> Reset;

        [NativeTypeName("HRESULT (LONG *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_Count;

        [NativeTypeName(
            "HRESULT (long, BSTR *, long *, double *, double *, double *, double *, double *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            ushort**,
            int*,
            double*,
            double*,
            double*,
            double*,
            double*,
            int> GetValueByIndex;

        [NativeTypeName(
            "HRESULT (BSTR, long *, long *, double *, double *, double *, double *, double *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            int*,
            int*,
            double*,
            double*,
            double*,
            double*,
            double*,
            int> GetValueByName;

        [NativeTypeName("HRESULT (BSTR, long, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int, int*, int> GetIndex;

        [NativeTypeName("HRESULT (long, double) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, double, int> AddValue;
    }

    /// <summary>Initializes a new instance of the <see cref = "IAMStats"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IAMStats(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IAMStats"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IAMStats(Silk.NET.Windows.IDispatch value)
    {
        return new IAMStats(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMStats"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IAMStats"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IAMStats value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IAMStats"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IAMStats(Silk.NET.Windows.IUnknown value)
    {
        return new IAMStats(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IAMStats"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IAMStats"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IAMStats value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
