// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/minwinbase.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Intrinsics.X86;
using System.Runtime.Versioning;
using Silk.NET.DirectX;
using Silk.NET.Win32;
using Silk.NET.WinRT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Win32;

[Guid("A6EF9860-C720-11D0-9337-00A0C90DCAA9")]
[NativeTypeName("struct IDispatchEx : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDispatchEx : IDispatch.Interface, INativeGuid
{
    public Native* LpVtbl;
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDispatchEx));

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(10)]
        HResult DeleteMemberByDispID([NativeTypeName("DISPID")] int id);

        [VtblIndex(9)]
        HResult DeleteMemberByName(
            [NativeTypeName("BSTR")] ushort* bstrName,
            [NativeTypeName("DWORD")] uint grfdex
        );

        [VtblIndex(9)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult DeleteMemberByName(
            [NativeTypeName("BSTR")] Ref<ushort> bstrName,
            [NativeTypeName("DWORD")] uint grfdex
        );

        [VtblIndex(7)]
        HResult GetDispID(
            [NativeTypeName("BSTR")] ushort* bstrName,
            [NativeTypeName("DWORD")] uint grfdex,
            [NativeTypeName("DISPID *")] int* pid
        );

        [VtblIndex(7)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetDispID(
            [NativeTypeName("BSTR")] Ref<ushort> bstrName,
            [NativeTypeName("DWORD")] uint grfdex,
            [NativeTypeName("DISPID *")] Ref<int> pid
        );

        [VtblIndex(12)]
        HResult GetMemberName(
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("BSTR *")] ushort** pbstrName
        );

        [VtblIndex(12)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetMemberName(
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("BSTR *")] Ref2D<ushort> pbstrName
        );

        [VtblIndex(11)]
        HResult GetMemberProperties(
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("DWORD")] uint grfdexFetch,
            [NativeTypeName("DWORD *")] uint* pgrfdex
        );

        [VtblIndex(11)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetMemberProperties(
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("DWORD")] uint grfdexFetch,
            [NativeTypeName("DWORD *")] Ref<uint> pgrfdex
        );

        [VtblIndex(14)]
        HResult GetNameSpaceParent(IUnknown* ppunk);

        [VtblIndex(14)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetNameSpaceParent(Ref<IUnknown> ppunk);

        [VtblIndex(13)]
        HResult GetNextDispID(
            [NativeTypeName("DWORD")] uint grfdex,
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("DISPID *")] int* pid
        );

        [VtblIndex(13)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult GetNextDispID(
            [NativeTypeName("DWORD")] uint grfdex,
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("DISPID *")] Ref<int> pid
        );

        [VtblIndex(8)]
        HResult InvokeEx(
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("LCID")] uint lcid,
            [NativeTypeName("WORD")] ushort wFlags,
            Dispparams* pdp,
            Variant* pvarRes,
            Excepinfo* pei,
            IServiceProvider* pspCaller
        );

        [VtblIndex(8)]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        HResult InvokeEx(
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("LCID")] uint lcid,
            [NativeTypeName("WORD")] ushort wFlags,
            Ref<Dispparams> pdp,
            Ref<Variant> pvarRes,
            Ref<Excepinfo> pei,
            Ref<IServiceProvider> pspCaller
        );
    }

    [Guid("A6EF9860-C720-11D0-9337-00A0C90DCAA9")]
    [NativeTypeName("struct IDispatchEx : IDispatch")]
    [NativeInheritance("IDispatch")]
    public unsafe partial struct Native : IDispatch.Interface, INativeGuid
    {
        static Guid* INativeGuid.NativeGuid =>
            (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID.IDispatchEx));
        public void** lpVtbl;

        public partial struct Vtbl
        {
            [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, Guid*, void**, int> QueryInterface;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, uint> AddRef;

            [NativeTypeName("ULONG () __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, uint> Release;

            [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, uint*, int> GetTypeInfoCount;

            [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
            public delegate* unmanaged<
                IDispatchEx.Native*,
                uint,
                uint,
                ITypeInfo**,
                int> GetTypeInfo;

            [NativeTypeName(
                "HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                IDispatchEx.Native*,
                Guid*,
                ushort**,
                uint,
                uint,
                int*,
                int> GetIDsOfNames;

            [NativeTypeName(
                "HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                IDispatchEx.Native*,
                int,
                Guid*,
                uint,
                ushort,
                Dispparams*,
                Variant*,
                Excepinfo*,
                uint*,
                int> Invoke;

            [NativeTypeName("HRESULT (BSTR, DWORD, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, ushort*, uint, int*, int> GetDispID;

            [NativeTypeName(
                "HRESULT (DISPID, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, IServiceProvider *) __attribute__((stdcall))"
            )]
            public delegate* unmanaged<
                IDispatchEx.Native*,
                int,
                uint,
                ushort,
                Dispparams*,
                Variant*,
                Excepinfo*,
                IServiceProvider*,
                int> InvokeEx;

            [NativeTypeName("HRESULT (BSTR, DWORD) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, ushort*, uint, int> DeleteMemberByName;

            [NativeTypeName("HRESULT (DISPID) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, int, int> DeleteMemberByDispID;

            [NativeTypeName("HRESULT (DISPID, DWORD, DWORD *) __attribute__((stdcall))")]
            public delegate* unmanaged<
                IDispatchEx.Native*,
                int,
                uint,
                uint*,
                int> GetMemberProperties;

            [NativeTypeName("HRESULT (DISPID, BSTR *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, int, ushort**, int> GetMemberName;

            [NativeTypeName("HRESULT (DWORD, DISPID, DISPID *) __attribute__((stdcall))")]
            public delegate* unmanaged<IDispatchEx.Native*, uint, int, int*, int> GetNextDispID;

            [NativeTypeName("HRESULT (IUnknown **) __attribute__((stdcall))")]
            public delegate* unmanaged<
                IDispatchEx.Native*,
                IUnknown.Native**,
                int> GetNameSpaceParent;
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, uint>)(lpVtbl[1]))(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this)
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HResult DeleteMemberByDispID([NativeTypeName("DISPID")] int id)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, int, int>)(lpVtbl[10]))(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this),
                id
            );
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HResult DeleteMemberByName(
            [NativeTypeName("BSTR")] ushort* bstrName,
            [NativeTypeName("DWORD")] uint grfdex
        )
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, ushort*, uint, int>)(lpVtbl[9]))(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this),
                bstrName,
                grfdex
            );
        }

        [VtblIndex(9)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult DeleteMemberByName(
            [NativeTypeName("BSTR")] Ref<ushort> bstrName,
            [NativeTypeName("DWORD")] uint grfdex
        )
        {
            fixed (ushort* __dsl_bstrName = bstrName)
            {
                return (HResult)DeleteMemberByName(__dsl_bstrName, grfdex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HResult GetDispID(
            [NativeTypeName("BSTR")] ushort* bstrName,
            [NativeTypeName("DWORD")] uint grfdex,
            [NativeTypeName("DISPID *")] int* pid
        )
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, ushort*, uint, int*, int>)(lpVtbl[7]))(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this),
                bstrName,
                grfdex,
                pid
            );
        }

        [VtblIndex(7)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetDispID(
            [NativeTypeName("BSTR")] Ref<ushort> bstrName,
            [NativeTypeName("DWORD")] uint grfdex,
            [NativeTypeName("DISPID *")] Ref<int> pid
        )
        {
            fixed (int* __dsl_pid = pid)
            fixed (ushort* __dsl_bstrName = bstrName)
            {
                return (HResult)GetDispID(__dsl_bstrName, grfdex, __dsl_pid);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public HResult GetIDsOfNames(
            [NativeTypeName("const IID &")] Guid* riid,
            [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
            uint cNames,
            [NativeTypeName("LCID")] uint lcid,
            [NativeTypeName("DISPID *")] int* rgDispId
        )
        {
            return (
                (delegate* unmanaged<IDispatchEx.Native*, Guid*, ushort**, uint, uint, int*, int>)(
                    lpVtbl[5]
                )
            )(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this),
                riid,
                rgszNames,
                cNames,
                lcid,
                rgDispId
            );
        }

        [VtblIndex(5)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetIDsOfNames(
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            [NativeTypeName("LPOLESTR *")] Ref2D<ushort> rgszNames,
            uint cNames,
            [NativeTypeName("LCID")] uint lcid,
            [NativeTypeName("DISPID *")] Ref<int> rgDispId
        )
        {
            fixed (int* __dsl_rgDispId = rgDispId)
            fixed (ushort** __dsl_rgszNames = rgszNames)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)GetIDsOfNames(
                    __dsl_riid,
                    __dsl_rgszNames,
                    cNames,
                    lcid,
                    __dsl_rgDispId
                );
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HResult GetMemberName(
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("BSTR *")] ushort** pbstrName
        )
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, int, ushort**, int>)(lpVtbl[12]))(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this),
                id,
                pbstrName
            );
        }

        [VtblIndex(12)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetMemberName(
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("BSTR *")] Ref2D<ushort> pbstrName
        )
        {
            fixed (ushort** __dsl_pbstrName = pbstrName)
            {
                return (HResult)GetMemberName(id, __dsl_pbstrName);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public HResult GetMemberProperties(
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("DWORD")] uint grfdexFetch,
            [NativeTypeName("DWORD *")] uint* pgrfdex
        )
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, int, uint, uint*, int>)(lpVtbl[11]))(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this),
                id,
                grfdexFetch,
                pgrfdex
            );
        }

        [VtblIndex(11)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetMemberProperties(
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("DWORD")] uint grfdexFetch,
            [NativeTypeName("DWORD *")] Ref<uint> pgrfdex
        )
        {
            fixed (uint* __dsl_pgrfdex = pgrfdex)
            {
                return (HResult)GetMemberProperties(id, grfdexFetch, __dsl_pgrfdex);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(14)]
        public HResult GetNameSpaceParent(IUnknown* ppunk)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, IUnknown.Native**, int>)(lpVtbl[14]))(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this),
                &ppunk->LpVtbl
            );
        }

        [VtblIndex(14)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetNameSpaceParent(Ref<IUnknown> ppunk)
        {
            fixed (IUnknown* __dsl_ppunk = ppunk)
            {
                return (HResult)GetNameSpaceParent(__dsl_ppunk);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(13)]
        public HResult GetNextDispID(
            [NativeTypeName("DWORD")] uint grfdex,
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("DISPID *")] int* pid
        )
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, uint, int, int*, int>)(lpVtbl[13]))(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this),
                grfdex,
                id,
                pid
            );
        }

        [VtblIndex(13)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetNextDispID(
            [NativeTypeName("DWORD")] uint grfdex,
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("DISPID *")] Ref<int> pid
        )
        {
            fixed (int* __dsl_pid = pid)
            {
                return (HResult)GetNextDispID(grfdex, id, __dsl_pid);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HResult GetTypeInfo(
            uint iTInfo,
            [NativeTypeName("LCID")] uint lcid,
            ITypeInfo** ppTInfo
        )
        {
            return (
                (delegate* unmanaged<IDispatchEx.Native*, uint, uint, ITypeInfo**, int>)(lpVtbl[4])
            )((IDispatchEx.Native*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
        }

        [VtblIndex(4)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetTypeInfo(
            uint iTInfo,
            [NativeTypeName("LCID")] uint lcid,
            Ref2D<ITypeInfo> ppTInfo
        )
        {
            fixed (ITypeInfo** __dsl_ppTInfo = ppTInfo)
            {
                return (HResult)GetTypeInfo(iTInfo, lcid, __dsl_ppTInfo);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HResult GetTypeInfoCount(uint* pctinfo)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, uint*, int>)(lpVtbl[3]))(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this),
                pctinfo
            );
        }

        [VtblIndex(3)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult GetTypeInfoCount(Ref<uint> pctinfo)
        {
            fixed (uint* __dsl_pctinfo = pctinfo)
            {
                return (HResult)GetTypeInfoCount(__dsl_pctinfo);
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HResult Invoke(
            [NativeTypeName("DISPID")] int dispIdMember,
            [NativeTypeName("const IID &")] Guid* riid,
            [NativeTypeName("LCID")] uint lcid,
            [NativeTypeName("WORD")] ushort wFlags,
            Dispparams* pDispParams,
            Variant* pVarResult,
            Excepinfo* pExcepInfo,
            uint* puArgErr
        )
        {
            return (
                (delegate* unmanaged<
                    IDispatchEx.Native*,
                    int,
                    Guid*,
                    uint,
                    ushort,
                    Dispparams*,
                    Variant*,
                    Excepinfo*,
                    uint*,
                    int>)(lpVtbl[6])
            )(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this),
                dispIdMember,
                riid,
                lcid,
                wFlags,
                pDispParams,
                pVarResult,
                pExcepInfo,
                puArgErr
            );
        }

        [VtblIndex(6)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult Invoke(
            [NativeTypeName("DISPID")] int dispIdMember,
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            [NativeTypeName("LCID")] uint lcid,
            [NativeTypeName("WORD")] ushort wFlags,
            Ref<Dispparams> pDispParams,
            Ref<Variant> pVarResult,
            Ref<Excepinfo> pExcepInfo,
            Ref<uint> puArgErr
        )
        {
            fixed (uint* __dsl_puArgErr = puArgErr)
            fixed (Excepinfo* __dsl_pExcepInfo = pExcepInfo)
            fixed (Variant* __dsl_pVarResult = pVarResult)
            fixed (Dispparams* __dsl_pDispParams = pDispParams)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)Invoke(
                    dispIdMember,
                    __dsl_riid,
                    lcid,
                    wFlags,
                    __dsl_pDispParams,
                    __dsl_pVarResult,
                    __dsl_pExcepInfo,
                    __dsl_puArgErr
                );
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HResult InvokeEx(
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("LCID")] uint lcid,
            [NativeTypeName("WORD")] ushort wFlags,
            Dispparams* pdp,
            Variant* pvarRes,
            Excepinfo* pei,
            IServiceProvider* pspCaller
        )
        {
            return (
                (delegate* unmanaged<
                    IDispatchEx.Native*,
                    int,
                    uint,
                    ushort,
                    Dispparams*,
                    Variant*,
                    Excepinfo*,
                    IServiceProvider*,
                    int>)(lpVtbl[8])
            )(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this),
                id,
                lcid,
                wFlags,
                pdp,
                pvarRes,
                pei,
                pspCaller
            );
        }

        [VtblIndex(8)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult InvokeEx(
            [NativeTypeName("DISPID")] int id,
            [NativeTypeName("LCID")] uint lcid,
            [NativeTypeName("WORD")] ushort wFlags,
            Ref<Dispparams> pdp,
            Ref<Variant> pvarRes,
            Ref<Excepinfo> pei,
            Ref<IServiceProvider> pspCaller
        )
        {
            fixed (IServiceProvider* __dsl_pspCaller = pspCaller)
            fixed (Excepinfo* __dsl_pei = pei)
            fixed (Variant* __dsl_pvarRes = pvarRes)
            fixed (Dispparams* __dsl_pdp = pdp)
            {
                return (HResult)InvokeEx(
                    id,
                    lcid,
                    wFlags,
                    __dsl_pdp,
                    __dsl_pvarRes,
                    __dsl_pei,
                    __dsl_pspCaller
                );
            }
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, Guid*, void**, int>)(lpVtbl[0]))(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this),
                riid,
                ppvObject
            );
        }

        [VtblIndex(0)]
        [Transformed]
        [MethodImpl(
            MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization
        )]
        public HResult QueryInterface(
            [NativeTypeName("const IID &")] Ref<Guid> riid,
            Ref2D ppvObject
        )
        {
            fixed (void** __dsl_ppvObject = ppvObject)
            fixed (Guid* __dsl_riid = riid)
            {
                return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
            }
        }

        [VtblIndex(0)]
        [Transformed]
        public HResult QueryInterface<TCom>(out TCom ppvObject)
            where TCom : unmanaged, IComVtbl
        {
            ppvObject = default;
            return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDispatchEx.Native*, uint>)(lpVtbl[2]))(
                (IDispatchEx.Native*)Unsafe.AsPointer(ref this)
            );
        }
    }

    /// <summary>Initializes a new instance of the <see cref = "IDispatchEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IDispatchEx(Ptr3D vtbl) => LpVtbl = (IDispatchEx.Native*)vtbl;

    /// <summary>Initializes a new instance of the <see cref = "IDispatchEx"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>

    public IDispatchEx(Ptr<IDispatchEx.Native> vtbl) => LpVtbl = vtbl;

    /// <summary>casts <see cref = "IDispatchEx.Native"/> to <see cref = "IDispatchEx"/>.</summary>
    /// <param name = "value">The <see cref = "IDispatchEx.Native"/> instance to be converted </param>

    public static implicit operator IDispatchEx(IDispatchEx.Native* value) =>
        new IDispatchEx((Ptr<Native>)value);

    /// <summary>casts <see cref = "IDispatchEx"/> to <see cref = "IDispatchEx.Native"/> pointer.</summary>
    /// <param name = "value">The <see cref = "IDispatchEx"/> instance to be converted </param>

    public static implicit operator IDispatchEx.Native*(IDispatchEx value) => value.LpVtbl;

    /// <summary>casts <see cref = "Ptr3D"/> to <see cref = "IDispatchEx"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr3D"/> instance to be converted </param>

    public static explicit operator IDispatchEx(Ptr3D value) => new IDispatchEx(value);

    /// <summary>casts <see cref = "IDispatchEx"/> to <see cref = "Ptr3D"/> .</summary>
    /// <param name = "value">The <see cref = "IDispatchEx"/> instance to be converted </param>

    public static implicit operator Ptr3D(IDispatchEx value) => (Ptr3D)value.LpVtbl;

    /// <summary>casts <see cref = "Ptr{T}"/> to <see cref = "IDispatchEx"/>.</summary>
    /// <param name = "value">The <see cref = "Ptr{T}"/> instance to be converted </param>

    public static explicit operator IDispatchEx(Ptr<IDispatchEx.Native> value) =>
        new IDispatchEx(value);

    /// <summary>casts <see cref = "IDispatchEx"/> to <see cref = "Ptr{T}"/> .</summary>
    /// <param name = "value">The <see cref = "IDispatchEx"/> instance to be converted </param>

    public static implicit operator Ptr<IDispatchEx.Native>(IDispatchEx value) =>
        (Ptr<IDispatchEx.Native>)value.LpVtbl;

    /// <summary>casts void*** to <see cref = "IDispatchEx"/>.</summary>
    /// <param name = "value">The void*** instance to be converted </param>

    public static explicit operator IDispatchEx(void*** value) =>
        new IDispatchEx((Ptr<Native>)value);

    /// <summary>casts <see cref = "IDispatchEx"/> to void*** pointer.</summary>
    /// <param name = "value">The <see cref = "IDispatchEx"/> instance to be converted </param>

    public static implicit operator void***(IDispatchEx value) => (void***)value.LpVtbl;

    /// <summary>casts <see cref = "nuint"/> to <see cref = "IDispatchEx"/>.</summary>
    /// <param name = "value">The <see cref = "nuint"/> instance to be converted </param>

    public static explicit operator IDispatchEx(nuint value) =>
        new IDispatchEx((Ptr<Native>)value.ToPointer());

    /// <summary>casts <see cref = "IDispatchEx"/> to <see cref = "nuint"/> .</summary>
    /// <param name = "value">The <see cref = "IDispatchEx"/> instance to be converted </param>

    public static implicit operator nuint(IDispatchEx value) => (nuint)value.LpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef() => LpVtbl->AddRef();

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HResult DeleteMemberByDispID([NativeTypeName("DISPID")] int id) =>
        LpVtbl->DeleteMemberByDispID(id);

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HResult DeleteMemberByName(
        [NativeTypeName("BSTR")] ushort* bstrName,
        [NativeTypeName("DWORD")] uint grfdex
    ) => LpVtbl->DeleteMemberByName(bstrName, grfdex);

    [VtblIndex(9)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult DeleteMemberByName(
        [NativeTypeName("BSTR")] Ref<ushort> bstrName,
        [NativeTypeName("DWORD")] uint grfdex
    )
    {
        fixed (ushort* __dsl_bstrName = bstrName)
        {
            return (HResult)DeleteMemberByName(__dsl_bstrName, grfdex);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HResult GetDispID(
        [NativeTypeName("BSTR")] ushort* bstrName,
        [NativeTypeName("DWORD")] uint grfdex,
        [NativeTypeName("DISPID *")] int* pid
    ) => LpVtbl->GetDispID(bstrName, grfdex, pid);

    [VtblIndex(7)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetDispID(
        [NativeTypeName("BSTR")] Ref<ushort> bstrName,
        [NativeTypeName("DWORD")] uint grfdex,
        [NativeTypeName("DISPID *")] Ref<int> pid
    )
    {
        fixed (int* __dsl_pid = pid)
        fixed (ushort* __dsl_bstrName = bstrName)
        {
            return (HResult)GetDispID(__dsl_bstrName, grfdex, __dsl_pid);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HResult GetIDsOfNames(
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LPOLESTR *")] ushort** rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] int* rgDispId
    ) => LpVtbl->GetIDsOfNames(riid, rgszNames, cNames, lcid, rgDispId);

    [VtblIndex(5)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetIDsOfNames(
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        [NativeTypeName("LPOLESTR *")] Ref2D<ushort> rgszNames,
        uint cNames,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("DISPID *")] Ref<int> rgDispId
    )
    {
        fixed (int* __dsl_rgDispId = rgDispId)
        fixed (ushort** __dsl_rgszNames = rgszNames)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)GetIDsOfNames(
                __dsl_riid,
                __dsl_rgszNames,
                cNames,
                lcid,
                __dsl_rgDispId
            );
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HResult GetMemberName(
        [NativeTypeName("DISPID")] int id,
        [NativeTypeName("BSTR *")] ushort** pbstrName
    ) => LpVtbl->GetMemberName(id, pbstrName);

    [VtblIndex(12)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetMemberName(
        [NativeTypeName("DISPID")] int id,
        [NativeTypeName("BSTR *")] Ref2D<ushort> pbstrName
    )
    {
        fixed (ushort** __dsl_pbstrName = pbstrName)
        {
            return (HResult)GetMemberName(id, __dsl_pbstrName);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HResult GetMemberProperties(
        [NativeTypeName("DISPID")] int id,
        [NativeTypeName("DWORD")] uint grfdexFetch,
        [NativeTypeName("DWORD *")] uint* pgrfdex
    ) => LpVtbl->GetMemberProperties(id, grfdexFetch, pgrfdex);

    [VtblIndex(11)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetMemberProperties(
        [NativeTypeName("DISPID")] int id,
        [NativeTypeName("DWORD")] uint grfdexFetch,
        [NativeTypeName("DWORD *")] Ref<uint> pgrfdex
    )
    {
        fixed (uint* __dsl_pgrfdex = pgrfdex)
        {
            return (HResult)GetMemberProperties(id, grfdexFetch, __dsl_pgrfdex);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HResult GetNameSpaceParent(IUnknown* ppunk) => LpVtbl->GetNameSpaceParent(ppunk);

    [VtblIndex(14)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetNameSpaceParent(Ref<IUnknown> ppunk)
    {
        fixed (IUnknown* __dsl_ppunk = ppunk)
        {
            return (HResult)GetNameSpaceParent(__dsl_ppunk);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HResult GetNextDispID(
        [NativeTypeName("DWORD")] uint grfdex,
        [NativeTypeName("DISPID")] int id,
        [NativeTypeName("DISPID *")] int* pid
    ) => LpVtbl->GetNextDispID(grfdex, id, pid);

    [VtblIndex(13)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetNextDispID(
        [NativeTypeName("DWORD")] uint grfdex,
        [NativeTypeName("DISPID")] int id,
        [NativeTypeName("DISPID *")] Ref<int> pid
    )
    {
        fixed (int* __dsl_pid = pid)
        {
            return (HResult)GetNextDispID(grfdex, id, __dsl_pid);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HResult GetTypeInfo(
        uint iTInfo,
        [NativeTypeName("LCID")] uint lcid,
        ITypeInfo** ppTInfo
    ) => LpVtbl->GetTypeInfo(iTInfo, lcid, ppTInfo);

    [VtblIndex(4)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetTypeInfo(
        uint iTInfo,
        [NativeTypeName("LCID")] uint lcid,
        Ref2D<ITypeInfo> ppTInfo
    )
    {
        fixed (ITypeInfo** __dsl_ppTInfo = ppTInfo)
        {
            return (HResult)GetTypeInfo(iTInfo, lcid, __dsl_ppTInfo);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HResult GetTypeInfoCount(uint* pctinfo) => LpVtbl->GetTypeInfoCount(pctinfo);

    [VtblIndex(3)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult GetTypeInfoCount(Ref<uint> pctinfo)
    {
        fixed (uint* __dsl_pctinfo = pctinfo)
        {
            return (HResult)GetTypeInfoCount(__dsl_pctinfo);
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HResult Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Guid* riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        Dispparams* pDispParams,
        Variant* pVarResult,
        Excepinfo* pExcepInfo,
        uint* puArgErr
    ) =>
        LpVtbl->Invoke(
            dispIdMember,
            riid,
            lcid,
            wFlags,
            pDispParams,
            pVarResult,
            pExcepInfo,
            puArgErr
        );

    [VtblIndex(6)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult Invoke(
        [NativeTypeName("DISPID")] int dispIdMember,
        [NativeTypeName("const IID &")] Ref<Guid> riid,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        Ref<Dispparams> pDispParams,
        Ref<Variant> pVarResult,
        Ref<Excepinfo> pExcepInfo,
        Ref<uint> puArgErr
    )
    {
        fixed (uint* __dsl_puArgErr = puArgErr)
        fixed (Excepinfo* __dsl_pExcepInfo = pExcepInfo)
        fixed (Variant* __dsl_pVarResult = pVarResult)
        fixed (Dispparams* __dsl_pDispParams = pDispParams)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)Invoke(
                dispIdMember,
                __dsl_riid,
                lcid,
                wFlags,
                __dsl_pDispParams,
                __dsl_pVarResult,
                __dsl_pExcepInfo,
                __dsl_puArgErr
            );
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HResult InvokeEx(
        [NativeTypeName("DISPID")] int id,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        Dispparams* pdp,
        Variant* pvarRes,
        Excepinfo* pei,
        IServiceProvider* pspCaller
    ) => LpVtbl->InvokeEx(id, lcid, wFlags, pdp, pvarRes, pei, pspCaller);

    [VtblIndex(8)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult InvokeEx(
        [NativeTypeName("DISPID")] int id,
        [NativeTypeName("LCID")] uint lcid,
        [NativeTypeName("WORD")] ushort wFlags,
        Ref<Dispparams> pdp,
        Ref<Variant> pvarRes,
        Ref<Excepinfo> pei,
        Ref<IServiceProvider> pspCaller
    )
    {
        fixed (IServiceProvider* __dsl_pspCaller = pspCaller)
        fixed (Excepinfo* __dsl_pei = pei)
        fixed (Variant* __dsl_pvarRes = pvarRes)
        fixed (Dispparams* __dsl_pdp = pdp)
        {
            return (HResult)InvokeEx(
                id,
                lcid,
                wFlags,
                __dsl_pdp,
                __dsl_pvarRes,
                __dsl_pei,
                __dsl_pspCaller
            );
        }
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject) =>
        LpVtbl->QueryInterface(riid, ppvObject);

    [VtblIndex(0)]
    [Transformed]
    [MethodImpl(MethodImplOptions.AggressiveInlining | MethodImplOptions.AggressiveOptimization)]
    public HResult QueryInterface([NativeTypeName("const IID &")] Ref<Guid> riid, Ref2D ppvObject)
    {
        fixed (void** __dsl_ppvObject = ppvObject)
        fixed (Guid* __dsl_riid = riid)
        {
            return (HResult)QueryInterface(__dsl_riid, __dsl_ppvObject);
        }
    }

    [VtblIndex(0)]
    [Transformed]
    public HResult QueryInterface<TCom>(out TCom ppvObject)
        where TCom : unmanaged, IComVtbl
    {
        ppvObject = default;
        return QueryInterface(TCom.NativeGuid, ppvObject.GetAddressOf());
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release() => LpVtbl->Release();
}
