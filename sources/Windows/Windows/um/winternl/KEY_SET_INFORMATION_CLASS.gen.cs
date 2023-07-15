// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winternl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='KEY_SET_INFORMATION_CLASS.xml' path='doc/member[@name="KEY_SET_INFORMATION_CLASS"]/*'/>
public enum KEY_SET_INFORMATION_CLASS
{
    /// <include file='KEY_SET_INFORMATION_CLASS.xml' path='doc/member[@name="KEY_SET_INFORMATION_CLASS.KeyWriteTimeInformation"]/*'/>
    KeyWriteTimeInformation,
    /// <include file='KEY_SET_INFORMATION_CLASS.xml' path='doc/member[@name="KEY_SET_INFORMATION_CLASS.KeyWow64FlagsInformation"]/*'/>
    KeyWow64FlagsInformation,
    /// <include file='KEY_SET_INFORMATION_CLASS.xml' path='doc/member[@name="KEY_SET_INFORMATION_CLASS.KeyControlFlagsInformation"]/*'/>
    KeyControlFlagsInformation,
    /// <include file='KEY_SET_INFORMATION_CLASS.xml' path='doc/member[@name="KEY_SET_INFORMATION_CLASS.KeySetVirtualizationInformation"]/*'/>
    KeySetVirtualizationInformation,
    /// <include file='KEY_SET_INFORMATION_CLASS.xml' path='doc/member[@name="KEY_SET_INFORMATION_CLASS.KeySetDebugInformation"]/*'/>
    KeySetDebugInformation,
    /// <include file='KEY_SET_INFORMATION_CLASS.xml' path='doc/member[@name="KEY_SET_INFORMATION_CLASS.KeySetHandleTagsInformation"]/*'/>
    KeySetHandleTagsInformation,
    /// <include file='KEY_SET_INFORMATION_CLASS.xml' path='doc/member[@name="KEY_SET_INFORMATION_CLASS.MaxKeySetInfoClass"]/*'/>
    MaxKeySetInfoClass,
}