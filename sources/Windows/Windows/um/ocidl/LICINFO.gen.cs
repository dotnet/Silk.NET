// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ocidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='LICINFO.xml' path='doc/member[@name="LICINFO"]/*'/>
public partial struct LICINFO
{
    /// <include file='LICINFO.xml' path='doc/member[@name="LICINFO.cbLicInfo"]/*'/>
    [NativeTypeName("LONG")]
    public int cbLicInfo;
    /// <include file='LICINFO.xml' path='doc/member[@name="LICINFO.fRuntimeKeyAvail"]/*'/>
    public BOOL fRuntimeKeyAvail;
    /// <include file='LICINFO.xml' path='doc/member[@name="LICINFO.fLicVerified"]/*'/>
    public BOOL fLicVerified;
}