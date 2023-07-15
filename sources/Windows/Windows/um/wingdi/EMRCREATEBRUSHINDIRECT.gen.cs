// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRCREATEBRUSHINDIRECT.xml' path='doc/member[@name="EMRCREATEBRUSHINDIRECT"]/*'/>
public partial struct EMRCREATEBRUSHINDIRECT
{
    /// <include file='EMRCREATEBRUSHINDIRECT.xml' path='doc/member[@name="EMRCREATEBRUSHINDIRECT.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRCREATEBRUSHINDIRECT.xml' path='doc/member[@name="EMRCREATEBRUSHINDIRECT.ihBrush"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ihBrush;
    /// <include file='EMRCREATEBRUSHINDIRECT.xml' path='doc/member[@name="EMRCREATEBRUSHINDIRECT.lb"]/*'/>
    public LOGBRUSH32 lb;
}