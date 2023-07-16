// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MEM_SECTION_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_SECTION_EXTENDED_PARAMETER_TYPE"]/*'/>
public enum MEM_SECTION_EXTENDED_PARAMETER_TYPE
{
    /// <include file='MEM_SECTION_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_SECTION_EXTENDED_PARAMETER_TYPE.MemSectionExtendedParameterInvalidType"]/*'/>
    MemSectionExtendedParameterInvalidType = 0,
    /// <include file='MEM_SECTION_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_SECTION_EXTENDED_PARAMETER_TYPE.MemSectionExtendedParameterUserPhysicalFlags"]/*'/>
    MemSectionExtendedParameterUserPhysicalFlags,
    /// <include file='MEM_SECTION_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_SECTION_EXTENDED_PARAMETER_TYPE.MemSectionExtendedParameterNumaNode"]/*'/>
    MemSectionExtendedParameterNumaNode,
    /// <include file='MEM_SECTION_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_SECTION_EXTENDED_PARAMETER_TYPE.MemSectionExtendedParameterSigningLevel"]/*'/>
    MemSectionExtendedParameterSigningLevel,
    /// <include file='MEM_SECTION_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_SECTION_EXTENDED_PARAMETER_TYPE.MemSectionExtendedParameterMax"]/*'/>
    MemSectionExtendedParameterMax,
}