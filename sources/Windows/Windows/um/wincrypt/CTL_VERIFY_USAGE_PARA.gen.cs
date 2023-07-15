// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CTL_VERIFY_USAGE_PARA.xml' path='doc/member[@name="CTL_VERIFY_USAGE_PARA"]/*'/>
public unsafe partial struct CTL_VERIFY_USAGE_PARA
{
    /// <include file='CTL_VERIFY_USAGE_PARA.xml' path='doc/member[@name="CTL_VERIFY_USAGE_PARA.cbSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cbSize;
    /// <include file='CTL_VERIFY_USAGE_PARA.xml' path='doc/member[@name="CTL_VERIFY_USAGE_PARA.ListIdentifier"]/*'/>
    public CRYPT_DATA_BLOB ListIdentifier;
    /// <include file='CTL_VERIFY_USAGE_PARA.xml' path='doc/member[@name="CTL_VERIFY_USAGE_PARA.cCtlStore"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cCtlStore;
    /// <include file='CTL_VERIFY_USAGE_PARA.xml' path='doc/member[@name="CTL_VERIFY_USAGE_PARA.rghCtlStore"]/*'/>
    public HCERTSTORE* rghCtlStore;
    /// <include file='CTL_VERIFY_USAGE_PARA.xml' path='doc/member[@name="CTL_VERIFY_USAGE_PARA.cSignerStore"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cSignerStore;
    /// <include file='CTL_VERIFY_USAGE_PARA.xml' path='doc/member[@name="CTL_VERIFY_USAGE_PARA.rghSignerStore"]/*'/>
    public HCERTSTORE* rghSignerStore;
}