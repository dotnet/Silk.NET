// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/devicetopology.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='PartType.xml' path='doc/member[@name="PartType"]/*'/>
public enum PartType
{
    /// <include file='PartType.xml' path='doc/member[@name="PartType.Connector"]/*'/>
    Connector = 0,
    /// <include file='PartType.xml' path='doc/member[@name="PartType.Subunit"]/*'/>
    Subunit = (Connector + 1),
}