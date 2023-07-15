// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRMODIFYWORLDTRANSFORM.xml' path='doc/member[@name="EMRMODIFYWORLDTRANSFORM"]/*'/>
public partial struct EMRMODIFYWORLDTRANSFORM
{
    /// <include file='EMRMODIFYWORLDTRANSFORM.xml' path='doc/member[@name="EMRMODIFYWORLDTRANSFORM.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRMODIFYWORLDTRANSFORM.xml' path='doc/member[@name="EMRMODIFYWORLDTRANSFORM.xform"]/*'/>
    public XFORM xform;
    /// <include file='EMRMODIFYWORLDTRANSFORM.xml' path='doc/member[@name="EMRMODIFYWORLDTRANSFORM.iMode"]/*'/>
    [NativeTypeName("DWORD")]
    public uint iMode;
}