// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/TextStor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TS_TEXTCHANGE.xml' path='doc/member[@name="TS_TEXTCHANGE"]/*'/>
public partial struct TS_TEXTCHANGE
{
    /// <include file='TS_TEXTCHANGE.xml' path='doc/member[@name="TS_TEXTCHANGE.acpStart"]/*'/>
    [NativeTypeName("LONG")]
    public int acpStart;
    /// <include file='TS_TEXTCHANGE.xml' path='doc/member[@name="TS_TEXTCHANGE.acpOldEnd"]/*'/>
    [NativeTypeName("LONG")]
    public int acpOldEnd;
    /// <include file='TS_TEXTCHANGE.xml' path='doc/member[@name="TS_TEXTCHANGE.acpNewEnd"]/*'/>
    [NativeTypeName("LONG")]
    public int acpNewEnd;
}