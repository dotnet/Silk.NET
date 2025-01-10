// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/mfapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.Windows.FORMAT;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "FORMAT"/> class.</summary>
public static partial class FORMATTests
{
    /// <summary>Validates that the value of the <see cref = "FORMAT_MFVideoFormat"/> property is correct.</summary>

    [Test]
    public static void FORMAT_MFVideoFormatTest()
    {
        Assert.That(
            FORMAT_MFVideoFormat,
            Is.EqualTo(
                new Guid(0xaed4ab2d, 0x7326, 0x43cb, 0x94, 0x64, 0xc8, 0x79, 0xca, 0xb9, 0xc4, 0x3d)
            )
        );
    }
}
