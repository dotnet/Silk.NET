// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/propsys.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    [DllImport("propsys", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PropVariantToWinRTPropertyValue(
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WinRTPropertyValueToPropVariant(
        IUnknown punkPropertyValue,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSFormatForDisplay(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        PROPDESC_FORMAT_FLAGS pdfFlags,
        [NativeTypeName("LPWSTR")] ushort* pwszText,
        [NativeTypeName("DWORD")] uint cchText
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSFormatForDisplayAlloc(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        PROPDESC_FORMAT_FLAGS pdff,
        [NativeTypeName("PWSTR *")] ushort** ppszDisplay
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSFormatPropertyValue(
        IPropertyStore pps,
        IPropertyDescription ppd,
        PROPDESC_FORMAT_FLAGS pdff,
        [NativeTypeName("LPWSTR *")] ushort** ppszDisplay
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetImageReferenceForValue(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("PWSTR *")] ushort** ppszImageRes
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSStringFromPropertyKey(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* pkey,
        [NativeTypeName("LPWSTR")] ushort* psz,
        uint cch
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyKeyFromString(
        [NativeTypeName("LPCWSTR")] ushort* pszString,
        PROPERTYKEY* pkey
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreateMemoryPropertyStore(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreateDelayedMultiplexPropertyStore(
        GETPROPERTYSTOREFLAGS flags,
        IDelayedPropertyStoreFactory pdpsf,
        [NativeTypeName("const DWORD *")] uint* rgStoreIds,
        [NativeTypeName("DWORD")] uint cStores,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreateMultiplexPropertyStore(
        IUnknown* prgpunkStores,
        [NativeTypeName("DWORD")] uint cStores,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreatePropertyChangeArray(
        [NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgpropkey,
        [NativeTypeName("const PKA_FLAGS *")] PKA_FLAGS* rgflags,
        [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* rgpropvar,
        uint cChanges,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreateSimplePropertyChange(
        PKA_FLAGS flags,
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertyDescription(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertyDescriptionByName(
        [NativeTypeName("LPCWSTR")] ushort* pszCanonicalName,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSLookupPropertyHandlerCLSID(
        [NativeTypeName("PCWSTR")] ushort* pszFilePath,
        [NativeTypeName("CLSID *")] Guid* pclsid
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetItemPropertyHandler(
        IUnknown punkItem,
        BOOL fReadWrite,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetItemPropertyHandlerWithCreateObject(
        IUnknown punkItem,
        BOOL fReadWrite,
        IUnknown punkCreateObject,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertyValue(
        IPropertyStore pps,
        IPropertyDescription ppd,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSSetPropertyValue(
        IPropertyStore pps,
        IPropertyDescription ppd,
        [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSRegisterPropertySchema(
        [NativeTypeName("PCWSTR")] ushort* pszPath
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSUnregisterPropertySchema(
        [NativeTypeName("PCWSTR")] ushort* pszPath
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSRefreshPropertySchema();

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSEnumeratePropertyDescriptions(
        PROPDESC_ENUMFILTER filterOn,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertyKeyFromName(
        [NativeTypeName("PCWSTR")] ushort* pszName,
        PROPERTYKEY* ppropkey
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetNameFromPropertyKey(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey,
        [NativeTypeName("PWSTR *")] ushort** ppszCanonicalName
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCoerceToCanonicalValue(
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertyDescriptionListFromString(
        [NativeTypeName("LPCWSTR")] ushort* pszPropList,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreatePropertyStoreFromPropertySetStorage(
        IPropertySetStorage ppss,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreatePropertyStoreFromObject(
        IUnknown punk,
        [NativeTypeName("DWORD")] uint grfMode,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreateAdapterFromPropertyStore(
        IPropertyStore pps,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertySystem(
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertyFromPropertyStorage(
        PCUSERIALIZEDPROPSTORAGE psps,
        [NativeTypeName("DWORD")] uint cb,
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* rpkey,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetNamedPropertyFromPropertyStorage(
        PCUSERIALIZEDPROPSTORAGE psps,
        [NativeTypeName("DWORD")] uint cb,
        [NativeTypeName("LPCWSTR")] ushort* pszName,
        PROPVARIANT* ppropvar
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadType(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        VARIANT* var,
        [NativeTypeName("VARTYPE")] ushort type
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadStr(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("LPWSTR")] ushort* value,
        int characterCount
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadStrAlloc(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("PWSTR *")] ushort** value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadBSTR(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("BSTR *")] ushort** value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteStr(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("LPCWSTR")] ushort* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteBSTR(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("BSTR")] ushort* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadInt(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        int* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteInt(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        int value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadSHORT(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        short* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteSHORT(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        short value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadLONG(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("LONG *")] int* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteLONG(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("LONG")] int value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadDWORD(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("DWORD *")] uint* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteDWORD(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("DWORD")] uint value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadBOOL(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        BOOL* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteBOOL(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        BOOL value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadPOINTL(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        POINTL* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WritePOINTL(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("const POINTL *")] POINTL* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadPOINTS(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        POINTS* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WritePOINTS(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("const POINTS *")] POINTS* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadRECTL(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        RECTL* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteRECTL(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("const RECTL *")] RECTL* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadStream(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        IStream* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteStream(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        IStream value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_Delete(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadULONGLONG(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("ULONGLONG *")] ulong* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteULONGLONG(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("ULONGLONG")] ulong value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadUnknown(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("const IID &")] Guid* riid,
        void** ppv
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteUnknown(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        IUnknown punk
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadGUID(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        Guid* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteGUID(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("const GUID *")] Guid* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadPropertyKey(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        PROPERTYKEY* value
    );

    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WritePropertyKey(
        IPropertyBag propBag,
        [NativeTypeName("LPCWSTR")] ushort* propName,
        [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* value
    );

    [NativeTypeName("#define PDFF_PREFERFRIENDLY static_cast<PROPDESC_FORMAT_FLAGS>(0x10000000)")]
    public const PROPDESC_FORMAT_FLAGS PDFF_PREFERFRIENDLY = (PROPDESC_FORMAT_FLAGS)(0x10000000);

    [NativeTypeName("#define GUIDSTRING_MAX (1 + 8 + 1 + 4 + 1 + 4 + 1 + 4 + 1 + 12 + 1 + 1)")]
    public const int GUIDSTRING_MAX = (1 + 8 + 1 + 4 + 1 + 4 + 1 + 4 + 1 + 12 + 1 + 1);

    [NativeTypeName("#define PKEYSTR_MAX (GUIDSTRING_MAX + 1 + PKEY_PIDSTR_MAX)")]
    public const int PKEYSTR_MAX = ((1 + 8 + 1 + 4 + 1 + 4 + 1 + 4 + 1 + 12 + 1 + 1) + 1 + 10);
}
