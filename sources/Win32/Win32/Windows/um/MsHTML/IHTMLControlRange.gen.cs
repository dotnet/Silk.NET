// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F29C-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLControlRange : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLControlRange : IHTMLControlRange.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLControlRange));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLControlRange, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLControlRange, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLControlRange, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLControlRange, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IHTMLControlRange, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<IHTMLControlRange, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLControlRange,
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
    public HRESULT select()
    {
        return ((delegate* unmanaged<IHTMLControlRange, int>)((*lpVtbl)[7]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT add(IHTMLControlElement item)
    {
        return ((delegate* unmanaged<IHTMLControlRange, IHTMLControlElement, int>)((*lpVtbl)[8]))(
            this,
            item
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT remove([NativeTypeName("long")] int index)
    {
        return ((delegate* unmanaged<IHTMLControlRange, int, int>)((*lpVtbl)[9]))(this, index);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT item([NativeTypeName("long")] int index, IHTMLElement* pdisp)
    {
        return ((delegate* unmanaged<IHTMLControlRange, int, IHTMLElement*, int>)((*lpVtbl)[10]))(
            this,
            index,
            pdisp
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT scrollIntoView(VARIANT varargStart)
    {
        return ((delegate* unmanaged<IHTMLControlRange, VARIANT, int>)((*lpVtbl)[11]))(
            this,
            varargStart
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT queryCommandSupported(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("VARIANT_BOOL *")] short* pfRet
    )
    {
        return ((delegate* unmanaged<IHTMLControlRange, ushort*, short*, int>)((*lpVtbl)[12]))(
            this,
            cmdID,
            pfRet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT queryCommandEnabled(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("VARIANT_BOOL *")] short* pfRet
    )
    {
        return ((delegate* unmanaged<IHTMLControlRange, ushort*, short*, int>)((*lpVtbl)[13]))(
            this,
            cmdID,
            pfRet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT queryCommandState(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("VARIANT_BOOL *")] short* pfRet
    )
    {
        return ((delegate* unmanaged<IHTMLControlRange, ushort*, short*, int>)((*lpVtbl)[14]))(
            this,
            cmdID,
            pfRet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT queryCommandIndeterm(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("VARIANT_BOOL *")] short* pfRet
    )
    {
        return ((delegate* unmanaged<IHTMLControlRange, ushort*, short*, int>)((*lpVtbl)[15]))(
            this,
            cmdID,
            pfRet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT queryCommandText(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("BSTR *")] ushort** pcmdText
    )
    {
        return ((delegate* unmanaged<IHTMLControlRange, ushort*, ushort**, int>)((*lpVtbl)[16]))(
            this,
            cmdID,
            pcmdText
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT queryCommandValue([NativeTypeName("BSTR")] ushort* cmdID, VARIANT* pcmdValue)
    {
        return ((delegate* unmanaged<IHTMLControlRange, ushort*, VARIANT*, int>)((*lpVtbl)[17]))(
            this,
            cmdID,
            pcmdValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT execCommand(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("VARIANT_BOOL")] short showUI,
        VARIANT value,
        [NativeTypeName("VARIANT_BOOL *")] short* pfRet
    )
    {
        return (
            (delegate* unmanaged<IHTMLControlRange, ushort*, short, VARIANT, short*, int>)(
                (*lpVtbl)[18]
            )
        )(this, cmdID, showUI, value, pfRet);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT execCommandShowHelp(
        [NativeTypeName("BSTR")] ushort* cmdID,
        [NativeTypeName("VARIANT_BOOL *")] short* pfRet
    )
    {
        return ((delegate* unmanaged<IHTMLControlRange, ushort*, short*, int>)((*lpVtbl)[19]))(
            this,
            cmdID,
            pfRet
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT commonParentElement(IHTMLElement* parent)
    {
        return ((delegate* unmanaged<IHTMLControlRange, IHTMLElement*, int>)((*lpVtbl)[20]))(
            this,
            parent
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_length([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLControlRange, int*, int>)((*lpVtbl)[21]))(this, p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT select();

        [VtblIndex(8)]
        HRESULT add(IHTMLControlElement item);

        [VtblIndex(9)]
        HRESULT remove([NativeTypeName("long")] int index);

        [VtblIndex(10)]
        HRESULT item([NativeTypeName("long")] int index, IHTMLElement* pdisp);

        [VtblIndex(11)]
        HRESULT scrollIntoView(VARIANT varargStart);

        [VtblIndex(12)]
        HRESULT queryCommandSupported(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("VARIANT_BOOL *")] short* pfRet
        );

        [VtblIndex(13)]
        HRESULT queryCommandEnabled(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("VARIANT_BOOL *")] short* pfRet
        );

        [VtblIndex(14)]
        HRESULT queryCommandState(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("VARIANT_BOOL *")] short* pfRet
        );

        [VtblIndex(15)]
        HRESULT queryCommandIndeterm(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("VARIANT_BOOL *")] short* pfRet
        );

        [VtblIndex(16)]
        HRESULT queryCommandText(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("BSTR *")] ushort** pcmdText
        );

        [VtblIndex(17)]
        HRESULT queryCommandValue([NativeTypeName("BSTR")] ushort* cmdID, VARIANT* pcmdValue);

        [VtblIndex(18)]
        HRESULT execCommand(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("VARIANT_BOOL")] short showUI,
            VARIANT value,
            [NativeTypeName("VARIANT_BOOL *")] short* pfRet
        );

        [VtblIndex(19)]
        HRESULT execCommandShowHelp(
            [NativeTypeName("BSTR")] ushort* cmdID,
            [NativeTypeName("VARIANT_BOOL *")] short* pfRet
        );

        [VtblIndex(20)]
        HRESULT commonParentElement(IHTMLElement* parent);

        [VtblIndex(21)]
        HRESULT get_length([NativeTypeName("long *")] int* p);
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
        public delegate* unmanaged<TSelf*, int> select;

        [NativeTypeName("HRESULT (IHTMLControlElement *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLControlElement, int> add;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> remove;

        [NativeTypeName("HRESULT (long, IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, IHTMLElement*, int> item;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> scrollIntoView;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> queryCommandSupported;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> queryCommandEnabled;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> queryCommandState;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> queryCommandIndeterm;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> queryCommandText;

        [NativeTypeName("HRESULT (BSTR, VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, int> queryCommandValue;

        [NativeTypeName(
            "HRESULT (BSTR, VARIANT_BOOL, VARIANT, VARIANT_BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, short, VARIANT, short*, int> execCommand;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> execCommandShowHelp;

        [NativeTypeName("HRESULT (IHTMLElement **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLElement*, int> commonParentElement;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_length;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLControlRange"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLControlRange(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLControlRange"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLControlRange(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLControlRange(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLControlRange"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLControlRange"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLControlRange value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLControlRange"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLControlRange(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLControlRange(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLControlRange"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLControlRange"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLControlRange value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
