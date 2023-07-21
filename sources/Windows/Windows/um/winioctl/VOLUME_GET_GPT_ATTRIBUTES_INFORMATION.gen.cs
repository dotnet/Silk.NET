// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace Silk.NET.Windows;

/// <include file='VOLUME_GET_GPT_ATTRIBUTES_INFORMATION.xml' path='doc/member[@name="VOLUME_GET_GPT_ATTRIBUTES_INFORMATION"]/*' />
public partial struct VOLUME_GET_GPT_ATTRIBUTES_INFORMATION
{
    /// <include file='VOLUME_GET_GPT_ATTRIBUTES_INFORMATION.xml' path='doc/member[@name="VOLUME_GET_GPT_ATTRIBUTES_INFORMATION.GptAttributes"]/*' />
    [NativeTypeName("DWORDLONG")]
    public ulong GptAttributes;
}
