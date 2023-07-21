// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/propsys.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.PropVariantToWinRTPropertyValue"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT PropVariantToWinRTPropertyValue([NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WinRTPropertyValueToPropVariant"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    [SupportedOSPlatform("windows6.2")]
    public static extern HRESULT WinRTPropertyValueToPropVariant(IUnknown* punkPropertyValue, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSFormatForDisplay"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSFormatForDisplay([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdfFlags, [NativeTypeName("LPWSTR")] ushort* pwszText, [NativeTypeName("DWORD")] uint cchText);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSFormatForDisplayAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSFormatForDisplayAlloc([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, PROPDESC_FORMAT_FLAGS pdff, [NativeTypeName("PWSTR *")] ushort** ppszDisplay);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSFormatPropertyValue"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSFormatPropertyValue(IPropertyStore* pps, IPropertyDescription* ppd, PROPDESC_FORMAT_FLAGS pdff, [NativeTypeName("LPWSTR *")] ushort** ppszDisplay);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSGetImageReferenceForValue"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetImageReferenceForValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("PWSTR *")] ushort** ppszImageRes);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSStringFromPropertyKey"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSStringFromPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* pkey, [NativeTypeName("LPWSTR")] ushort* psz, uint cch);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyKeyFromString"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyKeyFromString([NativeTypeName("LPCWSTR")] ushort* pszString, PROPERTYKEY* pkey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSCreateMemoryPropertyStore"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreateMemoryPropertyStore([NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSCreateDelayedMultiplexPropertyStore"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreateDelayedMultiplexPropertyStore(GETPROPERTYSTOREFLAGS flags, IDelayedPropertyStoreFactory* pdpsf, [NativeTypeName("const DWORD *")] uint* rgStoreIds, [NativeTypeName("DWORD")] uint cStores, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSCreateMultiplexPropertyStore"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreateMultiplexPropertyStore(IUnknown** prgpunkStores, [NativeTypeName("DWORD")] uint cStores, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSCreatePropertyChangeArray"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreatePropertyChangeArray([NativeTypeName("const PROPERTYKEY *")] PROPERTYKEY* rgpropkey, [NativeTypeName("const PKA_FLAGS *")] PKA_FLAGS* rgflags, [NativeTypeName("const PROPVARIANT *")] PROPVARIANT* rgpropvar, uint cChanges, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSCreateSimplePropertyChange"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreateSimplePropertyChange(PKA_FLAGS flags, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSGetPropertyDescription"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertyDescription([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSGetPropertyDescriptionByName"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertyDescriptionByName([NativeTypeName("LPCWSTR")] ushort* pszCanonicalName, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSLookupPropertyHandlerCLSID"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSLookupPropertyHandlerCLSID([NativeTypeName("PCWSTR")] ushort* pszFilePath, [NativeTypeName("CLSID *")] Guid* pclsid);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSGetItemPropertyHandler"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetItemPropertyHandler(IUnknown* punkItem, BOOL fReadWrite, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSGetItemPropertyHandlerWithCreateObject"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetItemPropertyHandlerWithCreateObject(IUnknown* punkItem, BOOL fReadWrite, IUnknown* punkCreateObject, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSGetPropertyValue"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertyValue(IPropertyStore* pps, IPropertyDescription* ppd, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSSetPropertyValue"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSSetPropertyValue(IPropertyStore* pps, IPropertyDescription* ppd, [NativeTypeName("const PROPVARIANT &")] PROPVARIANT* propvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSRegisterPropertySchema"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSRegisterPropertySchema([NativeTypeName("PCWSTR")] ushort* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSUnregisterPropertySchema"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSUnregisterPropertySchema([NativeTypeName("PCWSTR")] ushort* pszPath);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSRefreshPropertySchema"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSRefreshPropertySchema();

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSEnumeratePropertyDescriptions"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSEnumeratePropertyDescriptions(PROPDESC_ENUMFILTER filterOn, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSGetPropertyKeyFromName"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertyKeyFromName([NativeTypeName("PCWSTR")] ushort* pszName, PROPERTYKEY* ppropkey);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSGetNameFromPropertyKey"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetNameFromPropertyKey([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* propkey, [NativeTypeName("PWSTR *")] ushort** ppszCanonicalName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSCoerceToCanonicalValue"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCoerceToCanonicalValue([NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* key, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSGetPropertyDescriptionListFromString"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertyDescriptionListFromString([NativeTypeName("LPCWSTR")] ushort* pszPropList, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSCreatePropertyStoreFromPropertySetStorage"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreatePropertyStoreFromPropertySetStorage(IPropertySetStorage* ppss, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSCreatePropertyStoreFromObject"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreatePropertyStoreFromObject(IUnknown* punk, [NativeTypeName("DWORD")] uint grfMode, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSCreateAdapterFromPropertyStore"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSCreateAdapterFromPropertyStore(IPropertyStore* pps, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSGetPropertySystem"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertySystem([NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSGetPropertyFromPropertyStorage"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetPropertyFromPropertyStorage(PCUSERIALIZEDPROPSTORAGE psps, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* rpkey, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSGetNamedPropertyFromPropertyStorage"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSGetNamedPropertyFromPropertyStorage(PCUSERIALIZEDPROPSTORAGE psps, [NativeTypeName("DWORD")] uint cb, [NativeTypeName("LPCWSTR")] ushort* pszName, PROPVARIANT* ppropvar);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadType"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadType(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, VARIANT* var, [NativeTypeName("VARTYPE")] ushort type);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadStr"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadStr(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("LPWSTR")] ushort* value, int characterCount);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadStrAlloc"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadStrAlloc(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("PWSTR *")] ushort** value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadBSTR"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadBSTR(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("BSTR *")] ushort** value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WriteStr"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteStr(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("LPCWSTR")] ushort* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WriteBSTR"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteBSTR(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("BSTR")] ushort* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadInt"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadInt(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, int* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WriteInt"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteInt(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, int value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadSHORT"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadSHORT(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, short* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WriteSHORT"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteSHORT(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, short value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadLONG"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadLONG(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("LONG *")] int* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WriteLONG"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteLONG(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("LONG")] int value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadDWORD"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadDWORD(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("DWORD *")] uint* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WriteDWORD"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteDWORD(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("DWORD")] uint value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadBOOL"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadBOOL(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, BOOL* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WriteBOOL"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteBOOL(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, BOOL value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadPOINTL"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadPOINTL(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, POINTL* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WritePOINTL"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WritePOINTL(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const POINTL *")] POINTL* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadPOINTS"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadPOINTS(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, POINTS* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WritePOINTS"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WritePOINTS(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const POINTS *")] POINTS* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadRECTL"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadRECTL(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, RECTL* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WriteRECTL"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteRECTL(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const RECTL *")] RECTL* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadStream"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadStream(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, IStream** value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WriteStream"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteStream(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, IStream* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_Delete"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_Delete(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadULONGLONG"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadULONGLONG(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("ULONGLONG *")] ulong* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WriteULONGLONG"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteULONGLONG(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("ULONGLONG")] ulong value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadUnknown"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadUnknown(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const IID &")] Guid* riid, void** ppv);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WriteUnknown"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteUnknown(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, IUnknown* punk);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadGUID"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadGUID(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, Guid* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WriteGUID"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WriteGUID(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const GUID *")] Guid* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_ReadPropertyKey"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_ReadPropertyKey(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, PROPERTYKEY* value);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.PSPropertyBag_WritePropertyKey"]/*' />
    [DllImport("propsys", ExactSpelling = true)]
    public static extern HRESULT PSPropertyBag_WritePropertyKey(IPropertyBag* propBag, [NativeTypeName("LPCWSTR")] ushort* propName, [NativeTypeName("const PROPERTYKEY &")] PROPERTYKEY* value);

    [NativeTypeName("#define PDFF_PREFERFRIENDLY static_cast<PROPDESC_FORMAT_FLAGS>(0x10000000)")]
    public const PROPDESC_FORMAT_FLAGS PDFF_PREFERFRIENDLY = (PROPDESC_FORMAT_FLAGS)(0x10000000);

    [NativeTypeName("#define GUIDSTRING_MAX (1 + 8 + 1 + 4 + 1 + 4 + 1 + 4 + 1 + 12 + 1 + 1)")]
    public const int GUIDSTRING_MAX = (1 + 8 + 1 + 4 + 1 + 4 + 1 + 4 + 1 + 12 + 1 + 1);

    [NativeTypeName("#define PKEYSTR_MAX (GUIDSTRING_MAX + 1 + PKEY_PIDSTR_MAX)")]
    public const int PKEYSTR_MAX = ((1 + 8 + 1 + 4 + 1 + 4 + 1 + 4 + 1 + 12 + 1 + 1) + 1 + 10);
}
