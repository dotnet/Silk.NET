// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("305106DA-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IDOMMutationEvent : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IDOMMutationEvent : IDOMMutationEvent.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IDOMMutationEvent));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDOMMutationEvent, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IDOMMutationEvent, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDOMMutationEvent, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IDOMMutationEvent, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IDOMMutationEvent, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
        )(this, iTInfo, lcid, ppTInfo);
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
            (delegate* unmanaged<IDOMMutationEvent, Guid*, ushort**, uint, uint, int*, int>)(
                (*lpVtbl)[5]
            )
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
                IDOMMutationEvent,
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
    public HRESULT get_relatedNode(IDispatch* p)
    {
        return ((delegate* unmanaged<IDOMMutationEvent, IDispatch*, int>)((*lpVtbl)[7]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_prevValue([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IDOMMutationEvent, ushort**, int>)((*lpVtbl)[8]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_newValue([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IDOMMutationEvent, ushort**, int>)((*lpVtbl)[9]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_attrName([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IDOMMutationEvent, ushort**, int>)((*lpVtbl)[10]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT get_attrChange(ushort* p)
    {
        return ((delegate* unmanaged<IDOMMutationEvent, ushort*, int>)((*lpVtbl)[11]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT initMutationEvent(
        [NativeTypeName("BSTR")] ushort* eventType,
        [NativeTypeName("VARIANT_BOOL")] short canBubble,
        [NativeTypeName("VARIANT_BOOL")] short cancelable,
        IDispatch relatedNodeArg,
        [NativeTypeName("BSTR")] ushort* prevValueArg,
        [NativeTypeName("BSTR")] ushort* newValueArg,
        [NativeTypeName("BSTR")] ushort* attrNameArg,
        ushort attrChangeArg
    )
    {
        return (
            (delegate* unmanaged<
                IDOMMutationEvent,
                ushort*,
                short,
                short,
                IDispatch,
                ushort*,
                ushort*,
                ushort*,
                ushort,
                int>)((*lpVtbl)[12])
        )(
            this,
            eventType,
            canBubble,
            cancelable,
            relatedNodeArg,
            prevValueArg,
            newValueArg,
            attrNameArg,
            attrChangeArg
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_relatedNode(IDispatch* p);

        [VtblIndex(8)]
        HRESULT get_prevValue([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(9)]
        HRESULT get_newValue([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(10)]
        HRESULT get_attrName([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(11)]
        HRESULT get_attrChange(ushort* p);

        [VtblIndex(12)]
        HRESULT initMutationEvent(
            [NativeTypeName("BSTR")] ushort* eventType,
            [NativeTypeName("VARIANT_BOOL")] short canBubble,
            [NativeTypeName("VARIANT_BOOL")] short cancelable,
            IDispatch relatedNodeArg,
            [NativeTypeName("BSTR")] ushort* prevValueArg,
            [NativeTypeName("BSTR")] ushort* newValueArg,
            [NativeTypeName("BSTR")] ushort* attrNameArg,
            ushort attrChangeArg
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

        [NativeTypeName("HRESULT (IDispatch **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IDispatch*, int> get_relatedNode;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_prevValue;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_newValue;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_attrName;

        [NativeTypeName("HRESULT (USHORT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> get_attrChange;

        [NativeTypeName(
            "HRESULT (BSTR, VARIANT_BOOL, VARIANT_BOOL, IDispatch *, BSTR, BSTR, BSTR, USHORT) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            short,
            short,
            IDispatch,
            ushort*,
            ushort*,
            ushort*,
            ushort,
            int> initMutationEvent;
    }

    /// <summary>Initializes a new instance of the <see cref = "IDOMMutationEvent"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IDOMMutationEvent(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IDOMMutationEvent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IDOMMutationEvent(Silk.NET.Windows.IDispatch value)
    {
        return new IDOMMutationEvent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDOMMutationEvent"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IDOMMutationEvent"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IDOMMutationEvent value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IDOMMutationEvent"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IDOMMutationEvent(Silk.NET.Windows.IUnknown value)
    {
        return new IDOMMutationEvent(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IDOMMutationEvent"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IDOMMutationEvent"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IDOMMutationEvent value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
