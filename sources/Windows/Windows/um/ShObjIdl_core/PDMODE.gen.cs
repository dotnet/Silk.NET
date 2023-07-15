// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='PDMODE.xml' path='doc/member[@name="PDMODE"]/*'/>
public enum PDMODE
{
    /// <include file='PDMODE.xml' path='doc/member[@name="PDMODE.PDM_DEFAULT"]/*'/>
    PDM_DEFAULT = 0,
    /// <include file='PDMODE.xml' path='doc/member[@name="PDMODE.PDM_RUN"]/*'/>
    PDM_RUN = 0x1,
    /// <include file='PDMODE.xml' path='doc/member[@name="PDMODE.PDM_PREFLIGHT"]/*'/>
    PDM_PREFLIGHT = 0x2,
    /// <include file='PDMODE.xml' path='doc/member[@name="PDMODE.PDM_UNDOING"]/*'/>
    PDM_UNDOING = 0x4,
    /// <include file='PDMODE.xml' path='doc/member[@name="PDMODE.PDM_ERRORSBLOCKING"]/*'/>
    PDM_ERRORSBLOCKING = 0x8,
    /// <include file='PDMODE.xml' path='doc/member[@name="PDMODE.PDM_INDETERMINATE"]/*'/>
    PDM_INDETERMINATE = 0x10,
}