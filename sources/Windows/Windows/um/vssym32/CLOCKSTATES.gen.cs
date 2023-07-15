// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/vssym32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CLOCKSTATES.xml' path='doc/member[@name="CLOCKSTATES"]/*'/>
public enum CLOCKSTATES
{
    /// <include file='CLOCKSTATES.xml' path='doc/member[@name="CLOCKSTATES.CLS_NORMAL"]/*'/>
    CLS_NORMAL = 1,
    /// <include file='CLOCKSTATES.xml' path='doc/member[@name="CLOCKSTATES.CLS_HOT"]/*'/>
    CLS_HOT = 2,
    /// <include file='CLOCKSTATES.xml' path='doc/member[@name="CLOCKSTATES.CLS_PRESSED"]/*'/>
    CLS_PRESSED = 3,
}