// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API"]/*'/>
public enum WS_TRACE_API
{
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_NONE"]/*'/>
    WS_TRACE_API_NONE = -1,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_START_READER_CANONICALIZATION"]/*'/>
    WS_TRACE_API_START_READER_CANONICALIZATION = 0,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_END_READER_CANONICALIZATION"]/*'/>
    WS_TRACE_API_END_READER_CANONICALIZATION = 1,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_START_WRITER_CANONICALIZATION"]/*'/>
    WS_TRACE_API_START_WRITER_CANONICALIZATION = 2,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_END_WRITER_CANONICALIZATION"]/*'/>
    WS_TRACE_API_END_WRITER_CANONICALIZATION = 3,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_XML_BUFFER"]/*'/>
    WS_TRACE_API_CREATE_XML_BUFFER = 4,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_REMOVE_NODE"]/*'/>
    WS_TRACE_API_REMOVE_NODE = 5,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_READER"]/*'/>
    WS_TRACE_API_CREATE_READER = 6,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_INPUT"]/*'/>
    WS_TRACE_API_SET_INPUT = 7,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_INPUT_TO_BUFFER"]/*'/>
    WS_TRACE_API_SET_INPUT_TO_BUFFER = 8,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FREE_XML_READER"]/*'/>
    WS_TRACE_API_FREE_XML_READER = 9,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_READER_PROPERTY"]/*'/>
    WS_TRACE_API_GET_READER_PROPERTY = 10,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_READER_NODE"]/*'/>
    WS_TRACE_API_GET_READER_NODE = 11,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FILL_READER"]/*'/>
    WS_TRACE_API_FILL_READER = 12,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_START_ELEMENT"]/*'/>
    WS_TRACE_API_READ_START_ELEMENT = 13,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_TO_START_ELEMENT"]/*'/>
    WS_TRACE_API_READ_TO_START_ELEMENT = 14,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_START_ATTRIBUTE"]/*'/>
    WS_TRACE_API_READ_START_ATTRIBUTE = 15,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_END_ATTRIBUTE"]/*'/>
    WS_TRACE_API_READ_END_ATTRIBUTE = 16,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_NODE"]/*'/>
    WS_TRACE_API_READ_NODE = 17,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SKIP_NODE"]/*'/>
    WS_TRACE_API_SKIP_NODE = 18,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_END_ELEMENT"]/*'/>
    WS_TRACE_API_READ_END_ELEMENT = 19,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FIND_ATTRIBUTE"]/*'/>
    WS_TRACE_API_FIND_ATTRIBUTE = 20,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_ELEMENT_VALUE"]/*'/>
    WS_TRACE_API_READ_ELEMENT_VALUE = 21,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_CHARS"]/*'/>
    WS_TRACE_API_READ_CHARS = 22,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_CHARS_UTF8"]/*'/>
    WS_TRACE_API_READ_CHARS_UTF8 = 23,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_BYTES"]/*'/>
    WS_TRACE_API_READ_BYTES = 24,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_ARRAY"]/*'/>
    WS_TRACE_API_READ_ARRAY = 25,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_READER_POSITION"]/*'/>
    WS_TRACE_API_GET_READER_POSITION = 26,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_READER_POSITION"]/*'/>
    WS_TRACE_API_SET_READER_POSITION = 27,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_MOVE_READER"]/*'/>
    WS_TRACE_API_MOVE_READER = 28,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_WRITER"]/*'/>
    WS_TRACE_API_CREATE_WRITER = 29,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FREE_XML_WRITER"]/*'/>
    WS_TRACE_API_FREE_XML_WRITER = 30,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_OUTPUT"]/*'/>
    WS_TRACE_API_SET_OUTPUT = 31,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_OUTPUT_TO_BUFFER"]/*'/>
    WS_TRACE_API_SET_OUTPUT_TO_BUFFER = 32,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_WRITER_PROPERTY"]/*'/>
    WS_TRACE_API_GET_WRITER_PROPERTY = 33,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FLUSH_WRITER"]/*'/>
    WS_TRACE_API_FLUSH_WRITER = 34,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_START_ELEMENT"]/*'/>
    WS_TRACE_API_WRITE_START_ELEMENT = 35,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_END_START_ELEMENT"]/*'/>
    WS_TRACE_API_WRITE_END_START_ELEMENT = 36,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_XMLNS_ATTRIBUTE"]/*'/>
    WS_TRACE_API_WRITE_XMLNS_ATTRIBUTE = 37,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_START_ATTRIBUTE"]/*'/>
    WS_TRACE_API_WRITE_START_ATTRIBUTE = 38,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_END_ATTRIBUTE"]/*'/>
    WS_TRACE_API_WRITE_END_ATTRIBUTE = 39,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_VALUE"]/*'/>
    WS_TRACE_API_WRITE_VALUE = 40,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_XML_BUFFER"]/*'/>
    WS_TRACE_API_WRITE_XML_BUFFER = 41,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_XML_BUFFER"]/*'/>
    WS_TRACE_API_READ_XML_BUFFER = 42,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_XML_BUFFER_TO_BYTES"]/*'/>
    WS_TRACE_API_WRITE_XML_BUFFER_TO_BYTES = 43,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_XML_BUFFER_FROM_BYTES"]/*'/>
    WS_TRACE_API_READ_XML_BUFFER_FROM_BYTES = 44,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_ARRAY"]/*'/>
    WS_TRACE_API_WRITE_ARRAY = 45,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_QUALIFIED_NAME"]/*'/>
    WS_TRACE_API_WRITE_QUALIFIED_NAME = 46,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_CHARS"]/*'/>
    WS_TRACE_API_WRITE_CHARS = 47,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_CHARS_UTF8"]/*'/>
    WS_TRACE_API_WRITE_CHARS_UTF8 = 48,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_BYTES"]/*'/>
    WS_TRACE_API_WRITE_BYTES = 49,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_PUSH_BYTES"]/*'/>
    WS_TRACE_API_PUSH_BYTES = 50,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_PULL_BYTES"]/*'/>
    WS_TRACE_API_PULL_BYTES = 51,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_END_ELEMENT"]/*'/>
    WS_TRACE_API_WRITE_END_ELEMENT = 52,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_TEXT"]/*'/>
    WS_TRACE_API_WRITE_TEXT = 53,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_START_CDATA"]/*'/>
    WS_TRACE_API_WRITE_START_CDATA = 54,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_END_CDATA"]/*'/>
    WS_TRACE_API_WRITE_END_CDATA = 55,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_NODE"]/*'/>
    WS_TRACE_API_WRITE_NODE = 56,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_PREFIX_FROM_NAMESPACE"]/*'/>
    WS_TRACE_API_PREFIX_FROM_NAMESPACE = 57,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_WRITER_POSITION"]/*'/>
    WS_TRACE_API_GET_WRITER_POSITION = 58,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_WRITER_POSITION"]/*'/>
    WS_TRACE_API_SET_WRITER_POSITION = 59,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_MOVE_WRITER"]/*'/>
    WS_TRACE_API_MOVE_WRITER = 60,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_TRIM_XML_WHITESPACE"]/*'/>
    WS_TRACE_API_TRIM_XML_WHITESPACE = 61,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_VERIFY_XML_NCNAME"]/*'/>
    WS_TRACE_API_VERIFY_XML_NCNAME = 62,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_XML_STRING_EQUALS"]/*'/>
    WS_TRACE_API_XML_STRING_EQUALS = 63,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_NAMESPACE_FROM_PREFIX"]/*'/>
    WS_TRACE_API_NAMESPACE_FROM_PREFIX = 64,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_QUALIFIED_NAME"]/*'/>
    WS_TRACE_API_READ_QUALIFIED_NAME = 65,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_XML_ATTRIBUTE"]/*'/>
    WS_TRACE_API_GET_XML_ATTRIBUTE = 66,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_COPY_NODE"]/*'/>
    WS_TRACE_API_COPY_NODE = 67,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ASYNC_EXECUTE"]/*'/>
    WS_TRACE_API_ASYNC_EXECUTE = 68,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_CHANNEL"]/*'/>
    WS_TRACE_API_CREATE_CHANNEL = 69,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_OPEN_CHANNEL"]/*'/>
    WS_TRACE_API_OPEN_CHANNEL = 70,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SEND_MESSAGE"]/*'/>
    WS_TRACE_API_SEND_MESSAGE = 71,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_RECEIVE_MESSAGE"]/*'/>
    WS_TRACE_API_RECEIVE_MESSAGE = 72,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_REQUEST_REPLY"]/*'/>
    WS_TRACE_API_REQUEST_REPLY = 73,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SEND_REPLY_MESSAGE"]/*'/>
    WS_TRACE_API_SEND_REPLY_MESSAGE = 74,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SEND_FAULT_MESSAGE_FOR_ERROR"]/*'/>
    WS_TRACE_API_SEND_FAULT_MESSAGE_FOR_ERROR = 75,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_CHANNEL_PROPERTY"]/*'/>
    WS_TRACE_API_GET_CHANNEL_PROPERTY = 76,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_CHANNEL_PROPERTY"]/*'/>
    WS_TRACE_API_SET_CHANNEL_PROPERTY = 77,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_MESSAGE_START"]/*'/>
    WS_TRACE_API_WRITE_MESSAGE_START = 78,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_MESSAGE_END"]/*'/>
    WS_TRACE_API_WRITE_MESSAGE_END = 79,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_MESSAGE_START"]/*'/>
    WS_TRACE_API_READ_MESSAGE_START = 80,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_MESSAGE_END"]/*'/>
    WS_TRACE_API_READ_MESSAGE_END = 81,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CLOSE_CHANNEL"]/*'/>
    WS_TRACE_API_CLOSE_CHANNEL = 82,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ABORT_CHANNEL"]/*'/>
    WS_TRACE_API_ABORT_CHANNEL = 83,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FREE_CHANNEL"]/*'/>
    WS_TRACE_API_FREE_CHANNEL = 84,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_RESET_CHANNEL"]/*'/>
    WS_TRACE_API_RESET_CHANNEL = 85,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ABANDON_MESSAGE"]/*'/>
    WS_TRACE_API_ABANDON_MESSAGE = 86,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SHUTDOWN_SESSION_CHANNEL"]/*'/>
    WS_TRACE_API_SHUTDOWN_SESSION_CHANNEL = 87,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_CONTEXT_PROPERTY"]/*'/>
    WS_TRACE_API_GET_CONTEXT_PROPERTY = 88,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_DICTIONARY"]/*'/>
    WS_TRACE_API_GET_DICTIONARY = 89,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_ENDPOINT_ADDRESS_EXTENSION"]/*'/>
    WS_TRACE_API_READ_ENDPOINT_ADDRESS_EXTENSION = 90,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_ERROR"]/*'/>
    WS_TRACE_API_CREATE_ERROR = 91,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ADD_ERROR_STRING"]/*'/>
    WS_TRACE_API_ADD_ERROR_STRING = 92,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_ERROR_STRING"]/*'/>
    WS_TRACE_API_GET_ERROR_STRING = 93,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_COPY_ERROR"]/*'/>
    WS_TRACE_API_COPY_ERROR = 94,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_ERROR_PROPERTY"]/*'/>
    WS_TRACE_API_GET_ERROR_PROPERTY = 95,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_ERROR_PROPERTY"]/*'/>
    WS_TRACE_API_SET_ERROR_PROPERTY = 96,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_RESET_ERROR"]/*'/>
    WS_TRACE_API_RESET_ERROR = 97,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FREE_ERROR"]/*'/>
    WS_TRACE_API_FREE_ERROR = 98,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_FAULT_ERROR_PROPERTY"]/*'/>
    WS_TRACE_API_GET_FAULT_ERROR_PROPERTY = 99,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_FAULT_ERROR_PROPERTY"]/*'/>
    WS_TRACE_API_SET_FAULT_ERROR_PROPERTY = 100,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_FAULT_FROM_ERROR"]/*'/>
    WS_TRACE_API_CREATE_FAULT_FROM_ERROR = 101,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_FAULT_ERROR_DETAIL"]/*'/>
    WS_TRACE_API_SET_FAULT_ERROR_DETAIL = 102,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_FAULT_ERROR_DETAIL"]/*'/>
    WS_TRACE_API_GET_FAULT_ERROR_DETAIL = 103,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_HEAP"]/*'/>
    WS_TRACE_API_CREATE_HEAP = 104,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ALLOC"]/*'/>
    WS_TRACE_API_ALLOC = 105,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_HEAP_PROPERTY"]/*'/>
    WS_TRACE_API_GET_HEAP_PROPERTY = 106,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_RESET_HEAP"]/*'/>
    WS_TRACE_API_RESET_HEAP = 107,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FREE_HEAP"]/*'/>
    WS_TRACE_API_FREE_HEAP = 108,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_LISTENER"]/*'/>
    WS_TRACE_API_CREATE_LISTENER = 109,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_OPEN_LISTENER"]/*'/>
    WS_TRACE_API_OPEN_LISTENER = 110,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ACCEPT_CHANNEL"]/*'/>
    WS_TRACE_API_ACCEPT_CHANNEL = 111,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CLOSE_LISTENER"]/*'/>
    WS_TRACE_API_CLOSE_LISTENER = 112,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ABORT_LISTENER"]/*'/>
    WS_TRACE_API_ABORT_LISTENER = 113,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_RESET_LISTENER"]/*'/>
    WS_TRACE_API_RESET_LISTENER = 114,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FREE_LISTENER"]/*'/>
    WS_TRACE_API_FREE_LISTENER = 115,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_LISTENER_PROPERTY"]/*'/>
    WS_TRACE_API_GET_LISTENER_PROPERTY = 116,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_LISTENER_PROPERTY"]/*'/>
    WS_TRACE_API_SET_LISTENER_PROPERTY = 117,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_CHANNEL_FOR_LISTENER"]/*'/>
    WS_TRACE_API_CREATE_CHANNEL_FOR_LISTENER = 118,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_MESSAGE"]/*'/>
    WS_TRACE_API_CREATE_MESSAGE = 119,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_MESSAGE_FOR_CHANNEL"]/*'/>
    WS_TRACE_API_CREATE_MESSAGE_FOR_CHANNEL = 120,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_INITIALIZE_MESSAGE"]/*'/>
    WS_TRACE_API_INITIALIZE_MESSAGE = 121,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_RESET_MESSAGE"]/*'/>
    WS_TRACE_API_RESET_MESSAGE = 122,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FREE_MESSAGE"]/*'/>
    WS_TRACE_API_FREE_MESSAGE = 123,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_HEADER_ATTRIBUTES"]/*'/>
    WS_TRACE_API_GET_HEADER_ATTRIBUTES = 124,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_HEADER"]/*'/>
    WS_TRACE_API_GET_HEADER = 125,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_CUSTOM_HEADER"]/*'/>
    WS_TRACE_API_GET_CUSTOM_HEADER = 126,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_REMOVE_HEADER"]/*'/>
    WS_TRACE_API_REMOVE_HEADER = 127,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_HEADER"]/*'/>
    WS_TRACE_API_SET_HEADER = 128,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_REMOVE_CUSTOM_HEADER"]/*'/>
    WS_TRACE_API_REMOVE_CUSTOM_HEADER = 129,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ADD_CUSTOM_HEADER"]/*'/>
    WS_TRACE_API_ADD_CUSTOM_HEADER = 130,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ADD_MAPPED_HEADER"]/*'/>
    WS_TRACE_API_ADD_MAPPED_HEADER = 131,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_REMOVE_MAPPED_HEADER"]/*'/>
    WS_TRACE_API_REMOVE_MAPPED_HEADER = 132,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_MAPPED_HEADER"]/*'/>
    WS_TRACE_API_GET_MAPPED_HEADER = 133,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_BODY"]/*'/>
    WS_TRACE_API_WRITE_BODY = 134,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_BODY"]/*'/>
    WS_TRACE_API_READ_BODY = 135,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_ENVELOPE_START"]/*'/>
    WS_TRACE_API_WRITE_ENVELOPE_START = 136,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_ENVELOPE_END"]/*'/>
    WS_TRACE_API_WRITE_ENVELOPE_END = 137,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_ENVELOPE_START"]/*'/>
    WS_TRACE_API_READ_ENVELOPE_START = 138,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_ENVELOPE_END"]/*'/>
    WS_TRACE_API_READ_ENVELOPE_END = 139,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_MESSAGE_PROPERTY"]/*'/>
    WS_TRACE_API_GET_MESSAGE_PROPERTY = 140,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_MESSAGE_PROPERTY"]/*'/>
    WS_TRACE_API_SET_MESSAGE_PROPERTY = 141,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ADDRESS_MESSAGE"]/*'/>
    WS_TRACE_API_ADDRESS_MESSAGE = 142,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CHECK_MUST_UNDERSTAND_HEADERS"]/*'/>
    WS_TRACE_API_CHECK_MUST_UNDERSTAND_HEADERS = 143,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_MARK_HEADER_AS_UNDERSTOOD"]/*'/>
    WS_TRACE_API_MARK_HEADER_AS_UNDERSTOOD = 144,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FILL_BODY"]/*'/>
    WS_TRACE_API_FILL_BODY = 145,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FLUSH_BODY"]/*'/>
    WS_TRACE_API_FLUSH_BODY = 146,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_REQUEST_SECURITY_TOKEN"]/*'/>
    WS_TRACE_API_REQUEST_SECURITY_TOKEN = 147,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_SECURITY_TOKEN_PROPERTY"]/*'/>
    WS_TRACE_API_GET_SECURITY_TOKEN_PROPERTY = 148,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_XML_SECURITY_TOKEN"]/*'/>
    WS_TRACE_API_CREATE_XML_SECURITY_TOKEN = 149,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FREE_SECURITY_TOKEN"]/*'/>
    WS_TRACE_API_FREE_SECURITY_TOKEN = 150,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_REVOKE_SECURITY_CONTEXT"]/*'/>
    WS_TRACE_API_REVOKE_SECURITY_CONTEXT = 151,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_SECURITY_CONTEXT_PROPERTY"]/*'/>
    WS_TRACE_API_GET_SECURITY_CONTEXT_PROPERTY = 152,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_ELEMENT_TYPE"]/*'/>
    WS_TRACE_API_READ_ELEMENT_TYPE = 153,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_ATTRIBUTE_TYPE"]/*'/>
    WS_TRACE_API_READ_ATTRIBUTE_TYPE = 154,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_TYPE"]/*'/>
    WS_TRACE_API_READ_TYPE = 155,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_ELEMENT_TYPE"]/*'/>
    WS_TRACE_API_WRITE_ELEMENT_TYPE = 156,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_ATTRIBUTE_TYPE"]/*'/>
    WS_TRACE_API_WRITE_ATTRIBUTE_TYPE = 157,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WRITE_TYPE"]/*'/>
    WS_TRACE_API_WRITE_TYPE = 158,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SERVICE_REGISTER_FOR_CANCEL"]/*'/>
    WS_TRACE_API_SERVICE_REGISTER_FOR_CANCEL = 159,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_SERVICE_HOST_PROPERTY"]/*'/>
    WS_TRACE_API_GET_SERVICE_HOST_PROPERTY = 160,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_SERVICE_HOST"]/*'/>
    WS_TRACE_API_CREATE_SERVICE_HOST = 161,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_OPEN_SERVICE_HOST"]/*'/>
    WS_TRACE_API_OPEN_SERVICE_HOST = 162,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CLOSE_SERVICE_HOST"]/*'/>
    WS_TRACE_API_CLOSE_SERVICE_HOST = 163,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ABORT_SERVICE_HOST"]/*'/>
    WS_TRACE_API_ABORT_SERVICE_HOST = 164,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FREE_SERVICE_HOST"]/*'/>
    WS_TRACE_API_FREE_SERVICE_HOST = 165,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_RESET_SERVICE_HOST"]/*'/>
    WS_TRACE_API_RESET_SERVICE_HOST = 166,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_SERVICE_PROXY_PROPERTY"]/*'/>
    WS_TRACE_API_GET_SERVICE_PROXY_PROPERTY = 167,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_SERVICE_PROXY"]/*'/>
    WS_TRACE_API_CREATE_SERVICE_PROXY = 168,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_OPEN_SERVICE_PROXY"]/*'/>
    WS_TRACE_API_OPEN_SERVICE_PROXY = 169,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CLOSE_SERVICE_PROXY"]/*'/>
    WS_TRACE_API_CLOSE_SERVICE_PROXY = 170,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ABORT_SERVICE_PROXY"]/*'/>
    WS_TRACE_API_ABORT_SERVICE_PROXY = 171,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FREE_SERVICE_PROXY"]/*'/>
    WS_TRACE_API_FREE_SERVICE_PROXY = 172,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_RESET_SERVICE_PROXY"]/*'/>
    WS_TRACE_API_RESET_SERVICE_PROXY = 173,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ABORT_CALL"]/*'/>
    WS_TRACE_API_ABORT_CALL = 174,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CALL"]/*'/>
    WS_TRACE_API_CALL = 175,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_DECODE_URL"]/*'/>
    WS_TRACE_API_DECODE_URL = 176,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_ENCODE_URL"]/*'/>
    WS_TRACE_API_ENCODE_URL = 177,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_COMBINE_URL"]/*'/>
    WS_TRACE_API_COMBINE_URL = 178,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_DATETIME_TO_FILETIME"]/*'/>
    WS_TRACE_API_DATETIME_TO_FILETIME = 179,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FILETIME_TO_DATETIME"]/*'/>
    WS_TRACE_API_FILETIME_TO_DATETIME = 180,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_DUMP_MEMORY"]/*'/>
    WS_TRACE_API_DUMP_MEMORY = 181,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_SET_AUTOFAIL"]/*'/>
    WS_TRACE_API_SET_AUTOFAIL = 182,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_CREATE_METADATA"]/*'/>
    WS_TRACE_API_CREATE_METADATA = 183,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_READ_METADATA"]/*'/>
    WS_TRACE_API_READ_METADATA = 184,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_FREE_METADATA"]/*'/>
    WS_TRACE_API_FREE_METADATA = 185,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_RESET_METADATA"]/*'/>
    WS_TRACE_API_RESET_METADATA = 186,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_METADATA_PROPERTY"]/*'/>
    WS_TRACE_API_GET_METADATA_PROPERTY = 187,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_MISSING_METADATA_DOCUMENT_ADDRESS"]/*'/>
    WS_TRACE_API_GET_MISSING_METADATA_DOCUMENT_ADDRESS = 188,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_METADATA_ENDPOINTS"]/*'/>
    WS_TRACE_API_GET_METADATA_ENDPOINTS = 189,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_MATCH_POLICY_ALTERNATIVE"]/*'/>
    WS_TRACE_API_MATCH_POLICY_ALTERNATIVE = 190,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_POLICY_PROPERTY"]/*'/>
    WS_TRACE_API_GET_POLICY_PROPERTY = 191,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_GET_POLICY_ALTERNATIVE_COUNT"]/*'/>
    WS_TRACE_API_GET_POLICY_ALTERNATIVE_COUNT = 192,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WS_CREATE_SERVICE_PROXY_FROM_TEMPLATE"]/*'/>
    WS_TRACE_API_WS_CREATE_SERVICE_PROXY_FROM_TEMPLATE = 193,
    /// <include file='WS_TRACE_API.xml' path='doc/member[@name="WS_TRACE_API.WS_TRACE_API_WS_CREATE_SERVICE_HOST_FROM_TEMPLATE"]/*'/>
    WS_TRACE_API_WS_CREATE_SERVICE_HOST_FROM_TEMPLATE = 194,
}