// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3051073C-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLDOMImplementation2 : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLDOMImplementation2
    : IHTMLDOMImplementation2.Interface,
        INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLDOMImplementation2));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLDOMImplementation2, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLDOMImplementation2, uint*, int>)((*lpVtbl)[3]))(
            this,
            pctinfo
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IHTMLDOMImplementation2, uint, uint, ITypeInfo*, int>)(
                (*lpVtbl)[4]
            )
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
            (delegate* unmanaged<IHTMLDOMImplementation2, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLDOMImplementation2,
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
    public HRESULT createDocumentType(
        [NativeTypeName("BSTR")] ushort* bstrQualifiedName,
        VARIANT* pvarPublicId,
        VARIANT* pvarSystemId,
        IDOMDocumentType* newDocumentType
    )
    {
        return (
            (delegate* unmanaged<
                IHTMLDOMImplementation2,
                ushort*,
                VARIANT*,
                VARIANT*,
                IDOMDocumentType*,
                int>)((*lpVtbl)[7])
        )(this, bstrQualifiedName, pvarPublicId, pvarSystemId, newDocumentType);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT createDocument(
        VARIANT* pvarNS,
        VARIANT* pvarTagName,
        IDOMDocumentType pDocumentType,
        IHTMLDocument7* ppnewDocument
    )
    {
        return (
            (delegate* unmanaged<
                IHTMLDOMImplementation2,
                VARIANT*,
                VARIANT*,
                IDOMDocumentType,
                IHTMLDocument7*,
                int>)((*lpVtbl)[8])
        )(this, pvarNS, pvarTagName, pDocumentType, ppnewDocument);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT createHTMLDocument(
        [NativeTypeName("BSTR")] ushort* bstrTitle,
        IHTMLDocument7* ppnewDocument
    )
    {
        return (
            (delegate* unmanaged<IHTMLDOMImplementation2, ushort*, IHTMLDocument7*, int>)(
                (*lpVtbl)[9]
            )
        )(this, bstrTitle, ppnewDocument);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT hasFeature(
        [NativeTypeName("BSTR")] ushort* bstrfeature,
        VARIANT version,
        [NativeTypeName("VARIANT_BOOL *")] short* pfHasFeature
    )
    {
        return (
            (delegate* unmanaged<IHTMLDOMImplementation2, ushort*, VARIANT, short*, int>)(
                (*lpVtbl)[10]
            )
        )(this, bstrfeature, version, pfHasFeature);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT createDocumentType(
            [NativeTypeName("BSTR")] ushort* bstrQualifiedName,
            VARIANT* pvarPublicId,
            VARIANT* pvarSystemId,
            IDOMDocumentType* newDocumentType
        );

        [VtblIndex(8)]
        HRESULT createDocument(
            VARIANT* pvarNS,
            VARIANT* pvarTagName,
            IDOMDocumentType pDocumentType,
            IHTMLDocument7* ppnewDocument
        );

        [VtblIndex(9)]
        HRESULT createHTMLDocument(
            [NativeTypeName("BSTR")] ushort* bstrTitle,
            IHTMLDocument7* ppnewDocument
        );

        [VtblIndex(10)]
        HRESULT hasFeature(
            [NativeTypeName("BSTR")] ushort* bstrfeature,
            VARIANT version,
            [NativeTypeName("VARIANT_BOOL *")] short* pfHasFeature
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

        [NativeTypeName(
            "HRESULT (BSTR, VARIANT *, VARIANT *, IDOMDocumentType **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            VARIANT*,
            VARIANT*,
            IDOMDocumentType*,
            int> createDocumentType;

        [NativeTypeName(
            "HRESULT (VARIANT *, VARIANT *, IDOMDocumentType *, IHTMLDocument7 **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VARIANT*,
            VARIANT*,
            IDOMDocumentType,
            IHTMLDocument7*,
            int> createDocument;

        [NativeTypeName("HRESULT (BSTR, IHTMLDocument7 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLDocument7*, int> createHTMLDocument;

        [NativeTypeName("HRESULT (BSTR, VARIANT, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT, short*, int> hasFeature;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLDOMImplementation2"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLDOMImplementation2(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLDOMImplementation2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLDOMImplementation2(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLDOMImplementation2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLDOMImplementation2"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLDOMImplementation2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLDOMImplementation2 value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLDOMImplementation2"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLDOMImplementation2(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLDOMImplementation2(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLDOMImplementation2"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLDOMImplementation2"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLDOMImplementation2 value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
