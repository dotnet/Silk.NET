// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/xamlOM.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using System.Runtime.Versioning;

namespace Silk.NET.WinRT;
/// <include file='VisualElementState.xml' path='doc/member[@name="VisualElementState"]/*'/>
[SupportedOSPlatform("windows10.0.14393.0")]
public enum VisualElementState
{
    /// <include file='VisualElementState.xml' path='doc/member[@name="VisualElementState.ErrorResolved"]/*'/>
    ErrorResolved = 0,
    /// <include file='VisualElementState.xml' path='doc/member[@name="VisualElementState.ErrorResourceNotFound"]/*'/>
    ErrorResourceNotFound = (ErrorResolved + 1),
    /// <include file='VisualElementState.xml' path='doc/member[@name="VisualElementState.ErrorInvalidResource"]/*'/>
    ErrorInvalidResource = (ErrorResourceNotFound + 1),
}