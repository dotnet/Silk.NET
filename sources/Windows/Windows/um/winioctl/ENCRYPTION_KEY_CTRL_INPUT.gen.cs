// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='ENCRYPTION_KEY_CTRL_INPUT.xml' path='doc/member[@name="ENCRYPTION_KEY_CTRL_INPUT"]/*'/>
public partial struct ENCRYPTION_KEY_CTRL_INPUT
{
    /// <include file='ENCRYPTION_KEY_CTRL_INPUT.xml' path='doc/member[@name="ENCRYPTION_KEY_CTRL_INPUT.HeaderSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint HeaderSize;
    /// <include file='ENCRYPTION_KEY_CTRL_INPUT.xml' path='doc/member[@name="ENCRYPTION_KEY_CTRL_INPUT.StructureSize"]/*'/>
    [NativeTypeName("DWORD")]
    public uint StructureSize;
    /// <include file='ENCRYPTION_KEY_CTRL_INPUT.xml' path='doc/member[@name="ENCRYPTION_KEY_CTRL_INPUT.KeyOffset"]/*'/>
    [NativeTypeName("WORD")]
    public ushort KeyOffset;
    /// <include file='ENCRYPTION_KEY_CTRL_INPUT.xml' path='doc/member[@name="ENCRYPTION_KEY_CTRL_INPUT.KeySize"]/*'/>
    [NativeTypeName("WORD")]
    public ushort KeySize;
    /// <include file='ENCRYPTION_KEY_CTRL_INPUT.xml' path='doc/member[@name="ENCRYPTION_KEY_CTRL_INPUT.DplLock"]/*'/>
    [NativeTypeName("DWORD")]
    public uint DplLock;
    /// <include file='ENCRYPTION_KEY_CTRL_INPUT.xml' path='doc/member[@name="ENCRYPTION_KEY_CTRL_INPUT.DplUserId"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong DplUserId;
    /// <include file='ENCRYPTION_KEY_CTRL_INPUT.xml' path='doc/member[@name="ENCRYPTION_KEY_CTRL_INPUT.DplCredentialId"]/*'/>
    [NativeTypeName("DWORDLONG")]
    public ulong DplCredentialId;
}