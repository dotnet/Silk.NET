// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
/// <include file='MOVE_RECT.xml' path='doc/member[@name="MOVE_RECT"]/*'/>
public partial struct MOVE_RECT
{
    /// <include file='MOVE_RECT.xml' path='doc/member[@name="MOVE_RECT.SourcePoint"]/*'/>
    public POINT SourcePoint;
    /// <include file='MOVE_RECT.xml' path='doc/member[@name="MOVE_RECT.DestRect"]/*'/>
    public RECT DestRect;
}