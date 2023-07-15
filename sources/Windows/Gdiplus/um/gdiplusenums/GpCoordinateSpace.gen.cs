// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='GpCoordinateSpace.xml' path='doc/member[@name="GpCoordinateSpace"]/*'/>
public enum GpCoordinateSpace
{
    /// <include file='GpCoordinateSpace.xml' path='doc/member[@name="GpCoordinateSpace.CoordinateSpaceWorld"]/*'/>
    CoordinateSpaceWorld,
    /// <include file='GpCoordinateSpace.xml' path='doc/member[@name="GpCoordinateSpace.CoordinateSpacePage"]/*'/>
    CoordinateSpacePage,
    /// <include file='GpCoordinateSpace.xml' path='doc/member[@name="GpCoordinateSpace.CoordinateSpaceDevice"]/*'/>
    CoordinateSpaceDevice,
}