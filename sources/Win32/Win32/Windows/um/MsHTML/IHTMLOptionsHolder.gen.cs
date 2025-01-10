// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("3050F378-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLOptionsHolder : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLOptionsHolder : IHTMLOptionsHolder.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_IHTMLOptionsHolder));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<IHTMLOptionsHolder, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<IHTMLOptionsHolder, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<IHTMLOptionsHolder, Guid*, ushort**, uint, uint, int*, int>)(
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
                IHTMLOptionsHolder,
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
    public HRESULT get_document(IHTMLDocument2* p)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, IHTMLDocument2*, int>)((*lpVtbl)[7]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_fonts(IHTMLFontNamesCollection* p)
    {
        return (
            (delegate* unmanaged<IHTMLOptionsHolder, IHTMLFontNamesCollection*, int>)((*lpVtbl)[8])
        )(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_execArg(VARIANT v)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, VARIANT, int>)((*lpVtbl)[9]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_execArg(VARIANT* p)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, VARIANT*, int>)((*lpVtbl)[10]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_errorLine([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, int, int>)((*lpVtbl)[11]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_errorLine([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, int*, int>)((*lpVtbl)[12]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT put_errorCharacter([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, int, int>)((*lpVtbl)[13]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT get_errorCharacter([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, int*, int>)((*lpVtbl)[14]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT put_errorCode([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, int, int>)((*lpVtbl)[15]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT get_errorCode([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, int*, int>)((*lpVtbl)[16]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT put_errorMessage([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, ushort*, int>)((*lpVtbl)[17]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT get_errorMessage([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, ushort**, int>)((*lpVtbl)[18]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT put_errorDebug([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, short, int>)((*lpVtbl)[19]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(20)]
    public HRESULT get_errorDebug([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, short*, int>)((*lpVtbl)[20]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(21)]
    public HRESULT get_unsecuredWindowOfDocument(IHTMLWindow2* p)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, IHTMLWindow2*, int>)((*lpVtbl)[21]))(
            this,
            p
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(22)]
    public HRESULT put_findText([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, ushort*, int>)((*lpVtbl)[22]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(23)]
    public HRESULT get_findText([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, ushort**, int>)((*lpVtbl)[23]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(24)]
    public HRESULT put_anythingAfterFrameset([NativeTypeName("VARIANT_BOOL")] short v)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, short, int>)((*lpVtbl)[24]))(this, v);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(25)]
    public HRESULT get_anythingAfterFrameset([NativeTypeName("VARIANT_BOOL *")] short* p)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, short*, int>)((*lpVtbl)[25]))(this, p);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(26)]
    public HRESULT sizes(
        [NativeTypeName("BSTR")] ushort* fontName,
        IHTMLFontSizesCollection* pSizesCollection
    )
    {
        return (
            (delegate* unmanaged<IHTMLOptionsHolder, ushort*, IHTMLFontSizesCollection*, int>)(
                (*lpVtbl)[26]
            )
        )(this, fontName, pSizesCollection);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(27)]
    public HRESULT openfiledlg(
        VARIANT initFile,
        VARIANT initDir,
        VARIANT filter,
        VARIANT title,
        [NativeTypeName("BSTR *")] ushort** pathName
    )
    {
        return (
            (delegate* unmanaged<
                IHTMLOptionsHolder,
                VARIANT,
                VARIANT,
                VARIANT,
                VARIANT,
                ushort**,
                int>)((*lpVtbl)[27])
        )(this, initFile, initDir, filter, title, pathName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(28)]
    public HRESULT savefiledlg(
        VARIANT initFile,
        VARIANT initDir,
        VARIANT filter,
        VARIANT title,
        [NativeTypeName("BSTR *")] ushort** pathName
    )
    {
        return (
            (delegate* unmanaged<
                IHTMLOptionsHolder,
                VARIANT,
                VARIANT,
                VARIANT,
                VARIANT,
                ushort**,
                int>)((*lpVtbl)[28])
        )(this, initFile, initDir, filter, title, pathName);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(29)]
    public HRESULT choosecolordlg(VARIANT initColor, [NativeTypeName("long *")] int* rgbColor)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, VARIANT, int*, int>)((*lpVtbl)[29]))(
            this,
            initColor,
            rgbColor
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(30)]
    public HRESULT showSecurityInfo()
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, int>)((*lpVtbl)[30]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(31)]
    public HRESULT isApartmentModel(
        IHTMLObjectElement @object,
        [NativeTypeName("VARIANT_BOOL *")] short* fApartment
    )
    {
        return (
            (delegate* unmanaged<IHTMLOptionsHolder, IHTMLObjectElement, short*, int>)(
                (*lpVtbl)[31]
            )
        )(this, @object, fApartment);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(32)]
    public HRESULT getCharset(
        [NativeTypeName("BSTR")] ushort* fontName,
        [NativeTypeName("long *")] int* charset
    )
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, ushort*, int*, int>)((*lpVtbl)[32]))(
            this,
            fontName,
            charset
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(33)]
    public HRESULT get_secureConnectionInfo([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLOptionsHolder, ushort**, int>)((*lpVtbl)[33]))(this, p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_document(IHTMLDocument2* p);

        [VtblIndex(8)]
        HRESULT get_fonts(IHTMLFontNamesCollection* p);

        [VtblIndex(9)]
        HRESULT put_execArg(VARIANT v);

        [VtblIndex(10)]
        HRESULT get_execArg(VARIANT* p);

        [VtblIndex(11)]
        HRESULT put_errorLine([NativeTypeName("long")] int v);

        [VtblIndex(12)]
        HRESULT get_errorLine([NativeTypeName("long *")] int* p);

        [VtblIndex(13)]
        HRESULT put_errorCharacter([NativeTypeName("long")] int v);

        [VtblIndex(14)]
        HRESULT get_errorCharacter([NativeTypeName("long *")] int* p);

        [VtblIndex(15)]
        HRESULT put_errorCode([NativeTypeName("long")] int v);

        [VtblIndex(16)]
        HRESULT get_errorCode([NativeTypeName("long *")] int* p);

        [VtblIndex(17)]
        HRESULT put_errorMessage([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(18)]
        HRESULT get_errorMessage([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(19)]
        HRESULT put_errorDebug([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(20)]
        HRESULT get_errorDebug([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(21)]
        HRESULT get_unsecuredWindowOfDocument(IHTMLWindow2* p);

        [VtblIndex(22)]
        HRESULT put_findText([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(23)]
        HRESULT get_findText([NativeTypeName("BSTR *")] ushort** p);

        [VtblIndex(24)]
        HRESULT put_anythingAfterFrameset([NativeTypeName("VARIANT_BOOL")] short v);

        [VtblIndex(25)]
        HRESULT get_anythingAfterFrameset([NativeTypeName("VARIANT_BOOL *")] short* p);

        [VtblIndex(26)]
        HRESULT sizes(
            [NativeTypeName("BSTR")] ushort* fontName,
            IHTMLFontSizesCollection* pSizesCollection
        );

        [VtblIndex(27)]
        HRESULT openfiledlg(
            VARIANT initFile,
            VARIANT initDir,
            VARIANT filter,
            VARIANT title,
            [NativeTypeName("BSTR *")] ushort** pathName
        );

        [VtblIndex(28)]
        HRESULT savefiledlg(
            VARIANT initFile,
            VARIANT initDir,
            VARIANT filter,
            VARIANT title,
            [NativeTypeName("BSTR *")] ushort** pathName
        );

        [VtblIndex(29)]
        HRESULT choosecolordlg(VARIANT initColor, [NativeTypeName("long *")] int* rgbColor);

        [VtblIndex(30)]
        HRESULT showSecurityInfo();

        [VtblIndex(31)]
        HRESULT isApartmentModel(
            IHTMLObjectElement @object,
            [NativeTypeName("VARIANT_BOOL *")] short* fApartment
        );

        [VtblIndex(32)]
        HRESULT getCharset(
            [NativeTypeName("BSTR")] ushort* fontName,
            [NativeTypeName("long *")] int* charset
        );

        [VtblIndex(33)]
        HRESULT get_secureConnectionInfo([NativeTypeName("BSTR *")] ushort** p);
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

        [NativeTypeName("HRESULT (IHTMLDocument2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLDocument2*, int> get_document;

        [NativeTypeName("HRESULT (IHTMLFontNamesCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLFontNamesCollection*, int> get_fonts;

        [NativeTypeName("HRESULT (VARIANT) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int> put_execArg;

        [NativeTypeName("HRESULT (VARIANT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT*, int> get_execArg;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_errorLine;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_errorLine;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_errorCharacter;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_errorCharacter;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_errorCode;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_errorCode;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_errorMessage;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_errorMessage;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_errorDebug;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_errorDebug;

        [NativeTypeName("HRESULT (IHTMLWindow2 **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLWindow2*, int> get_unsecuredWindowOfDocument;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_findText;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_findText;

        [NativeTypeName("HRESULT (VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short, int> put_anythingAfterFrameset;

        [NativeTypeName("HRESULT (VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, short*, int> get_anythingAfterFrameset;

        [NativeTypeName("HRESULT (BSTR, IHTMLFontSizesCollection **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, IHTMLFontSizesCollection*, int> sizes;

        [NativeTypeName(
            "HRESULT (VARIANT, VARIANT, VARIANT, VARIANT, BSTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VARIANT,
            VARIANT,
            VARIANT,
            VARIANT,
            ushort**,
            int> openfiledlg;

        [NativeTypeName(
            "HRESULT (VARIANT, VARIANT, VARIANT, VARIANT, BSTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            VARIANT,
            VARIANT,
            VARIANT,
            VARIANT,
            ushort**,
            int> savefiledlg;

        [NativeTypeName("HRESULT (VARIANT, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, VARIANT, int*, int> choosecolordlg;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> showSecurityInfo;

        [NativeTypeName("HRESULT (IHTMLObjectElement *, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, IHTMLObjectElement, short*, int> isApartmentModel;

        [NativeTypeName("HRESULT (BSTR, long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int*, int> getCharset;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_secureConnectionInfo;
    }

    /// <summary>Initializes a new instance of the <see cref = "IHTMLOptionsHolder"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public IHTMLOptionsHolder(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "IHTMLOptionsHolder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator IHTMLOptionsHolder(Silk.NET.Windows.IDispatch value)
    {
        return new IHTMLOptionsHolder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLOptionsHolder"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLOptionsHolder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(IHTMLOptionsHolder value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "IHTMLOptionsHolder"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator IHTMLOptionsHolder(Silk.NET.Windows.IUnknown value)
    {
        return new IHTMLOptionsHolder(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "IHTMLOptionsHolder"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "IHTMLOptionsHolder"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(IHTMLOptionsHolder value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
