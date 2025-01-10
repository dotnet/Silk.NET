// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.IID;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_IAMFilterGraphCallback"/> property is correct.</summary>

    [Test]
    public static void IID_IAMFilterGraphCallbackTest()
    {
        Assert.That(
            IID_IAMFilterGraphCallback,
            Is.EqualTo(
                new Guid(0x56a868fd, 0x0ad4, 0x11ce, 0xb0, 0xa3, 0x0, 0x20, 0xaf, 0x0b, 0xa7, 0x70)
            )
        );
    }
}
