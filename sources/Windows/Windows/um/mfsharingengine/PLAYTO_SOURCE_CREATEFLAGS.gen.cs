// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfsharingengine.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='PLAYTO_SOURCE_CREATEFLAGS.xml' path='doc/member[@name="PLAYTO_SOURCE_CREATEFLAGS"]/*'/>
[Flags]
[SupportedOSPlatform("windows6.2")]
public enum PLAYTO_SOURCE_CREATEFLAGS
{
    /// <include file='PLAYTO_SOURCE_CREATEFLAGS.xml' path='doc/member[@name="PLAYTO_SOURCE_CREATEFLAGS.PLAYTO_SOURCE_NONE"]/*'/>
    PLAYTO_SOURCE_NONE = 0,
    /// <include file='PLAYTO_SOURCE_CREATEFLAGS.xml' path='doc/member[@name="PLAYTO_SOURCE_CREATEFLAGS.PLAYTO_SOURCE_IMAGE"]/*'/>
    PLAYTO_SOURCE_IMAGE = 0x1,
    /// <include file='PLAYTO_SOURCE_CREATEFLAGS.xml' path='doc/member[@name="PLAYTO_SOURCE_CREATEFLAGS.PLAYTO_SOURCE_AUDIO"]/*'/>
    PLAYTO_SOURCE_AUDIO = 0x2,
    /// <include file='PLAYTO_SOURCE_CREATEFLAGS.xml' path='doc/member[@name="PLAYTO_SOURCE_CREATEFLAGS.PLAYTO_SOURCE_VIDEO"]/*'/>
    PLAYTO_SOURCE_VIDEO = 0x4,
    /// <include file='PLAYTO_SOURCE_CREATEFLAGS.xml' path='doc/member[@name="PLAYTO_SOURCE_CREATEFLAGS.PLAYTO_SOURCE_PROTECTED"]/*'/>
    PLAYTO_SOURCE_PROTECTED = 0x8,
}