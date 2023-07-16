// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctfutb.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='TF_LBBALLOONINFO.xml' path='doc/member[@name="TF_LBBALLOONINFO"]/*'/>
public unsafe partial struct TF_LBBALLOONINFO
{
    /// <include file='TF_LBBALLOONINFO.xml' path='doc/member[@name="TF_LBBALLOONINFO.style"]/*'/>
    public TfLBBalloonStyle style;
    /// <include file='TF_LBBALLOONINFO.xml' path='doc/member[@name="TF_LBBALLOONINFO.bstrText"]/*'/>
    [NativeTypeName("BSTR")]
    public ushort* bstrText;
}