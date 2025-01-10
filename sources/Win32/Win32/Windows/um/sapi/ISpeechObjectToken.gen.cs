// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

[Guid("C74A3ADC-B727-4500-A84A-B526721C8B8C")]
[NativeTypeName("struct ISpeechObjectToken : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct ISpeechObjectToken : ISpeechObjectToken.Interface, INativeGuid
{
    static Guid* INativeGuid.NativeGuid =>
        (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_ISpeechObjectToken));
    public void*** lpVtbl;

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ISpeechObjectToken, Guid*, void**, int>)((*lpVtbl)[0]))(
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
        return ((delegate* unmanaged<ISpeechObjectToken, uint>)((*lpVtbl)[1]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ISpeechObjectToken, uint>)((*lpVtbl)[2]))(this);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<ISpeechObjectToken, uint*, int>)((*lpVtbl)[3]))(this, pctinfo);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo* ppTInfo)
    {
        return (
            (delegate* unmanaged<ISpeechObjectToken, uint, uint, ITypeInfo*, int>)((*lpVtbl)[4])
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
            (delegate* unmanaged<ISpeechObjectToken, Guid*, ushort**, uint, uint, int*, int>)(
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
                ISpeechObjectToken,
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
    public HRESULT get_Id([NativeTypeName("BSTR *")] ushort** ObjectId)
    {
        return ((delegate* unmanaged<ISpeechObjectToken, ushort**, int>)((*lpVtbl)[7]))(
            this,
            ObjectId
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_DataKey(ISpeechDataKey* DataKey)
    {
        return ((delegate* unmanaged<ISpeechObjectToken, ISpeechDataKey*, int>)((*lpVtbl)[8]))(
            this,
            DataKey
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT get_Category(ISpeechObjectTokenCategory* Category)
    {
        return (
            (delegate* unmanaged<ISpeechObjectToken, ISpeechObjectTokenCategory*, int>)(
                (*lpVtbl)[9]
            )
        )(this, Category);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT GetDescription(
        [NativeTypeName("long")] int Locale,
        [NativeTypeName("BSTR *")] ushort** Description
    )
    {
        return ((delegate* unmanaged<ISpeechObjectToken, int, ushort**, int>)((*lpVtbl)[10]))(
            this,
            Locale,
            Description
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT SetId(
        [NativeTypeName("BSTR")] ushort* Id,
        [NativeTypeName("BSTR")] ushort* CategoryID = null,
        [NativeTypeName("VARIANT_BOOL")] short CreateIfNotExist = 0
    )
    {
        return (
            (delegate* unmanaged<ISpeechObjectToken, ushort*, ushort*, short, int>)((*lpVtbl)[11])
        )(this, Id, CategoryID, CreateIfNotExist);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT GetAttribute(
        [NativeTypeName("BSTR")] ushort* AttributeName,
        [NativeTypeName("BSTR *")] ushort** AttributeValue
    )
    {
        return ((delegate* unmanaged<ISpeechObjectToken, ushort*, ushort**, int>)((*lpVtbl)[12]))(
            this,
            AttributeName,
            AttributeValue
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(13)]
    public HRESULT CreateInstance(
        IUnknown pUnkOuter,
        SpeechTokenContext ClsContext,
        IUnknown* Object
    )
    {
        return (
            (delegate* unmanaged<ISpeechObjectToken, IUnknown, SpeechTokenContext, IUnknown*, int>)(
                (*lpVtbl)[13]
            )
        )(this, pUnkOuter, ClsContext, Object);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(14)]
    public HRESULT Remove([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID)
    {
        return ((delegate* unmanaged<ISpeechObjectToken, ushort*, int>)((*lpVtbl)[14]))(
            this,
            ObjectStorageCLSID
        );
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(15)]
    public HRESULT GetStorageFileName(
        [NativeTypeName("BSTR")] ushort* ObjectStorageCLSID,
        [NativeTypeName("BSTR")] ushort* KeyName,
        [NativeTypeName("BSTR")] ushort* FileName,
        SpeechTokenShellFolder Folder,
        [NativeTypeName("BSTR *")] ushort** FilePath
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechObjectToken,
                ushort*,
                ushort*,
                ushort*,
                SpeechTokenShellFolder,
                ushort**,
                int>)((*lpVtbl)[15])
        )(this, ObjectStorageCLSID, KeyName, FileName, Folder, FilePath);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(16)]
    public HRESULT RemoveStorageFileName(
        [NativeTypeName("BSTR")] ushort* ObjectStorageCLSID,
        [NativeTypeName("BSTR")] ushort* KeyName,
        [NativeTypeName("VARIANT_BOOL")] short DeleteFile
    )
    {
        return (
            (delegate* unmanaged<ISpeechObjectToken, ushort*, ushort*, short, int>)((*lpVtbl)[16])
        )(this, ObjectStorageCLSID, KeyName, DeleteFile);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(17)]
    public HRESULT IsUISupported(
        [NativeTypeName("const BSTR")] ushort* TypeOfUI,
        [NativeTypeName("const VARIANT *")] VARIANT* ExtraData,
        IUnknown Object,
        [NativeTypeName("VARIANT_BOOL *")] short* Supported
    )
    {
        return (
            (delegate* unmanaged<ISpeechObjectToken, ushort*, VARIANT*, IUnknown, short*, int>)(
                (*lpVtbl)[17]
            )
        )(this, TypeOfUI, ExtraData, Object, Supported);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(18)]
    public HRESULT DisplayUI(
        [NativeTypeName("long")] int hWnd,
        [NativeTypeName("BSTR")] ushort* Title,
        [NativeTypeName("const BSTR")] ushort* TypeOfUI,
        [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null,
        IUnknown Object = default
    )
    {
        return (
            (delegate* unmanaged<
                ISpeechObjectToken,
                int,
                ushort*,
                ushort*,
                VARIANT*,
                IUnknown,
                int>)((*lpVtbl)[18])
        )(this, hWnd, Title, TypeOfUI, ExtraData, Object);
    }

    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(19)]
    public HRESULT MatchesAttributes(
        [NativeTypeName("BSTR")] ushort* Attributes,
        [NativeTypeName("VARIANT_BOOL *")] short* Matches
    )
    {
        return ((delegate* unmanaged<ISpeechObjectToken, ushort*, short*, int>)((*lpVtbl)[19]))(
            this,
            Attributes,
            Matches
        );
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT get_Id([NativeTypeName("BSTR *")] ushort** ObjectId);

        [VtblIndex(8)]
        HRESULT get_DataKey(ISpeechDataKey* DataKey);

        [VtblIndex(9)]
        HRESULT get_Category(ISpeechObjectTokenCategory* Category);

        [VtblIndex(10)]
        HRESULT GetDescription(
            [NativeTypeName("long")] int Locale,
            [NativeTypeName("BSTR *")] ushort** Description
        );

        [VtblIndex(11)]
        HRESULT SetId(
            [NativeTypeName("BSTR")] ushort* Id,
            [NativeTypeName("BSTR")] ushort* CategoryID = null,
            [NativeTypeName("VARIANT_BOOL")] short CreateIfNotExist = 0
        );

        [VtblIndex(12)]
        HRESULT GetAttribute(
            [NativeTypeName("BSTR")] ushort* AttributeName,
            [NativeTypeName("BSTR *")] ushort** AttributeValue
        );

        [VtblIndex(13)]
        HRESULT CreateInstance(IUnknown pUnkOuter, SpeechTokenContext ClsContext, IUnknown* Object);

        [VtblIndex(14)]
        HRESULT Remove([NativeTypeName("BSTR")] ushort* ObjectStorageCLSID);

        [VtblIndex(15)]
        HRESULT GetStorageFileName(
            [NativeTypeName("BSTR")] ushort* ObjectStorageCLSID,
            [NativeTypeName("BSTR")] ushort* KeyName,
            [NativeTypeName("BSTR")] ushort* FileName,
            SpeechTokenShellFolder Folder,
            [NativeTypeName("BSTR *")] ushort** FilePath
        );

        [VtblIndex(16)]
        HRESULT RemoveStorageFileName(
            [NativeTypeName("BSTR")] ushort* ObjectStorageCLSID,
            [NativeTypeName("BSTR")] ushort* KeyName,
            [NativeTypeName("VARIANT_BOOL")] short DeleteFile
        );

        [VtblIndex(17)]
        HRESULT IsUISupported(
            [NativeTypeName("const BSTR")] ushort* TypeOfUI,
            [NativeTypeName("const VARIANT *")] VARIANT* ExtraData,
            IUnknown Object,
            [NativeTypeName("VARIANT_BOOL *")] short* Supported
        );

        [VtblIndex(18)]
        HRESULT DisplayUI(
            [NativeTypeName("long")] int hWnd,
            [NativeTypeName("BSTR")] ushort* Title,
            [NativeTypeName("const BSTR")] ushort* TypeOfUI,
            [NativeTypeName("const VARIANT *")] VARIANT* ExtraData = null,
            IUnknown Object = default
        );

        [VtblIndex(19)]
        HRESULT MatchesAttributes(
            [NativeTypeName("BSTR")] ushort* Attributes,
            [NativeTypeName("VARIANT_BOOL *")] short* Matches
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

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_Id;

        [NativeTypeName("HRESULT (ISpeechDataKey **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechDataKey*, int> get_DataKey;

        [NativeTypeName("HRESULT (ISpeechObjectTokenCategory **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ISpeechObjectTokenCategory*, int> get_Category;

        [NativeTypeName("HRESULT (long, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, ushort**, int> GetDescription;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, short, int> SetId;

        [NativeTypeName("HRESULT (BSTR, BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort**, int> GetAttribute;

        [NativeTypeName(
            "HRESULT (IUnknown *, SpeechTokenContext, IUnknown **) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            IUnknown,
            SpeechTokenContext,
            IUnknown*,
            int> CreateInstance;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> Remove;

        [NativeTypeName(
            "HRESULT (BSTR, BSTR, BSTR, SpeechTokenShellFolder, BSTR *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            ushort*,
            ushort*,
            ushort*,
            SpeechTokenShellFolder,
            ushort**,
            int> GetStorageFileName;

        [NativeTypeName("HRESULT (BSTR, BSTR, VARIANT_BOOL) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, ushort*, short, int> RemoveStorageFileName;

        [NativeTypeName(
            "HRESULT (const BSTR, const VARIANT *, IUnknown *, VARIANT_BOOL *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<TSelf*, ushort*, VARIANT*, IUnknown, short*, int> IsUISupported;

        [NativeTypeName(
            "HRESULT (long, BSTR, const BSTR, const VARIANT *, IUnknown *) __attribute__((stdcall))"
        )]
        public delegate* unmanaged<
            TSelf*,
            int,
            ushort*,
            ushort*,
            VARIANT*,
            IUnknown,
            int> DisplayUI;

        [NativeTypeName("HRESULT (BSTR, VARIANT_BOOL *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, short*, int> MatchesAttributes;
    }

    /// <summary>Initializes a new instance of the <see cref = "ISpeechObjectToken"/> struct with the specified virtual table pointer.</summary>
    /// <param name = "vtbl">The pointer to virtual table.</param>
    public ISpeechObjectToken(void*** vtbl)
    {
        lpVtbl = vtbl;
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IDispatch"/> to <see cref = "ISpeechObjectToken"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IDispatch"/> instance to be converted </param>
    public static explicit operator ISpeechObjectToken(Silk.NET.Windows.IDispatch value)
    {
        return new ISpeechObjectToken(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechObjectToken"/> to <see cref = "Silk.NET.Windows.IDispatch"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechObjectToken"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IDispatch(ISpeechObjectToken value)
    {
        return new Silk.NET.Windows.IDispatch(value.lpVtbl);
    }

    /// <summary>Downcasts <see cref = "Silk.NET.Windows.IUnknown"/> to <see cref = "ISpeechObjectToken"/>.</summary>
    /// <param name = "value">The <see cref = "Silk.NET.Windows.IUnknown"/> instance to be converted </param>
    public static explicit operator ISpeechObjectToken(Silk.NET.Windows.IUnknown value)
    {
        return new ISpeechObjectToken(value.lpVtbl);
    }

    /// <summary>Upcasts <see cref = "ISpeechObjectToken"/> to <see cref = "Silk.NET.Windows.IUnknown"/>.</summary>
    /// <param name = "value">The <see cref = "ISpeechObjectToken"/> instance to be converted </param>
    public static implicit operator Silk.NET.Windows.IUnknown(ISpeechObjectToken value)
    {
        return new Silk.NET.Windows.IUnknown(value.lpVtbl);
    }
}
