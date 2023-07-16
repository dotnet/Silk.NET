// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='ACTRL_CONTROL_INFOW.xml' path='doc/member[@name="ACTRL_CONTROL_INFOW"]/*'/>
public unsafe partial struct ACTRL_CONTROL_INFOW
{
    /// <include file='ACTRL_CONTROL_INFOW.xml' path='doc/member[@name="ACTRL_CONTROL_INFOW.lpControlId"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpControlId;
    /// <include file='ACTRL_CONTROL_INFOW.xml' path='doc/member[@name="ACTRL_CONTROL_INFOW.lpControlName"]/*'/>
    [NativeTypeName("LPWSTR")]
    public ushort* lpControlName;
}