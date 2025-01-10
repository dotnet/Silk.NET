// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/Msi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows;

public enum INSTALLFEATUREATTRIBUTE
{
    INSTALLFEATUREATTRIBUTE_FAVORLOCAL = 1 << 0,
    INSTALLFEATUREATTRIBUTE_FAVORSOURCE = 1 << 1,
    INSTALLFEATUREATTRIBUTE_FOLLOWPARENT = 1 << 2,
    INSTALLFEATUREATTRIBUTE_FAVORADVERTISE = 1 << 3,
    INSTALLFEATUREATTRIBUTE_DISALLOWADVERTISE = 1 << 4,
    INSTALLFEATUREATTRIBUTE_NOUNSUPPORTEDADVERTISE = 1 << 5,
}
