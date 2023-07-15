// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Audioclient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace TerraFX.Interop.Windows;
/// <include file='AudioClientProperties.xml' path='doc/member[@name="AudioClientProperties"]/*'/>
[SupportedOSPlatform("windows10.0.22621.0")]
public partial struct AudioClientProperties
{
    /// <include file='AudioClientProperties.xml' path='doc/member[@name="AudioClientProperties.cbSize"]/*'/>
    [NativeTypeName("UINT32")]
    public uint cbSize;
    /// <include file='AudioClientProperties.xml' path='doc/member[@name="AudioClientProperties.bIsOffload"]/*'/>
    public BOOL bIsOffload;
    /// <include file='AudioClientProperties.xml' path='doc/member[@name="AudioClientProperties.eCategory"]/*'/>
    public AUDIO_STREAM_CATEGORY eCategory;
    /// <include file='AudioClientProperties.xml' path='doc/member[@name="AudioClientProperties.Options"]/*'/>
    public AUDCLNT_STREAMOPTIONS Options;
}