// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IMAGE_POLICY_ENTRY.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY"]/*'/>
public partial struct IMAGE_POLICY_ENTRY
{
    /// <include file='IMAGE_POLICY_ENTRY.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY.Type"]/*'/>
    public IMAGE_POLICY_ENTRY_TYPE Type;
    /// <include file='IMAGE_POLICY_ENTRY.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY.PolicyId"]/*'/>
    public IMAGE_POLICY_ID PolicyId;
    /// <include file='IMAGE_POLICY_ENTRY.xml' path='doc/member[@name="IMAGE_POLICY_ENTRY.u"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L22494_C5")]
    public _u_e__Union u;
    /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct _u_e__Union
    {
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.None"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("const void *")]
        public void* None;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.BoolValue"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("BOOLEAN")]
        public byte BoolValue;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Int8Value"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("INT8")]
        public sbyte Int8Value;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UInt8Value"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("UINT8")]
        public byte UInt8Value;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Int16Value"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("INT16")]
        public short Int16Value;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UInt16Value"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("UINT16")]
        public ushort UInt16Value;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Int32Value"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("INT32")]
        public int Int32Value;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UInt32Value"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("UINT32")]
        public uint UInt32Value;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.Int64Value"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("INT64")]
        public long Int64Value;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UInt64Value"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("UINT64")]
        public ulong UInt64Value;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.AnsiStringValue"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PCSTR")]
        public sbyte* AnsiStringValue;
        /// <include file='_u_e__Union.xml' path='doc/member[@name="_u_e__Union.UnicodeStringValue"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("PCWSTR")]
        public ushort* UnicodeStringValue;
    }
}