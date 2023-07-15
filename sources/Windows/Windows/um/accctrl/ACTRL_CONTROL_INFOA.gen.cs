// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ACTRL_CONTROL_INFOA.xml' path='doc/member[@name="ACTRL_CONTROL_INFOA"]/*'/>
public unsafe partial struct ACTRL_CONTROL_INFOA
{
    /// <include file='ACTRL_CONTROL_INFOA.xml' path='doc/member[@name="ACTRL_CONTROL_INFOA.lpControlId"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpControlId;
    /// <include file='ACTRL_CONTROL_INFOA.xml' path='doc/member[@name="ACTRL_CONTROL_INFOA.lpControlName"]/*'/>
    [NativeTypeName("LPSTR")]
    public sbyte* lpControlName;
}