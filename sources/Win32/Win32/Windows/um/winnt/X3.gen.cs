// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winnt.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public static partial class X3
{
    [NativeTypeName("#define X3_OPCODE_INST_WORD_X 3")]
    public const int X3_OPCODE_INST_WORD_X = 3;

    [NativeTypeName("#define X3_OPCODE_SIZE_X 4")]
    public const int X3_OPCODE_SIZE_X = 4;

    [NativeTypeName("#define X3_OPCODE_INST_WORD_POS_X 28")]
    public const int X3_OPCODE_INST_WORD_POS_X = 28;

    [NativeTypeName("#define X3_OPCODE_SIGN_VAL_POS_X 0")]
    public const int X3_OPCODE_SIGN_VAL_POS_X = 0;

    [NativeTypeName("#define X3_I_INST_WORD_X 3")]
    public const int X3_I_INST_WORD_X = 3;

    [NativeTypeName("#define X3_I_SIZE_X 1")]
    public const int X3_I_SIZE_X = 1;

    [NativeTypeName("#define X3_I_INST_WORD_POS_X 27")]
    public const int X3_I_INST_WORD_POS_X = 27;

    [NativeTypeName("#define X3_I_SIGN_VAL_POS_X 59")]
    public const int X3_I_SIGN_VAL_POS_X = 59;

    [NativeTypeName("#define X3_D_WH_INST_WORD_X 3")]
    public const int X3_D_WH_INST_WORD_X = 3;

    [NativeTypeName("#define X3_D_WH_SIZE_X 3")]
    public const int X3_D_WH_SIZE_X = 3;

    [NativeTypeName("#define X3_D_WH_INST_WORD_POS_X 24")]
    public const int X3_D_WH_INST_WORD_POS_X = 24;

    [NativeTypeName("#define X3_D_WH_SIGN_VAL_POS_X 0")]
    public const int X3_D_WH_SIGN_VAL_POS_X = 0;

    [NativeTypeName("#define X3_IMM20_INST_WORD_X 3")]
    public const int X3_IMM20_INST_WORD_X = 3;

    [NativeTypeName("#define X3_IMM20_SIZE_X 20")]
    public const int X3_IMM20_SIZE_X = 20;

    [NativeTypeName("#define X3_IMM20_INST_WORD_POS_X 4")]
    public const int X3_IMM20_INST_WORD_POS_X = 4;

    [NativeTypeName("#define X3_IMM20_SIGN_VAL_POS_X 0")]
    public const int X3_IMM20_SIGN_VAL_POS_X = 0;

    [NativeTypeName("#define X3_IMM39_1_INST_WORD_X 2")]
    public const int X3_IMM39_1_INST_WORD_X = 2;

    [NativeTypeName("#define X3_IMM39_1_SIZE_X 23")]
    public const int X3_IMM39_1_SIZE_X = 23;

    [NativeTypeName("#define X3_IMM39_1_INST_WORD_POS_X 0")]
    public const int X3_IMM39_1_INST_WORD_POS_X = 0;

    [NativeTypeName("#define X3_IMM39_1_SIGN_VAL_POS_X 36")]
    public const int X3_IMM39_1_SIGN_VAL_POS_X = 36;

    [NativeTypeName("#define X3_IMM39_2_INST_WORD_X 1")]
    public const int X3_IMM39_2_INST_WORD_X = 1;

    [NativeTypeName("#define X3_IMM39_2_SIZE_X 16")]
    public const int X3_IMM39_2_SIZE_X = 16;

    [NativeTypeName("#define X3_IMM39_2_INST_WORD_POS_X 16")]
    public const int X3_IMM39_2_INST_WORD_POS_X = 16;

    [NativeTypeName("#define X3_IMM39_2_SIGN_VAL_POS_X 20")]
    public const int X3_IMM39_2_SIGN_VAL_POS_X = 20;

    [NativeTypeName("#define X3_P_INST_WORD_X 3")]
    public const int X3_P_INST_WORD_X = 3;

    [NativeTypeName("#define X3_P_SIZE_X 4")]
    public const int X3_P_SIZE_X = 4;

    [NativeTypeName("#define X3_P_INST_WORD_POS_X 0")]
    public const int X3_P_INST_WORD_POS_X = 0;

    [NativeTypeName("#define X3_P_SIGN_VAL_POS_X 0")]
    public const int X3_P_SIGN_VAL_POS_X = 0;

    [NativeTypeName("#define X3_TMPLT_INST_WORD_X 0")]
    public const int X3_TMPLT_INST_WORD_X = 0;

    [NativeTypeName("#define X3_TMPLT_SIZE_X 4")]
    public const int X3_TMPLT_SIZE_X = 4;

    [NativeTypeName("#define X3_TMPLT_INST_WORD_POS_X 0")]
    public const int X3_TMPLT_INST_WORD_POS_X = 0;

    [NativeTypeName("#define X3_TMPLT_SIGN_VAL_POS_X 0")]
    public const int X3_TMPLT_SIGN_VAL_POS_X = 0;

    [NativeTypeName("#define X3_BTYPE_QP_INST_WORD_X 2")]
    public const int X3_BTYPE_QP_INST_WORD_X = 2;

    [NativeTypeName("#define X3_BTYPE_QP_SIZE_X 9")]
    public const int X3_BTYPE_QP_SIZE_X = 9;

    [NativeTypeName("#define X3_BTYPE_QP_INST_WORD_POS_X 23")]
    public const int X3_BTYPE_QP_INST_WORD_POS_X = 23;

    [NativeTypeName("#define X3_BTYPE_QP_INST_VAL_POS_X 0")]
    public const int X3_BTYPE_QP_INST_VAL_POS_X = 0;

    [NativeTypeName("#define X3_EMPTY_INST_WORD_X 1")]
    public const int X3_EMPTY_INST_WORD_X = 1;

    [NativeTypeName("#define X3_EMPTY_SIZE_X 2")]
    public const int X3_EMPTY_SIZE_X = 2;

    [NativeTypeName("#define X3_EMPTY_INST_WORD_POS_X 14")]
    public const int X3_EMPTY_INST_WORD_POS_X = 14;

    [NativeTypeName("#define X3_EMPTY_INST_VAL_POS_X 0")]
    public const int X3_EMPTY_INST_VAL_POS_X = 0;
}
