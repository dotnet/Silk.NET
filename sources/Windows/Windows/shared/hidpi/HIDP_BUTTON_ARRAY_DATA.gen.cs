// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/hidpi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='HIDP_BUTTON_ARRAY_DATA.xml' path='doc/member[@name="HIDP_BUTTON_ARRAY_DATA"]/*'/>
public partial struct HIDP_BUTTON_ARRAY_DATA
{
    /// <include file='HIDP_BUTTON_ARRAY_DATA.xml' path='doc/member[@name="HIDP_BUTTON_ARRAY_DATA.ArrayIndex"]/*'/>
    public ushort ArrayIndex;
    /// <include file='HIDP_BUTTON_ARRAY_DATA.xml' path='doc/member[@name="HIDP_BUTTON_ARRAY_DATA.On"]/*'/>
    [NativeTypeName("BOOLEAN")]
    public byte On;
}