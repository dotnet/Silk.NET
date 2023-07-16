// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='SYSTEM_POWER_CONDITION.xml' path='doc/member[@name="SYSTEM_POWER_CONDITION"]/*'/>
public enum SYSTEM_POWER_CONDITION
{
    /// <include file='SYSTEM_POWER_CONDITION.xml' path='doc/member[@name="SYSTEM_POWER_CONDITION.PoAc"]/*'/>
    PoAc,
    /// <include file='SYSTEM_POWER_CONDITION.xml' path='doc/member[@name="SYSTEM_POWER_CONDITION.PoDc"]/*'/>
    PoDc,
    /// <include file='SYSTEM_POWER_CONDITION.xml' path='doc/member[@name="SYSTEM_POWER_CONDITION.PoHot"]/*'/>
    PoHot,
    /// <include file='SYSTEM_POWER_CONDITION.xml' path='doc/member[@name="SYSTEM_POWER_CONDITION.PoConditionMaximum"]/*'/>
    PoConditionMaximum,
}