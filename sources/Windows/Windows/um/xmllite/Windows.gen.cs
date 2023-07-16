// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xmllite.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
public static unsafe partial class Windows
{
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateXmlReader"]/*'/>
    [DllImport("xmllite", ExactSpelling = true)]
    public static extern HRESULT CreateXmlReader([NativeTypeName("const IID &")] Guid* riid, void** ppvObject, IMalloc* pMalloc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateXmlReaderInputWithEncodingCodePage"]/*'/>
    [DllImport("xmllite", ExactSpelling = true)]
    public static extern HRESULT CreateXmlReaderInputWithEncodingCodePage(IUnknown* pInputStream, IMalloc* pMalloc, uint nEncodingCodePage, BOOL fEncodingHint, [NativeTypeName("LPCWSTR")] ushort* pwszBaseUri, [NativeTypeName("IXmlReaderInput **")] IUnknown** ppInput);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateXmlReaderInputWithEncodingName"]/*'/>
    [DllImport("xmllite", ExactSpelling = true)]
    public static extern HRESULT CreateXmlReaderInputWithEncodingName(IUnknown* pInputStream, IMalloc* pMalloc, [NativeTypeName("LPCWSTR")] ushort* pwszEncodingName, BOOL fEncodingHint, [NativeTypeName("LPCWSTR")] ushort* pwszBaseUri, [NativeTypeName("IXmlReaderInput **")] IUnknown** ppInput);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateXmlWriter"]/*'/>
    [DllImport("xmllite", ExactSpelling = true)]
    public static extern HRESULT CreateXmlWriter([NativeTypeName("const IID &")] Guid* riid, void** ppvObject, IMalloc* pMalloc);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateXmlWriterOutputWithEncodingCodePage"]/*'/>
    [DllImport("xmllite", ExactSpelling = true)]
    public static extern HRESULT CreateXmlWriterOutputWithEncodingCodePage(IUnknown* pOutputStream, IMalloc* pMalloc, uint nEncodingCodePage, [NativeTypeName("IXmlWriterOutput **")] IUnknown** ppOutput);
    /// <include file='Windows.xml' path='doc/member[@name="Windows.CreateXmlWriterOutputWithEncodingName"]/*'/>
    [DllImport("xmllite", ExactSpelling = true)]
    public static extern HRESULT CreateXmlWriterOutputWithEncodingName(IUnknown* pOutputStream, IMalloc* pMalloc, [NativeTypeName("LPCWSTR")] ushort* pwszEncodingName, [NativeTypeName("IXmlWriterOutput **")] IUnknown** ppOutput);
}