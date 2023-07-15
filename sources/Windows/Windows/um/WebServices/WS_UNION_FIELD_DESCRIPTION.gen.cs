// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/WebServices.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='WS_UNION_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_UNION_FIELD_DESCRIPTION"]/*'/>
public partial struct WS_UNION_FIELD_DESCRIPTION
{
    /// <include file='WS_UNION_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_UNION_FIELD_DESCRIPTION.value"]/*'/>
    public int value;
    /// <include file='WS_UNION_FIELD_DESCRIPTION.xml' path='doc/member[@name="WS_UNION_FIELD_DESCRIPTION.field"]/*'/>
    public WS_FIELD_DESCRIPTION field;
}