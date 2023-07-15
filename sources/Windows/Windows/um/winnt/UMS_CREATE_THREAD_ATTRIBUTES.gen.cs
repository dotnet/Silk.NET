// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='UMS_CREATE_THREAD_ATTRIBUTES.xml' path='doc/member[@name="UMS_CREATE_THREAD_ATTRIBUTES"]/*'/>
public unsafe partial struct UMS_CREATE_THREAD_ATTRIBUTES
{
    /// <include file='UMS_CREATE_THREAD_ATTRIBUTES.xml' path='doc/member[@name="UMS_CREATE_THREAD_ATTRIBUTES.UmsVersion"]/*'/>
    [NativeTypeName("DWORD")]
    public uint UmsVersion;
    /// <include file='UMS_CREATE_THREAD_ATTRIBUTES.xml' path='doc/member[@name="UMS_CREATE_THREAD_ATTRIBUTES.UmsContext"]/*'/>
    [NativeTypeName("PVOID")]
    public void* UmsContext;
    /// <include file='UMS_CREATE_THREAD_ATTRIBUTES.xml' path='doc/member[@name="UMS_CREATE_THREAD_ATTRIBUTES.UmsCompletionList"]/*'/>
    [NativeTypeName("PVOID")]
    public void* UmsCompletionList;
}