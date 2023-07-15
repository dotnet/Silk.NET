// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/d3d10_1.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "IID"/> class.</summary>
public static partial class IIDTests
{
    /// <summary>Validates that the value of the <see cref = "IID_ID3D10BlendState1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10BlendState1Test()
    {
        Assert.That(IID_ID3D10BlendState1, Is.EqualTo(new Guid(0xEDAD8D99, 0x8A35, 0x4d6d, 0x85, 0x66, 0x2E, 0xA2, 0x76, 0xCD, 0xE1, 0x61)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10ShaderResourceView1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10ShaderResourceView1Test()
    {
        Assert.That(IID_ID3D10ShaderResourceView1, Is.EqualTo(new Guid(0x9B7E4C87, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }

    /// <summary>Validates that the value of the <see cref = "IID_ID3D10Device1"/> property is correct.</summary>
    [Test]
    public static void IID_ID3D10Device1Test()
    {
        Assert.That(IID_ID3D10Device1, Is.EqualTo(new Guid(0x9B7E4C8F, 0x342C, 0x4106, 0xA1, 0x9F, 0x4F, 0x27, 0x04, 0xF6, 0x89, 0xF0)));
    }
}