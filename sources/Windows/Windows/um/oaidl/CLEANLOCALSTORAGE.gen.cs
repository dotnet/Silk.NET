// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/oaidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='CLEANLOCALSTORAGE.xml' path='doc/member[@name="CLEANLOCALSTORAGE"]/*'/>
public unsafe partial struct CLEANLOCALSTORAGE
{
    /// <include file='CLEANLOCALSTORAGE.xml' path='doc/member[@name="CLEANLOCALSTORAGE.pInterface"]/*'/>
    public IUnknown* pInterface;
    /// <include file='CLEANLOCALSTORAGE.xml' path='doc/member[@name="CLEANLOCALSTORAGE.pStorage"]/*'/>
    [NativeTypeName("PVOID")]
    public void* pStorage;
    /// <include file='CLEANLOCALSTORAGE.xml' path='doc/member[@name="CLEANLOCALSTORAGE.flags"]/*'/>
    [NativeTypeName("DWORD")]
    public uint flags;
}