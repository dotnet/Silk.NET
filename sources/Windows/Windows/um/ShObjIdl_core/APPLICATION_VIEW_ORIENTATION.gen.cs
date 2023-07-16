// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='APPLICATION_VIEW_ORIENTATION.xml' path='doc/member[@name="APPLICATION_VIEW_ORIENTATION"]/*'/>
public enum APPLICATION_VIEW_ORIENTATION
{
    /// <include file='APPLICATION_VIEW_ORIENTATION.xml' path='doc/member[@name="APPLICATION_VIEW_ORIENTATION.AVO_LANDSCAPE"]/*'/>
    AVO_LANDSCAPE = 0,
    /// <include file='APPLICATION_VIEW_ORIENTATION.xml' path='doc/member[@name="APPLICATION_VIEW_ORIENTATION.AVO_PORTRAIT"]/*'/>
    AVO_PORTRAIT = (AVO_LANDSCAPE + 1),
}