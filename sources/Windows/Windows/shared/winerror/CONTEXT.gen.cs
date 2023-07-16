// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from shared/winerror.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
namespace Silk.NET.Windows;
public static partial class CONTEXT
{
    [NativeTypeName("#define CONTEXT_E_FIRST 0x8004E000L")]
    public const uint CONTEXT_E_FIRST = 0x8004E000;
    [NativeTypeName("#define CONTEXT_E_LAST 0x8004E02FL")]
    public const uint CONTEXT_E_LAST = 0x8004E02F;
    [NativeTypeName("#define CONTEXT_S_FIRST 0x0004E000L")]
    public const int CONTEXT_S_FIRST = 0x0004E000;
    [NativeTypeName("#define CONTEXT_S_LAST 0x0004E02FL")]
    public const int CONTEXT_S_LAST = 0x0004E02F;
    [NativeTypeName("#define CONTEXT_E_ABORTED _HRESULT_TYPEDEF_(0x8004E002L)")]
    public const int CONTEXT_E_ABORTED = unchecked((int)(0x8004E002));
    [NativeTypeName("#define CONTEXT_E_ABORTING _HRESULT_TYPEDEF_(0x8004E003L)")]
    public const int CONTEXT_E_ABORTING = unchecked((int)(0x8004E003));
    [NativeTypeName("#define CONTEXT_E_NOCONTEXT _HRESULT_TYPEDEF_(0x8004E004L)")]
    public const int CONTEXT_E_NOCONTEXT = unchecked((int)(0x8004E004));
    [NativeTypeName("#define CONTEXT_E_WOULD_DEADLOCK _HRESULT_TYPEDEF_(0x8004E005L)")]
    public const int CONTEXT_E_WOULD_DEADLOCK = unchecked((int)(0x8004E005));
    [NativeTypeName("#define CONTEXT_E_SYNCH_TIMEOUT _HRESULT_TYPEDEF_(0x8004E006L)")]
    public const int CONTEXT_E_SYNCH_TIMEOUT = unchecked((int)(0x8004E006));
    [NativeTypeName("#define CONTEXT_E_OLDREF _HRESULT_TYPEDEF_(0x8004E007L)")]
    public const int CONTEXT_E_OLDREF = unchecked((int)(0x8004E007));
    [NativeTypeName("#define CONTEXT_E_ROLENOTFOUND _HRESULT_TYPEDEF_(0x8004E00CL)")]
    public const int CONTEXT_E_ROLENOTFOUND = unchecked((int)(0x8004E00C));
    [NativeTypeName("#define CONTEXT_E_TMNOTAVAILABLE _HRESULT_TYPEDEF_(0x8004E00FL)")]
    public const int CONTEXT_E_TMNOTAVAILABLE = unchecked((int)(0x8004E00F));
    [NativeTypeName("#define CONTEXT_E_NOJIT _HRESULT_TYPEDEF_(0x8004E026L)")]
    public const int CONTEXT_E_NOJIT = unchecked((int)(0x8004E026));
    [NativeTypeName("#define CONTEXT_E_NOTRANSACTION _HRESULT_TYPEDEF_(0x8004E027L)")]
    public const int CONTEXT_E_NOTRANSACTION = unchecked((int)(0x8004E027));
}