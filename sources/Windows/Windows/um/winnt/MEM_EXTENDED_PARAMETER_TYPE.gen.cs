// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='MEM_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_EXTENDED_PARAMETER_TYPE"]/*'/>
[SupportedOSPlatform("windows10.0")]
public enum MEM_EXTENDED_PARAMETER_TYPE
{
    /// <include file='MEM_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_EXTENDED_PARAMETER_TYPE.MemExtendedParameterInvalidType"]/*'/>
    MemExtendedParameterInvalidType = 0,
    /// <include file='MEM_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_EXTENDED_PARAMETER_TYPE.MemExtendedParameterAddressRequirements"]/*'/>
    MemExtendedParameterAddressRequirements,
    /// <include file='MEM_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_EXTENDED_PARAMETER_TYPE.MemExtendedParameterNumaNode"]/*'/>
    MemExtendedParameterNumaNode,
    /// <include file='MEM_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_EXTENDED_PARAMETER_TYPE.MemExtendedParameterPartitionHandle"]/*'/>
    MemExtendedParameterPartitionHandle,
    /// <include file='MEM_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_EXTENDED_PARAMETER_TYPE.MemExtendedParameterUserPhysicalHandle"]/*'/>
    MemExtendedParameterUserPhysicalHandle,
    /// <include file='MEM_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_EXTENDED_PARAMETER_TYPE.MemExtendedParameterAttributeFlags"]/*'/>
    MemExtendedParameterAttributeFlags,
    /// <include file='MEM_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_EXTENDED_PARAMETER_TYPE.MemExtendedParameterImageMachine"]/*'/>
    MemExtendedParameterImageMachine,
    /// <include file='MEM_EXTENDED_PARAMETER_TYPE.xml' path='doc/member[@name="MEM_EXTENDED_PARAMETER_TYPE.MemExtendedParameterMax"]/*'/>
    MemExtendedParameterMax,
}