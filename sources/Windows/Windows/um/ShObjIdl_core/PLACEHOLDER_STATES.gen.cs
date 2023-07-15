// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;

namespace TerraFX.Interop.Windows;
/// <include file='PLACEHOLDER_STATES.xml' path='doc/member[@name="PLACEHOLDER_STATES"]/*'/>
[Flags]
public enum PLACEHOLDER_STATES
{
    /// <include file='PLACEHOLDER_STATES.xml' path='doc/member[@name="PLACEHOLDER_STATES.PS_NONE"]/*'/>
    PS_NONE = 0,
    /// <include file='PLACEHOLDER_STATES.xml' path='doc/member[@name="PLACEHOLDER_STATES.PS_MARKED_FOR_OFFLINE_AVAILABILITY"]/*'/>
    PS_MARKED_FOR_OFFLINE_AVAILABILITY = 0x1,
    /// <include file='PLACEHOLDER_STATES.xml' path='doc/member[@name="PLACEHOLDER_STATES.PS_FULL_PRIMARY_STREAM_AVAILABLE"]/*'/>
    PS_FULL_PRIMARY_STREAM_AVAILABLE = 0x2,
    /// <include file='PLACEHOLDER_STATES.xml' path='doc/member[@name="PLACEHOLDER_STATES.PS_CREATE_FILE_ACCESSIBLE"]/*'/>
    PS_CREATE_FILE_ACCESSIBLE = 0x4,
    /// <include file='PLACEHOLDER_STATES.xml' path='doc/member[@name="PLACEHOLDER_STATES.PS_CLOUDFILE_PLACEHOLDER"]/*'/>
    PS_CLOUDFILE_PLACEHOLDER = 0x8,
    /// <include file='PLACEHOLDER_STATES.xml' path='doc/member[@name="PLACEHOLDER_STATES.PS_DEFAULT"]/*'/>
    PS_DEFAULT = ((PS_MARKED_FOR_OFFLINE_AVAILABILITY | PS_FULL_PRIMARY_STREAM_AVAILABLE) | PS_CREATE_FILE_ACCESSIBLE),
    /// <include file='PLACEHOLDER_STATES.xml' path='doc/member[@name="PLACEHOLDER_STATES.PS_ALL"]/*'/>
    PS_ALL = (((PS_MARKED_FOR_OFFLINE_AVAILABILITY | PS_FULL_PRIMARY_STREAM_AVAILABLE) | PS_CREATE_FILE_ACCESSIBLE) | PS_CLOUDFILE_PLACEHOLDER),
}