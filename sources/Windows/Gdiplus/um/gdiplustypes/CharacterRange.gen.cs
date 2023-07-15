// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/gdiplustypes.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Gdiplus;
/// <include file='CharacterRange.xml' path='doc/member[@name="CharacterRange"]/*'/>
public partial struct CharacterRange
{
    /// <include file='CharacterRange.xml' path='doc/member[@name="CharacterRange.First"]/*'/>
    public int First;
    /// <include file='CharacterRange.xml' path='doc/member[@name="CharacterRange.Length"]/*'/>
    public int Length;
    public CharacterRange(int first, int length)
    {
        First = first;
        Length = length;
    }

    public CharacterRange()
    {
        First = 0;
        Length = 0;
    }
}