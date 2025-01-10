// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.AM;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "AM"/> class.</summary>
public static partial class AMTests
{
    /// <summary>Validates that the value of the <see cref = "AM_MEDIA_TYPE_REPRESENTATION"/> property is correct.</summary>

    [Test]
    public static void AM_MEDIA_TYPE_REPRESENTATIONTest()
    {
        Assert.That(
            AM_MEDIA_TYPE_REPRESENTATION,
            Is.EqualTo(
                new Guid(0xe2e42ad2, 0x132c, 0x491e, 0xa2, 0x68, 0x3c, 0x7c, 0x2d, 0xca, 0x18, 0x1f)
            )
        );
    }
}
