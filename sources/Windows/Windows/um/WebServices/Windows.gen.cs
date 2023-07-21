// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;

public static unsafe partial class Windows
{
    public const int WS_MUST_UNDERSTAND_HEADER_ATTRIBUTE = 0x1;
    public const int WS_RELAY_HEADER_ATTRIBUTE = 0x2;

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsStartReaderCanonicalization"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsStartReaderCanonicalization([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WS_WRITE_CALLBACK")] delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> writeCallback, void* writeCallbackState, [NativeTypeName("const WS_XML_CANONICALIZATION_PROPERTY *")] WS_XML_CANONICALIZATION_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsEndReaderCanonicalization"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsEndReaderCanonicalization([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsStartWriterCanonicalization"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsStartWriterCanonicalization([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_WRITE_CALLBACK")] delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> writeCallback, void* writeCallbackState, [NativeTypeName("const WS_XML_CANONICALIZATION_PROPERTY *")] WS_XML_CANONICALIZATION_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsEndWriterCanonicalization"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsEndWriterCanonicalization([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateXmlBuffer"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateXmlBuffer([NativeTypeName("WS_HEAP*")] IntPtr heap, [NativeTypeName("const WS_XML_BUFFER_PROPERTY *")] WS_XML_BUFFER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_XML_BUFFER **")] IntPtr* buffer, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRemoveNode"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRemoveNode([NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* nodePosition, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateReader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateReader([NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_XML_READER **")] IntPtr* reader, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetInput"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetInput([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("const WS_XML_READER_ENCODING *")] WS_XML_READER_ENCODING* encoding, [NativeTypeName("const WS_XML_READER_INPUT *")] WS_XML_READER_INPUT* input, [NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetInputToBuffer"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetInputToBuffer([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WS_XML_BUFFER*")] IntPtr buffer, [NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeReader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeReader([NativeTypeName("WS_XML_READER*")] IntPtr reader);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetReaderProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetReaderProperty([NativeTypeName("WS_XML_READER*")] IntPtr reader, WS_XML_READER_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetReaderNode"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetReaderNode([NativeTypeName("WS_XML_READER*")] IntPtr xmlReader, [NativeTypeName("const WS_XML_NODE **")] WS_XML_NODE** node, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFillReader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsFillReader([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadStartElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadStartElement([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadToStartElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadToStartElement([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL* found, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadStartAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadStartAttribute([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("ULONG")] uint attributeIndex, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadEndAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadEndAttribute([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadNode"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadNode([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSkipNode"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSkipNode([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadEndElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadEndElement([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFindAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsFindAttribute([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL required, [NativeTypeName("ULONG *")] uint* attributeIndex, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadValue"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadValue([NativeTypeName("WS_XML_READER*")] IntPtr reader, WS_VALUE_TYPE valueType, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadChars"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadChars([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WCHAR *")] ushort* chars, [NativeTypeName("ULONG")] uint maxCharCount, [NativeTypeName("ULONG *")] uint* actualCharCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadCharsUtf8"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadCharsUtf8([NativeTypeName("WS_XML_READER*")] IntPtr reader, byte* bytes, [NativeTypeName("ULONG")] uint maxByteCount, [NativeTypeName("ULONG *")] uint* actualByteCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadBytes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadBytes([NativeTypeName("WS_XML_READER*")] IntPtr reader, void* bytes, [NativeTypeName("ULONG")] uint maxByteCount, [NativeTypeName("ULONG *")] uint* actualByteCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadArray"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadArray([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, WS_VALUE_TYPE valueType, void* array, [NativeTypeName("ULONG")] uint arraySize, [NativeTypeName("ULONG")] uint itemOffset, [NativeTypeName("ULONG")] uint itemCount, [NativeTypeName("ULONG *")] uint* actualItemCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetReaderPosition"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetReaderPosition([NativeTypeName("WS_XML_READER*")] IntPtr reader, WS_XML_NODE_POSITION* nodePosition, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetReaderPosition"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetReaderPosition([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* nodePosition, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsMoveReader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsMoveReader([NativeTypeName("WS_XML_READER*")] IntPtr reader, WS_MOVE_TO moveTo, BOOL* found, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateWriter"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateWriter([NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_XML_WRITER **")] IntPtr* writer, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeWriter"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeWriter([NativeTypeName("WS_XML_WRITER*")] IntPtr writer);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetOutput"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetOutput([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WS_XML_WRITER_ENCODING *")] WS_XML_WRITER_ENCODING* encoding, [NativeTypeName("const WS_XML_WRITER_OUTPUT *")] WS_XML_WRITER_OUTPUT* output, [NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetOutputToBuffer"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetOutputToBuffer([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_XML_BUFFER*")] IntPtr buffer, [NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetWriterProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetWriterProperty([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, WS_XML_WRITER_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFlushWriter"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsFlushWriter([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteStartElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteStartElement([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteEndStartElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteEndStartElement([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteXmlnsAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteXmlnsAttribute([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL singleQuote, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteStartAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteStartAttribute([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL singleQuote, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteEndAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteEndAttribute([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteValue"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteValue([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, WS_VALUE_TYPE valueType, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteXmlBuffer"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteXmlBuffer([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_XML_BUFFER*")] IntPtr xmlBuffer, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadXmlBuffer"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadXmlBuffer([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WS_HEAP*")] IntPtr heap, [NativeTypeName("WS_XML_BUFFER **")] IntPtr* xmlBuffer, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteXmlBufferToBytes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteXmlBufferToBytes([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_XML_BUFFER*")] IntPtr xmlBuffer, [NativeTypeName("const WS_XML_WRITER_ENCODING *")] WS_XML_WRITER_ENCODING* encoding, [NativeTypeName("const WS_XML_WRITER_PROPERTY *")] WS_XML_WRITER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_HEAP*")] IntPtr heap, void** bytes, [NativeTypeName("ULONG *")] uint* byteCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadXmlBufferFromBytes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadXmlBufferFromBytes([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("const WS_XML_READER_ENCODING *")] WS_XML_READER_ENCODING* encoding, [NativeTypeName("const WS_XML_READER_PROPERTY *")] WS_XML_READER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const void *")] void* bytes, [NativeTypeName("ULONG")] uint byteCount, [NativeTypeName("WS_HEAP*")] IntPtr heap, [NativeTypeName("WS_XML_BUFFER **")] IntPtr* xmlBuffer, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteArray"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteArray([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, WS_VALUE_TYPE valueType, [NativeTypeName("const void *")] void* array, [NativeTypeName("ULONG")] uint arraySize, [NativeTypeName("ULONG")] uint itemOffset, [NativeTypeName("ULONG")] uint itemCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteQualifiedName"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteQualifiedName([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteChars"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteChars([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WCHAR *")] ushort* chars, [NativeTypeName("ULONG")] uint charCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteCharsUtf8"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteCharsUtf8([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const BYTE *")] byte* bytes, [NativeTypeName("ULONG")] uint byteCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteBytes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteBytes([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const void *")] void* bytes, [NativeTypeName("ULONG")] uint byteCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsPushBytes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsPushBytes([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_PUSH_BYTES_CALLBACK")] delegate* unmanaged<void*, delegate* unmanaged<void*, WS_BYTES*, uint, WS_ASYNC_CONTEXT*, IntPtr, HRESULT>, void*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> callback, void* callbackState, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsPullBytes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsPullBytes([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_PULL_BYTES_CALLBACK")] delegate* unmanaged<void*, void*, uint, uint*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> callback, void* callbackState, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteEndElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteEndElement([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteText"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteText([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WS_XML_TEXT *")] WS_XML_TEXT* text, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteStartCData"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteStartCData([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteEndCData"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteEndCData([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteNode"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteNode([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WS_XML_NODE *")] WS_XML_NODE* node, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetPrefixFromNamespace"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetPrefixFromNamespace([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* ns, BOOL required, [NativeTypeName("const WS_XML_STRING **")] WS_XML_STRING** prefix, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetWriterPosition"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetWriterPosition([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, WS_XML_NODE_POSITION* nodePosition, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetWriterPosition"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetWriterPosition([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* nodePosition, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsMoveWriter"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsMoveWriter([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, WS_MOVE_TO moveTo, BOOL* found, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsTrimXmlWhitespace"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsTrimXmlWhitespace([NativeTypeName("WCHAR *")] ushort* chars, [NativeTypeName("ULONG")] uint charCount, [NativeTypeName("WCHAR **")] ushort** trimmedChars, [NativeTypeName("ULONG *")] uint* trimmedCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsVerifyXmlNCName"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsVerifyXmlNCName([NativeTypeName("const WCHAR *")] ushort* ncNameChars, [NativeTypeName("ULONG")] uint ncNameCharCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsXmlStringEquals"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsXmlStringEquals([NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* string1, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* string2, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetNamespaceFromPrefix"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetNamespaceFromPrefix([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* prefix, BOOL required, [NativeTypeName("const WS_XML_STRING **")] WS_XML_STRING** ns, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadQualifiedName"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadQualifiedName([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WS_HEAP*")] IntPtr heap, WS_XML_STRING* prefix, WS_XML_STRING* localName, WS_XML_STRING* ns, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetXmlAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetXmlAttribute([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* localName, [NativeTypeName("WS_HEAP*")] IntPtr heap, [NativeTypeName("WCHAR **")] ushort** valueChars, [NativeTypeName("ULONG *")] uint* valueCharCount, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCopyNode"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCopyNode([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAsyncExecute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAsyncExecute(WS_ASYNC_STATE* asyncState, [NativeTypeName("WS_ASYNC_FUNCTION")] delegate* unmanaged<HRESULT, WS_CALLBACK_MODEL, void*, WS_ASYNC_OPERATION*, WS_ASYNC_CONTEXT*, IntPtr, HRESULT> operation, WS_CALLBACK_MODEL callbackModel, void* callbackState, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateChannel(WS_CHANNEL_TYPE channelType, WS_CHANNEL_BINDING channelBinding, [NativeTypeName("const WS_CHANNEL_PROPERTY *")] WS_CHANNEL_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const WS_SECURITY_DESCRIPTION *")] WS_SECURITY_DESCRIPTION* securityDescription, [NativeTypeName("WS_CHANNEL **")] IntPtr* channel, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsOpenChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsOpenChannel([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("const WS_ENDPOINT_ADDRESS *")] WS_ENDPOINT_ADDRESS* endpointAddress, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSendMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSendMessage([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* messageDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* bodyValue, [NativeTypeName("ULONG")] uint bodyValueSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReceiveMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReceiveMessage([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_MESSAGE_DESCRIPTION **")] WS_MESSAGE_DESCRIPTION** messageDescriptions, [NativeTypeName("ULONG")] uint messageDescriptionCount, WS_RECEIVE_OPTION receiveOption, WS_READ_OPTION readBodyOption, [NativeTypeName("WS_HEAP*")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("ULONG *")] uint* index, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRequestReply"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRequestReply([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("WS_MESSAGE*")] IntPtr requestMessage, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* requestMessageDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* requestBodyValue, [NativeTypeName("ULONG")] uint requestBodyValueSize, [NativeTypeName("WS_MESSAGE*")] IntPtr replyMessage, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* replyMessageDescription, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP*")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSendReplyMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSendReplyMessage([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("WS_MESSAGE*")] IntPtr replyMessage, [NativeTypeName("const WS_MESSAGE_DESCRIPTION *")] WS_MESSAGE_DESCRIPTION* replyMessageDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* replyBodyValue, [NativeTypeName("ULONG")] uint replyBodyValueSize, [NativeTypeName("WS_MESSAGE*")] IntPtr requestMessage, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSendFaultMessageForError"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSendFaultMessageForError([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("WS_MESSAGE*")] IntPtr replyMessage, [NativeTypeName("WS_ERROR*")] IntPtr faultError, HRESULT faultErrorCode, WS_FAULT_DISCLOSURE faultDisclosure, [NativeTypeName("WS_MESSAGE*")] IntPtr requestMessage, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetChannelProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetChannelProperty([NativeTypeName("WS_CHANNEL*")] IntPtr channel, WS_CHANNEL_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetChannelProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetChannelProperty([NativeTypeName("WS_CHANNEL*")] IntPtr channel, WS_CHANNEL_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteMessageStart"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteMessageStart([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteMessageEnd"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteMessageEnd([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadMessageStart"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadMessageStart([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadMessageEnd"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadMessageEnd([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCloseChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCloseChannel([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAbortChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAbortChannel([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeChannel([NativeTypeName("WS_CHANNEL*")] IntPtr channel);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetChannel([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAbandonMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAbandonMessage([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsShutdownSessionChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsShutdownSessionChannel([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetOperationContextProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetOperationContextProperty([NativeTypeName("const WS_OPERATION_CONTEXT *")] IntPtr context, [NativeTypeName("const WS_OPERATION_CONTEXT_PROPERTY_ID")] WS_OPERATION_CONTEXT_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetDictionary"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetDictionary(WS_ENCODING encoding, WS_XML_DICTIONARY** dictionary, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadEndpointAddressExtension"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadEndpointAddressExtension([NativeTypeName("WS_XML_READER*")] IntPtr reader, WS_ENDPOINT_ADDRESS* endpointAddress, WS_ENDPOINT_ADDRESS_EXTENSION_TYPE extensionType, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP*")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateError"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateError([NativeTypeName("const WS_ERROR_PROPERTY *")] WS_ERROR_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_ERROR **")] IntPtr* error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAddErrorString"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAddErrorString([NativeTypeName("WS_ERROR*")] IntPtr error, [NativeTypeName("const WS_STRING *")] WS_STRING* @string);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetErrorString"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetErrorString([NativeTypeName("WS_ERROR*")] IntPtr error, [NativeTypeName("ULONG")] uint index, WS_STRING* @string);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCopyError"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCopyError([NativeTypeName("WS_ERROR*")] IntPtr source, [NativeTypeName("WS_ERROR*")] IntPtr destination);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetErrorProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetErrorProperty([NativeTypeName("WS_ERROR*")] IntPtr error, WS_ERROR_PROPERTY_ID id, void* buffer, [NativeTypeName("ULONG")] uint bufferSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetErrorProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetErrorProperty([NativeTypeName("WS_ERROR*")] IntPtr error, WS_ERROR_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetError"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetError([NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeError"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeError([NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetFaultErrorProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetFaultErrorProperty([NativeTypeName("WS_ERROR*")] IntPtr error, WS_FAULT_ERROR_PROPERTY_ID id, void* buffer, [NativeTypeName("ULONG")] uint bufferSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetFaultErrorProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetFaultErrorProperty([NativeTypeName("WS_ERROR*")] IntPtr error, WS_FAULT_ERROR_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateFaultFromError"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateFaultFromError([NativeTypeName("WS_ERROR*")] IntPtr error, HRESULT faultErrorCode, WS_FAULT_DISCLOSURE faultDisclosure, [NativeTypeName("WS_HEAP*")] IntPtr heap, WS_FAULT* fault);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetFaultErrorDetail"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetFaultErrorDetail([NativeTypeName("WS_ERROR*")] IntPtr error, [NativeTypeName("const WS_FAULT_DETAIL_DESCRIPTION *")] WS_FAULT_DETAIL_DESCRIPTION* faultDetailDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetFaultErrorDetail"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetFaultErrorDetail([NativeTypeName("WS_ERROR*")] IntPtr error, [NativeTypeName("const WS_FAULT_DETAIL_DESCRIPTION *")] WS_FAULT_DETAIL_DESCRIPTION* faultDetailDescription, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP*")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateHeap"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateHeap([NativeTypeName("SIZE_T")] nuint maxSize, [NativeTypeName("SIZE_T")] nuint trimSize, [NativeTypeName("const WS_HEAP_PROPERTY *")] WS_HEAP_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_HEAP **")] IntPtr* heap, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAlloc"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAlloc([NativeTypeName("WS_HEAP*")] IntPtr heap, [NativeTypeName("SIZE_T")] nuint size, void** ptr, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetHeapProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetHeapProperty([NativeTypeName("WS_HEAP*")] IntPtr heap, WS_HEAP_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetHeap"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetHeap([NativeTypeName("WS_HEAP*")] IntPtr heap, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeHeap"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeHeap([NativeTypeName("WS_HEAP*")] IntPtr heap);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateListener(WS_CHANNEL_TYPE channelType, WS_CHANNEL_BINDING channelBinding, [NativeTypeName("const WS_LISTENER_PROPERTY *")] WS_LISTENER_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const WS_SECURITY_DESCRIPTION *")] WS_SECURITY_DESCRIPTION* securityDescription, [NativeTypeName("WS_LISTENER **")] IntPtr* listener, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsOpenListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsOpenListener([NativeTypeName("WS_LISTENER*")] IntPtr listener, [NativeTypeName("const WS_STRING *")] WS_STRING* url, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAcceptChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAcceptChannel([NativeTypeName("WS_LISTENER*")] IntPtr listener, [NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCloseListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCloseListener([NativeTypeName("WS_LISTENER*")] IntPtr listener, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAbortListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAbortListener([NativeTypeName("WS_LISTENER*")] IntPtr listener, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetListener([NativeTypeName("WS_LISTENER*")] IntPtr listener, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeListener([NativeTypeName("WS_LISTENER*")] IntPtr listener);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetListenerProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetListenerProperty([NativeTypeName("WS_LISTENER*")] IntPtr listener, WS_LISTENER_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetListenerProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetListenerProperty([NativeTypeName("WS_LISTENER*")] IntPtr listener, WS_LISTENER_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateChannelForListener"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateChannelForListener([NativeTypeName("WS_LISTENER*")] IntPtr listener, [NativeTypeName("const WS_CHANNEL_PROPERTY *")] WS_CHANNEL_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_CHANNEL **")] IntPtr* channel, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateMessage(WS_ENVELOPE_VERSION envelopeVersion, WS_ADDRESSING_VERSION addressingVersion, [NativeTypeName("const WS_MESSAGE_PROPERTY *")] WS_MESSAGE_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_MESSAGE **")] IntPtr* message, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateMessageForChannel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateMessageForChannel([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("const WS_MESSAGE_PROPERTY *")] WS_MESSAGE_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_MESSAGE **")] IntPtr* message, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsInitializeMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsInitializeMessage([NativeTypeName("WS_MESSAGE*")] IntPtr message, WS_MESSAGE_INITIALIZATION initialization, [NativeTypeName("WS_MESSAGE*")] IntPtr sourceMessage, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetMessage([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeMessage([NativeTypeName("WS_MESSAGE*")] IntPtr message);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetHeaderAttributes"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetHeaderAttributes([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("ULONG *")] uint* headerAttributes, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetHeader([NativeTypeName("WS_MESSAGE*")] IntPtr message, WS_HEADER_TYPE headerType, WS_TYPE valueType, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP*")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetCustomHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetCustomHeader([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* customHeaderDescription, WS_REPEATING_HEADER_OPTION repeatingOption, [NativeTypeName("ULONG")] uint headerIndex, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP*")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("ULONG *")] uint* headerAttributes, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRemoveHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRemoveHeader([NativeTypeName("WS_MESSAGE*")] IntPtr message, WS_HEADER_TYPE headerType, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetHeader([NativeTypeName("WS_MESSAGE*")] IntPtr message, WS_HEADER_TYPE headerType, WS_TYPE valueType, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRemoveCustomHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRemoveCustomHeader([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerNs, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAddCustomHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAddCustomHeader([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* headerDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("ULONG")] uint headerAttributes, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAddMappedHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAddMappedHeader([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, WS_TYPE valueType, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRemoveMappedHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRemoveMappedHeader([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetMappedHeader"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetMappedHeader([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_XML_STRING *")] WS_XML_STRING* headerName, WS_REPEATING_HEADER_OPTION repeatingOption, [NativeTypeName("ULONG")] uint headerIndex, WS_TYPE valueType, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP*")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteBody"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteBody([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* bodyDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadBody"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadBody([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* bodyDescription, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP*")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteEnvelopeStart"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteEnvelopeStart([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("WS_MESSAGE_DONE_CALLBACK")] delegate* unmanaged<void*, void> doneCallback, void* doneCallbackState, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteEnvelopeEnd"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteEnvelopeEnd([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadEnvelopeStart"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadEnvelopeStart([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("WS_MESSAGE_DONE_CALLBACK")] delegate* unmanaged<void*, void> doneCallback, void* doneCallbackState, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadEnvelopeEnd"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadEnvelopeEnd([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetMessageProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetMessageProperty([NativeTypeName("WS_MESSAGE*")] IntPtr message, WS_MESSAGE_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsSetMessageProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsSetMessageProperty([NativeTypeName("WS_MESSAGE*")] IntPtr message, WS_MESSAGE_PROPERTY_ID id, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAddressMessage"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAddressMessage([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_ENDPOINT_ADDRESS *")] WS_ENDPOINT_ADDRESS* address, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCheckMustUnderstandHeaders"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCheckMustUnderstandHeaders([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsMarkHeaderAsUnderstood"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsMarkHeaderAsUnderstood([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("const WS_XML_NODE_POSITION *")] WS_XML_NODE_POSITION* headerPosition, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFillBody"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsFillBody([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFlushBody"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsFlushBody([NativeTypeName("WS_MESSAGE*")] IntPtr message, [NativeTypeName("ULONG")] uint minSize, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRequestSecurityToken"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRequestSecurityToken([NativeTypeName("WS_CHANNEL*")] IntPtr channel, [NativeTypeName("const WS_REQUEST_SECURITY_TOKEN_PROPERTY *")] WS_REQUEST_SECURITY_TOKEN_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_SECURITY_TOKEN **")] IntPtr* token, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetSecurityTokenProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetSecurityTokenProperty([NativeTypeName("WS_SECURITY_TOKEN*")] IntPtr securityToken, WS_SECURITY_TOKEN_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_HEAP*")] IntPtr heap, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateXmlSecurityToken"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateXmlSecurityToken([NativeTypeName("WS_XML_BUFFER*")] IntPtr tokenXml, WS_SECURITY_KEY_HANDLE* tokenKey, [NativeTypeName("const WS_XML_SECURITY_TOKEN_PROPERTY *")] WS_XML_SECURITY_TOKEN_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_SECURITY_TOKEN **")] IntPtr* token, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeSecurityToken"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeSecurityToken([NativeTypeName("WS_SECURITY_TOKEN*")] IntPtr token);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRevokeSecurityContext"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRevokeSecurityContext([NativeTypeName("WS_SECURITY_CONTEXT*")] IntPtr securityContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetSecurityContextProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetSecurityContextProperty([NativeTypeName("WS_SECURITY_CONTEXT*")] IntPtr securityContext, WS_SECURITY_CONTEXT_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadElement([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* elementDescription, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP*")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadAttribute([NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("const WS_ATTRIBUTE_DESCRIPTION *")] WS_ATTRIBUTE_DESCRIPTION* attributeDescription, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP*")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadType"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadType([NativeTypeName("WS_XML_READER*")] IntPtr reader, WS_TYPE_MAPPING typeMapping, WS_TYPE type, [NativeTypeName("const void *")] void* typeDescription, WS_READ_OPTION readOption, [NativeTypeName("WS_HEAP*")] IntPtr heap, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteElement"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteElement([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WS_ELEMENT_DESCRIPTION *")] WS_ELEMENT_DESCRIPTION* elementDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteAttribute"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteAttribute([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, [NativeTypeName("const WS_ATTRIBUTE_DESCRIPTION *")] WS_ATTRIBUTE_DESCRIPTION* attributeDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsWriteType"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsWriteType([NativeTypeName("WS_XML_WRITER*")] IntPtr writer, WS_TYPE_MAPPING typeMapping, WS_TYPE type, [NativeTypeName("const void *")] void* typeDescription, WS_WRITE_OPTION writeOption, [NativeTypeName("const void *")] void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsRegisterOperationForCancel"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsRegisterOperationForCancel([NativeTypeName("const WS_OPERATION_CONTEXT *")] IntPtr context, [NativeTypeName("WS_OPERATION_CANCEL_CALLBACK")] delegate* unmanaged<WS_SERVICE_CANCEL_REASON, void*, void> cancelCallback, [NativeTypeName("WS_OPERATION_FREE_STATE_CALLBACK")] delegate* unmanaged<void*, void> freestateCallback, void* userState, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetServiceHostProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetServiceHostProperty([NativeTypeName("WS_SERVICE_HOST*")] IntPtr serviceHost, [NativeTypeName("const WS_SERVICE_PROPERTY_ID")] WS_SERVICE_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateServiceHost"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateServiceHost([NativeTypeName("const WS_SERVICE_ENDPOINT **")] WS_SERVICE_ENDPOINT** endpoints, [NativeTypeName("const USHORT")] ushort endpointCount, [NativeTypeName("const WS_SERVICE_PROPERTY *")] WS_SERVICE_PROPERTY* serviceProperties, [NativeTypeName("ULONG")] uint servicePropertyCount, [NativeTypeName("WS_SERVICE_HOST **")] IntPtr* serviceHost, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsOpenServiceHost"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsOpenServiceHost([NativeTypeName("WS_SERVICE_HOST*")] IntPtr serviceHost, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCloseServiceHost"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCloseServiceHost([NativeTypeName("WS_SERVICE_HOST*")] IntPtr serviceHost, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAbortServiceHost"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAbortServiceHost([NativeTypeName("WS_SERVICE_HOST*")] IntPtr serviceHost, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeServiceHost"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeServiceHost([NativeTypeName("WS_SERVICE_HOST*")] IntPtr serviceHost);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetServiceHost"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetServiceHost([NativeTypeName("WS_SERVICE_HOST*")] IntPtr serviceHost, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetServiceProxyProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetServiceProxyProperty([NativeTypeName("WS_SERVICE_PROXY*")] IntPtr serviceProxy, [NativeTypeName("const WS_PROXY_PROPERTY_ID")] WS_PROXY_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateServiceProxy"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateServiceProxy([NativeTypeName("const WS_CHANNEL_TYPE")] WS_CHANNEL_TYPE channelType, [NativeTypeName("const WS_CHANNEL_BINDING")] WS_CHANNEL_BINDING channelBinding, [NativeTypeName("const WS_SECURITY_DESCRIPTION *")] WS_SECURITY_DESCRIPTION* securityDescription, [NativeTypeName("const WS_PROXY_PROPERTY *")] WS_PROXY_PROPERTY* properties, [NativeTypeName("const ULONG")] uint propertyCount, [NativeTypeName("const WS_CHANNEL_PROPERTY *")] WS_CHANNEL_PROPERTY* channelProperties, [NativeTypeName("const ULONG")] uint channelPropertyCount, [NativeTypeName("WS_SERVICE_PROXY **")] IntPtr* serviceProxy, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsOpenServiceProxy"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsOpenServiceProxy([NativeTypeName("WS_SERVICE_PROXY*")] IntPtr serviceProxy, [NativeTypeName("const WS_ENDPOINT_ADDRESS *")] WS_ENDPOINT_ADDRESS* address, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCloseServiceProxy"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCloseServiceProxy([NativeTypeName("WS_SERVICE_PROXY*")] IntPtr serviceProxy, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAbortServiceProxy"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAbortServiceProxy([NativeTypeName("WS_SERVICE_PROXY*")] IntPtr serviceProxy, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeServiceProxy"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeServiceProxy([NativeTypeName("WS_SERVICE_PROXY*")] IntPtr serviceProxy);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetServiceProxy"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetServiceProxy([NativeTypeName("WS_SERVICE_PROXY*")] IntPtr serviceProxy, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsAbandonCall"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsAbandonCall([NativeTypeName("WS_SERVICE_PROXY*")] IntPtr serviceProxy, [NativeTypeName("ULONG")] uint callId, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCall"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCall([NativeTypeName("WS_SERVICE_PROXY*")] IntPtr serviceProxy, [NativeTypeName("const WS_OPERATION_DESCRIPTION *")] WS_OPERATION_DESCRIPTION* operation, [NativeTypeName("const void **")] void** arguments, [NativeTypeName("WS_HEAP*")] IntPtr heap, [NativeTypeName("const WS_CALL_PROPERTY *")] WS_CALL_PROPERTY* callProperties, [NativeTypeName("const ULONG")] uint callPropertyCount, [NativeTypeName("const WS_ASYNC_CONTEXT *")] WS_ASYNC_CONTEXT* asyncContext, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsDecodeUrl"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsDecodeUrl([NativeTypeName("const WS_STRING *")] WS_STRING* url, [NativeTypeName("ULONG")] uint flags, [NativeTypeName("WS_HEAP*")] IntPtr heap, WS_URL** outUrl, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsEncodeUrl"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsEncodeUrl([NativeTypeName("const WS_URL *")] WS_URL* url, [NativeTypeName("ULONG")] uint flags, [NativeTypeName("WS_HEAP*")] IntPtr heap, WS_STRING* outUrl, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCombineUrl"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCombineUrl([NativeTypeName("const WS_STRING *")] WS_STRING* baseUrl, [NativeTypeName("const WS_STRING *")] WS_STRING* referenceUrl, [NativeTypeName("ULONG")] uint flags, [NativeTypeName("WS_HEAP*")] IntPtr heap, WS_STRING* resultUrl, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsDateTimeToFileTime"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsDateTimeToFileTime([NativeTypeName("const WS_DATETIME *")] WS_DATETIME* dateTime, FILETIME* fileTime, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFileTimeToDateTime"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsFileTimeToDateTime([NativeTypeName("const FILETIME *")] FILETIME* fileTime, WS_DATETIME* dateTime, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateMetadata"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateMetadata([NativeTypeName("const WS_METADATA_PROPERTY *")] WS_METADATA_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("WS_METADATA **")] IntPtr* metadata, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsReadMetadata"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsReadMetadata([NativeTypeName("WS_METADATA*")] IntPtr metadata, [NativeTypeName("WS_XML_READER*")] IntPtr reader, [NativeTypeName("const WS_STRING *")] WS_STRING* url, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsFreeMetadata"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern void WsFreeMetadata([NativeTypeName("WS_METADATA*")] IntPtr metadata);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsResetMetadata"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsResetMetadata([NativeTypeName("WS_METADATA*")] IntPtr metadata, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetMetadataProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetMetadataProperty([NativeTypeName("WS_METADATA*")] IntPtr metadata, WS_METADATA_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetMissingMetadataDocumentAddress"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetMissingMetadataDocumentAddress([NativeTypeName("WS_METADATA*")] IntPtr metadata, WS_ENDPOINT_ADDRESS** address, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetMetadataEndpoints"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetMetadataEndpoints([NativeTypeName("WS_METADATA*")] IntPtr metadata, WS_METADATA_ENDPOINTS* endpoints, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsMatchPolicyAlternative"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsMatchPolicyAlternative([NativeTypeName("WS_POLICY*")] IntPtr policy, [NativeTypeName("ULONG")] uint alternativeIndex, WS_POLICY_CONSTRAINTS* policyConstraints, BOOL matchRequired, [NativeTypeName("WS_HEAP*")] IntPtr heap, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetPolicyProperty"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetPolicyProperty([NativeTypeName("WS_POLICY*")] IntPtr policy, WS_POLICY_PROPERTY_ID id, void* value, [NativeTypeName("ULONG")] uint valueSize, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsGetPolicyAlternativeCount"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsGetPolicyAlternativeCount([NativeTypeName("WS_POLICY*")] IntPtr policy, [NativeTypeName("ULONG *")] uint* count, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateServiceProxyFromTemplate"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateServiceProxyFromTemplate(WS_CHANNEL_TYPE channelType, [NativeTypeName("const WS_PROXY_PROPERTY *")] WS_PROXY_PROPERTY* properties, [NativeTypeName("const ULONG")] uint propertyCount, WS_BINDING_TEMPLATE_TYPE templateType, void* templateValue, [NativeTypeName("ULONG")] uint templateSize, [NativeTypeName("const void *")] void* templateDescription, [NativeTypeName("ULONG")] uint templateDescriptionSize, [NativeTypeName("WS_SERVICE_PROXY **")] IntPtr* serviceProxy, [NativeTypeName("WS_ERROR*")] IntPtr error);

    /// <include file='Windows.xml' path='doc/member[@name="Windows.WsCreateServiceEndpointFromTemplate"]/*' />
    [DllImport("webservices", ExactSpelling = true)]
    public static extern HRESULT WsCreateServiceEndpointFromTemplate(WS_CHANNEL_TYPE channelType, [NativeTypeName("const WS_SERVICE_ENDPOINT_PROPERTY *")] WS_SERVICE_ENDPOINT_PROPERTY* properties, [NativeTypeName("ULONG")] uint propertyCount, [NativeTypeName("const WS_STRING *")] WS_STRING* addressUrl, [NativeTypeName("const WS_SERVICE_CONTRACT *")] WS_SERVICE_CONTRACT* contract, [NativeTypeName("WS_SERVICE_SECURITY_CALLBACK")] delegate* unmanaged<IntPtr, BOOL*, IntPtr, HRESULT> authorizationCallback, [NativeTypeName("WS_HEAP*")] IntPtr heap, WS_BINDING_TEMPLATE_TYPE templateType, void* templateValue, [NativeTypeName("ULONG")] uint templateSize, [NativeTypeName("const void *")] void* templateDescription, [NativeTypeName("ULONG")] uint templateDescriptionSize, WS_SERVICE_ENDPOINT** serviceEndpoint, [NativeTypeName("WS_ERROR*")] IntPtr error);
}
