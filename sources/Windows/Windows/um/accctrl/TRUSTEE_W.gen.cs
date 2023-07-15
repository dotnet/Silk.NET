// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/accctrl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='TRUSTEE_W.xml' path='doc/member[@name="TRUSTEE_W"]/*'/>
public unsafe partial struct TRUSTEE_W
{
    /// <include file='TRUSTEE_W.xml' path='doc/member[@name="TRUSTEE_W.pMultipleTrustee"]/*'/>
    [NativeTypeName("struct _TRUSTEE_W *")]
    public TRUSTEE_W* pMultipleTrustee;
    /// <include file='TRUSTEE_W.xml' path='doc/member[@name="TRUSTEE_W.MultipleTrusteeOperation"]/*'/>
    public MULTIPLE_TRUSTEE_OPERATION MultipleTrusteeOperation;
    /// <include file='TRUSTEE_W.xml' path='doc/member[@name="TRUSTEE_W.TrusteeForm"]/*'/>
    public TRUSTEE_FORM TrusteeForm;
    /// <include file='TRUSTEE_W.xml' path='doc/member[@name="TRUSTEE_W.TrusteeType"]/*'/>
    public TRUSTEE_TYPE TrusteeType;
    /// <include file='TRUSTEE_W.xml' path='doc/member[@name="TRUSTEE_W.ptstrName"]/*'/>
    [NativeTypeName("LPWCH")]
    public ushort* ptstrName;
}