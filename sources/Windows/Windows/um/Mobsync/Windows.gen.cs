// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace TerraFX.Interop.Windows;
public static partial class Windows
{
    [NativeTypeName("#define SYNCMGRPROGRESSITEM_STATUSTEXT 0x0001")]
    public const int SYNCMGRPROGRESSITEM_STATUSTEXT = 0x0001;
    [NativeTypeName("#define SYNCMGRPROGRESSITEM_STATUSTYPE 0x0002")]
    public const int SYNCMGRPROGRESSITEM_STATUSTYPE = 0x0002;
    [NativeTypeName("#define SYNCMGRPROGRESSITEM_PROGVALUE 0x0004")]
    public const int SYNCMGRPROGRESSITEM_PROGVALUE = 0x0004;
    [NativeTypeName("#define SYNCMGRPROGRESSITEM_MAXVALUE 0x0008")]
    public const int SYNCMGRPROGRESSITEM_MAXVALUE = 0x0008;
    [NativeTypeName("#define SYNCMGRLOGERROR_ERRORFLAGS 0x0001")]
    public const int SYNCMGRLOGERROR_ERRORFLAGS = 0x0001;
    [NativeTypeName("#define SYNCMGRLOGERROR_ERRORID 0x0002")]
    public const int SYNCMGRLOGERROR_ERRORID = 0x0002;
    [NativeTypeName("#define SYNCMGRLOGERROR_ITEMID 0x0004")]
    public const int SYNCMGRLOGERROR_ITEMID = 0x0004;
    [NativeTypeName("#define SYNCMGRITEM_ITEMFLAGMASK 0x007F")]
    public const int SYNCMGRITEM_ITEMFLAGMASK = 0x007F;
    [NativeTypeName("#define SYNCMGRHANDLERFLAG_MASK 0x000f")]
    public const int SYNCMGRHANDLERFLAG_MASK = 0x000f;
    [NativeTypeName("#define SYNCMGRREGISTERFLAGS_MASK 0x07")]
    public const int SYNCMGRREGISTERFLAGS_MASK = 0x07;
}