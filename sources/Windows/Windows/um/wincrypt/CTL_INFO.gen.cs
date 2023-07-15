// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CTL_INFO.xml' path='doc/member[@name="CTL_INFO"]/*'/>
public unsafe partial struct CTL_INFO
{
    /// <include file='CTL_INFO.xml' path='doc/member[@name="CTL_INFO.dwVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint dwVersion;
    /// <include file='CTL_INFO.xml' path='doc/member[@name="CTL_INFO.SubjectUsage"]/*'/>
    public CTL_USAGE SubjectUsage;
    /// <include file='CTL_INFO.xml' path='doc/member[@name="CTL_INFO.ListIdentifier"]/*'/>
    public CRYPT_DATA_BLOB ListIdentifier;
    /// <include file='CTL_INFO.xml' path='doc/member[@name="CTL_INFO.SequenceNumber"]/*'/>
    [NativeTypeName("CRYPT_INTEGER_BLOB")]
    public CRYPT_DATA_BLOB SequenceNumber;
    /// <include file='CTL_INFO.xml' path='doc/member[@name="CTL_INFO.ThisUpdate"]/*'/>
    public FILETIME ThisUpdate;
    /// <include file='CTL_INFO.xml' path='doc/member[@name="CTL_INFO.NextUpdate"]/*'/>
    public FILETIME NextUpdate;
    /// <include file='CTL_INFO.xml' path='doc/member[@name="CTL_INFO.SubjectAlgorithm"]/*'/>
    public CRYPT_ALGORITHM_IDENTIFIER SubjectAlgorithm;
    /// <include file='CTL_INFO.xml' path='doc/member[@name="CTL_INFO.cCTLEntry"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCTLEntry;
    /// <include file='CTL_INFO.xml' path='doc/member[@name="CTL_INFO.rgCTLEntry"]/*'/>
    [NativeTypeName("PCTL_ENTRY")]
    public CTL_ENTRY* rgCTLEntry;
    /// <include file='CTL_INFO.xml' path='doc/member[@name="CTL_INFO.cExtension"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cExtension;
    /// <include file='CTL_INFO.xml' path='doc/member[@name="CTL_INFO.rgExtension"]/*'/>
    [NativeTypeName("PCERT_EXTENSION")]
    public CERT_EXTENSION* rgExtension;
}