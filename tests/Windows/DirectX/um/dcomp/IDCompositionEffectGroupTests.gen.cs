// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/dcomp.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using static Silk.NET.Windows.IID;

namespace Silk.NET.DirectX.UnitTests;
/// <summary>Provides validation of the <see cref = "IDCompositionEffectGroup"/> struct.</summary>
[SupportedOSPlatform("windows6.2")]
public static unsafe partial class IDCompositionEffectGroupTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IDCompositionEffectGroup"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IDCompositionEffectGroup).GUID, Is.EqualTo(IID_IDCompositionEffectGroup));
    }

    /// <summary>Validates that the <see cref = "IDCompositionEffectGroup"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IDCompositionEffectGroup>(), Is.EqualTo(sizeof(IDCompositionEffectGroup)));
    }

    /// <summary>Validates that the <see cref = "IDCompositionEffectGroup"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IDCompositionEffectGroup).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IDCompositionEffectGroup"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IDCompositionEffectGroup), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IDCompositionEffectGroup), Is.EqualTo(4));
        }
    }
}