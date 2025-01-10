// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from https://docs.microsoft.com/en-us/windows/win32/appxpkg/how-to-programmatically-sign-a-package
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public unsafe partial struct APPX_SIP_CLIENT_DATA
{
    [NativeTypeName("PSIGNER_SIGN_EX2_PARAMS")]
    public SIGNER_SIGN_EX2_PARAMS* pSignerParams;
    public IUnknown pAppxSipState;
}
