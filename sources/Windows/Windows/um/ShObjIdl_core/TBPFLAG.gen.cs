// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TBPFLAG.xml' path='doc/member[@name="TBPFLAG"]/*'/>
public enum TBPFLAG
{
    /// <include file='TBPFLAG.xml' path='doc/member[@name="TBPFLAG.TBPF_NOPROGRESS"]/*'/>
    TBPF_NOPROGRESS = 0,
    /// <include file='TBPFLAG.xml' path='doc/member[@name="TBPFLAG.TBPF_INDETERMINATE"]/*'/>
    TBPF_INDETERMINATE = 0x1,
    /// <include file='TBPFLAG.xml' path='doc/member[@name="TBPFLAG.TBPF_NORMAL"]/*'/>
    TBPF_NORMAL = 0x2,
    /// <include file='TBPFLAG.xml' path='doc/member[@name="TBPFLAG.TBPF_ERROR"]/*'/>
    TBPF_ERROR = 0x4,
    /// <include file='TBPFLAG.xml' path='doc/member[@name="TBPFLAG.TBPF_PAUSED"]/*'/>
    TBPF_PAUSED = 0x8,
}