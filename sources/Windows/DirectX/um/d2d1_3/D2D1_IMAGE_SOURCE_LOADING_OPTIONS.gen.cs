// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d2d1_3.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.Versioning;

namespace Silk.NET.DirectX;
/// <include file='D2D1_IMAGE_SOURCE_LOADING_OPTIONS.xml' path='doc/member[@name="D2D1_IMAGE_SOURCE_LOADING_OPTIONS"]/*'/>
[Flags]
[SupportedOSPlatform("windows10.0")]
public enum D2D1_IMAGE_SOURCE_LOADING_OPTIONS
{
    /// <include file='D2D1_IMAGE_SOURCE_LOADING_OPTIONS.xml' path='doc/member[@name="D2D1_IMAGE_SOURCE_LOADING_OPTIONS.D2D1_IMAGE_SOURCE_LOADING_OPTIONS_NONE"]/*'/>
    D2D1_IMAGE_SOURCE_LOADING_OPTIONS_NONE = 0,
    /// <include file='D2D1_IMAGE_SOURCE_LOADING_OPTIONS.xml' path='doc/member[@name="D2D1_IMAGE_SOURCE_LOADING_OPTIONS.D2D1_IMAGE_SOURCE_LOADING_OPTIONS_RELEASE_SOURCE"]/*'/>
    D2D1_IMAGE_SOURCE_LOADING_OPTIONS_RELEASE_SOURCE = 1,
    /// <include file='D2D1_IMAGE_SOURCE_LOADING_OPTIONS.xml' path='doc/member[@name="D2D1_IMAGE_SOURCE_LOADING_OPTIONS.D2D1_IMAGE_SOURCE_LOADING_OPTIONS_CACHE_ON_DEMAND"]/*'/>
    D2D1_IMAGE_SOURCE_LOADING_OPTIONS_CACHE_ON_DEMAND = 2,
    /// <include file='D2D1_IMAGE_SOURCE_LOADING_OPTIONS.xml' path='doc/member[@name="D2D1_IMAGE_SOURCE_LOADING_OPTIONS.D2D1_IMAGE_SOURCE_LOADING_OPTIONS_FORCE_DWORD"]/*'/>
    D2D1_IMAGE_SOURCE_LOADING_OPTIONS_FORCE_DWORD = unchecked((int)(0xffffffff)),
}