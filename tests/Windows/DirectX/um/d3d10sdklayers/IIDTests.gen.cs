// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10sdklayers.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Debug"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10DebugTest()
    {
        Assert.That(IID_ID3D10Debug, Is.EqualTo(new Guid(0x9B7E4E01, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10SwitchToRef"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10SwitchToRefTest()
    {
        Assert.That(IID_ID3D10SwitchToRef, Is.EqualTo(new Guid(0x9B7E4E02, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10InfoQueue"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10InfoQueueTest()
    {
        Assert.That(IID_ID3D10InfoQueue, Is.EqualTo(new Guid(0x1b940b17, 0x2642, 0x4d1f, 0xab, 0x1f, 0xb9, 0x9b, 0xad, 0x0c, 0x39, 0x5f)));
    }
}