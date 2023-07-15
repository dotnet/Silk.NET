// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='SIATTRIBFLAGS.xml' path='doc/member[@name="SIATTRIBFLAGS"]/*'/>
public enum SIATTRIBFLAGS
{
    /// <include file='SIATTRIBFLAGS.xml' path='doc/member[@name="SIATTRIBFLAGS.SIATTRIBFLAGS_AND"]/*'/>
    SIATTRIBFLAGS_AND = 0x1,
    /// <include file='SIATTRIBFLAGS.xml' path='doc/member[@name="SIATTRIBFLAGS.SIATTRIBFLAGS_OR"]/*'/>
    SIATTRIBFLAGS_OR = 0x2,
    /// <include file='SIATTRIBFLAGS.xml' path='doc/member[@name="SIATTRIBFLAGS.SIATTRIBFLAGS_APPCOMPAT"]/*'/>
    SIATTRIBFLAGS_APPCOMPAT = 0x3,
    /// <include file='SIATTRIBFLAGS.xml' path='doc/member[@name="SIATTRIBFLAGS.SIATTRIBFLAGS_MASK"]/*'/>
    SIATTRIBFLAGS_MASK = 0x3,
    /// <include file='SIATTRIBFLAGS.xml' path='doc/member[@name="SIATTRIBFLAGS.SIATTRIBFLAGS_ALLITEMS"]/*'/>
    SIATTRIBFLAGS_ALLITEMS = 0x4000,
}