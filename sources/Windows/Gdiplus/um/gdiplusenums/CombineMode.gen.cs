// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplusenums.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='CombineMode.xml' path='doc/member[@name="CombineMode"]/*'/>
public enum CombineMode
{
    /// <include file='CombineMode.xml' path='doc/member[@name="CombineMode.CombineModeReplace"]/*'/>
    CombineModeReplace,
    /// <include file='CombineMode.xml' path='doc/member[@name="CombineMode.CombineModeIntersect"]/*'/>
    CombineModeIntersect,
    /// <include file='CombineMode.xml' path='doc/member[@name="CombineMode.CombineModeUnion"]/*'/>
    CombineModeUnion,
    /// <include file='CombineMode.xml' path='doc/member[@name="CombineMode.CombineModeXor"]/*'/>
    CombineModeXor,
    /// <include file='CombineMode.xml' path='doc/member[@name="CombineMode.CombineModeExclude"]/*'/>
    CombineModeExclude,
    /// <include file='CombineMode.xml' path='doc/member[@name="CombineMode.CombineModeComplement"]/*'/>
    CombineModeComplement,
}