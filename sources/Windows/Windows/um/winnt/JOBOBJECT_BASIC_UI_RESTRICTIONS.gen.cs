// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='JOBOBJECT_BASIC_UI_RESTRICTIONS.xml' path='doc/member[@name="JOBOBJECT_BASIC_UI_RESTRICTIONS"]/*'/>
public partial struct JOBOBJECT_BASIC_UI_RESTRICTIONS
{
    /// <include file='JOBOBJECT_BASIC_UI_RESTRICTIONS.xml' path='doc/member[@name="JOBOBJECT_BASIC_UI_RESTRICTIONS.UIRestrictionsClass"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UIRestrictionsClass;
}