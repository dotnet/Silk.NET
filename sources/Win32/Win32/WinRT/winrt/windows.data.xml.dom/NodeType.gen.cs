// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from winrt/windows.data.xml.dom.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.WinRT;

public enum NodeType
{
    NodeType_Invalid = 0,
    NodeType_ElementNode = 1,
    NodeType_AttributeNode = 2,
    NodeType_TextNode = 3,
    NodeType_DataSectionNode = 4,
    NodeType_EntityReferenceNode = 5,
    NodeType_EntityNode = 6,
    NodeType_ProcessingInstructionNode = 7,
    NodeType_CommentNode = 8,
    NodeType_DocumentNode = 9,
    NodeType_DocumentTypeNode = 10,
    NodeType_DocumentFragmentNode = 11,
    NodeType_NotationNode = 12,
}
