// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/x3daudio.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using NUnit.Framework;
using static Silk.NET.DirectX.DirectX;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.DirectX.UnitTests;

/// <summary>Provides validation of the <see cref = "DirectX"/> class.</summary>
public static unsafe partial class DirectXTests
{
    /// <summary>Validates that the value of the <see cref = "X3DAudioDefault_DirectionalCone"/> property is correct.</summary>

    [Test]
    public static void X3DAudioDefault_DirectionalConeTest()
    {
        Assert.That(X3DAudioDefault_DirectionalCone.InnerAngle, Is.EqualTo(3.141592654f / 2));
        Assert.That(X3DAudioDefault_DirectionalCone.OuterAngle, Is.EqualTo(3.141592654f));
        Assert.That(X3DAudioDefault_DirectionalCone.InnerVolume, Is.EqualTo(1.0f));
        Assert.That(X3DAudioDefault_DirectionalCone.OuterVolume, Is.EqualTo(0.708f));
        Assert.That(X3DAudioDefault_DirectionalCone.InnerLPF, Is.EqualTo(0.0f));
        Assert.That(X3DAudioDefault_DirectionalCone.OuterLPF, Is.EqualTo(0.25f));
        Assert.That(X3DAudioDefault_DirectionalCone.InnerReverb, Is.EqualTo(0.708f));
        Assert.That(X3DAudioDefault_DirectionalCone.OuterReverb, Is.EqualTo(1.0f));
    }
}
