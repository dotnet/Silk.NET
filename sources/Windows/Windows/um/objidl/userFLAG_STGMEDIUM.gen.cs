// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/objidl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
/// <include file='userFLAG_STGMEDIUM.xml' path='doc/member[@name="userFLAG_STGMEDIUM"]/*'/>
public partial struct userFLAG_STGMEDIUM
{
    /// <include file='userFLAG_STGMEDIUM.xml' path='doc/member[@name="userFLAG_STGMEDIUM.ContextFlags"]/*'/>
    [NativeTypeName("LONG")]
    public int ContextFlags;
    /// <include file='userFLAG_STGMEDIUM.xml' path='doc/member[@name="userFLAG_STGMEDIUM.fPassOwnership"]/*'/>
    [NativeTypeName("LONG")]
    public int fPassOwnership;
    /// <include file='userFLAG_STGMEDIUM.xml' path='doc/member[@name="userFLAG_STGMEDIUM.Stgmed"]/*'/>
    public userSTGMEDIUM Stgmed;
}