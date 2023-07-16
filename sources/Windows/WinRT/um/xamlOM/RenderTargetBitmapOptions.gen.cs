// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.WinRT;
/// <include file='RenderTargetBitmapOptions.xml' path='doc/member[@name="RenderTargetBitmapOptions"]/*'/>
[SupportedOSPlatform("windows10.0.14393.0")]
public enum RenderTargetBitmapOptions
{
    /// <include file='RenderTargetBitmapOptions.xml' path='doc/member[@name="RenderTargetBitmapOptions.RenderTarget"]/*'/>
    RenderTarget = 0,
    /// <include file='RenderTargetBitmapOptions.xml' path='doc/member[@name="RenderTargetBitmapOptions.RenderTargetAndChildren"]/*'/>
    RenderTargetAndChildren = (RenderTarget + 1),
}