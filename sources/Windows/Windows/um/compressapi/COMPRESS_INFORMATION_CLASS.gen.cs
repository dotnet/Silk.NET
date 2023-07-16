// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/compressapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.Windows;
/// <include file='COMPRESS_INFORMATION_CLASS.xml' path='doc/member[@name="COMPRESS_INFORMATION_CLASS"]/*'/>
[SupportedOSPlatform("windows6.2")]
public enum COMPRESS_INFORMATION_CLASS
{
    /// <include file='COMPRESS_INFORMATION_CLASS.xml' path='doc/member[@name="COMPRESS_INFORMATION_CLASS.COMPRESS_INFORMATION_CLASS_INVALID"]/*'/>
    COMPRESS_INFORMATION_CLASS_INVALID = 0,
    /// <include file='COMPRESS_INFORMATION_CLASS.xml' path='doc/member[@name="COMPRESS_INFORMATION_CLASS.COMPRESS_INFORMATION_CLASS_BLOCK_SIZE"]/*'/>
    COMPRESS_INFORMATION_CLASS_BLOCK_SIZE,
    /// <include file='COMPRESS_INFORMATION_CLASS.xml' path='doc/member[@name="COMPRESS_INFORMATION_CLASS.COMPRESS_INFORMATION_CLASS_LEVEL"]/*'/>
    COMPRESS_INFORMATION_CLASS_LEVEL,
}