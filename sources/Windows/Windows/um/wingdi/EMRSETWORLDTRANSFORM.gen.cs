// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wingdi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='EMRSETWORLDTRANSFORM.xml' path='doc/member[@name="EMRSETWORLDTRANSFORM"]/*'/>
public partial struct EMRSETWORLDTRANSFORM
{
    /// <include file='EMRSETWORLDTRANSFORM.xml' path='doc/member[@name="EMRSETWORLDTRANSFORM.emr"]/*'/>
    public EMR emr;
    /// <include file='EMRSETWORLDTRANSFORM.xml' path='doc/member[@name="EMRSETWORLDTRANSFORM.xform"]/*'/>
    public XFORM xform;
}