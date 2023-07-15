// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1"]/*'/>
[SupportedOSPlatform("windows6.2")]
public partial struct CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1
{
    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.Name"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Name;
    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.ValueType"]/*'/>
    [NativeTypeName("WORD")]
    public ushort ValueType;
    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.Reserved"]/*'/>
    [NativeTypeName("WORD")]
    public ushort Reserved;
    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.ValueCount"]/*'/>
    [NativeTypeName("DWORD")]
    public uint ValueCount;
    /// <include file='CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.xml' path='doc/member[@name="CLAIM_SECURITY_ATTRIBUTE_RELATIVE_V1.Values"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L12035_C5")]
    public _Values_e__Union Values;
    /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _Values_e__Union
    {
        /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.pInt64"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public fixed uint pInt64[1];
        /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.pUint64"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public fixed uint pUint64[1];
        /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.ppString"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public fixed uint ppString[1];
        /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.pFqbn"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public fixed uint pFqbn[1];
        /// <include file='_Values_e__Union.xml' path='doc/member[@name="_Values_e__Union.pOctetString"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD[1]")]
        public fixed uint pOctetString[1];
    }
}