// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows;
/// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER"]/*'/>
public partial struct IMAGE_COR20_HEADER
{
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.cb"]/*'/>
    [NativeTypeName("DWORD")]
    public uint cb;
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.MajorRuntimeVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MajorRuntimeVersion;
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.MinorRuntimeVersion"]/*'/>
    [NativeTypeName("WORD")]
    public ushort MinorRuntimeVersion;
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.MetaData"]/*'/>
    public IMAGE_DATA_DIRECTORY MetaData;
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.Flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint Flags;
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.Anonymous"]/*'/>
    [NativeTypeName("__AnonymousRecord_winnt_L20669_C5")]
    public _Anonymous_e__Union Anonymous;
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.Resources"]/*'/>
    public IMAGE_DATA_DIRECTORY Resources;
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.StrongNameSignature"]/*'/>
    public IMAGE_DATA_DIRECTORY StrongNameSignature;
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.CodeManagerTable"]/*'/>
    public IMAGE_DATA_DIRECTORY CodeManagerTable;
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.VTableFixups"]/*'/>
    public IMAGE_DATA_DIRECTORY VTableFixups;
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.ExportAddressTableJumps"]/*'/>
    public IMAGE_DATA_DIRECTORY ExportAddressTableJumps;
    /// <include file='IMAGE_COR20_HEADER.xml' path='doc/member[@name="IMAGE_COR20_HEADER.ManagedNativeHeader"]/*'/>
    public IMAGE_DATA_DIRECTORY ManagedNativeHeader;
    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EntryPointToken"]/*'/>
    [UnscopedRef]
    public ref uint EntryPointToken
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.EntryPointToken;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EntryPointRVA"]/*'/>
    [UnscopedRef]
    public ref uint EntryPointRVA
    {
        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        get
        {
            return ref Anonymous.EntryPointRVA;
        }
    }

    /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union"]/*'/>
    [StructLayout(LayoutKind.Explicit)]
    public partial struct _Anonymous_e__Union
    {
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EntryPointToken"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint EntryPointToken;
        /// <include file='_Anonymous_e__Union.xml' path='doc/member[@name="_Anonymous_e__Union.EntryPointRVA"]/*'/>
        [FieldOffset(0)]
        [NativeTypeName("DWORD")]
        public uint EntryPointRVA;
    }
}