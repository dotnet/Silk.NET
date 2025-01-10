// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msxml.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum DOMNodeType
{
    NODE_INVALID = 0,
    NODE_ELEMENT = (NODE_INVALID + 1),
    NODE_ATTRIBUTE = (NODE_ELEMENT + 1),
    NODE_TEXT = (NODE_ATTRIBUTE + 1),
    NODE_CDATA_SECTION = (NODE_TEXT + 1),
    NODE_ENTITY_REFERENCE = (NODE_CDATA_SECTION + 1),
    NODE_ENTITY = (NODE_ENTITY_REFERENCE + 1),
    NODE_PROCESSING_INSTRUCTION = (NODE_ENTITY + 1),
    NODE_COMMENT = (NODE_PROCESSING_INSTRUCTION + 1),
    NODE_DOCUMENT = (NODE_COMMENT + 1),
    NODE_DOCUMENT_TYPE = (NODE_DOCUMENT + 1),
    NODE_DOCUMENT_FRAGMENT = (NODE_DOCUMENT_TYPE + 1),
    NODE_NOTATION = (NODE_DOCUMENT_FRAGMENT + 1),
}
