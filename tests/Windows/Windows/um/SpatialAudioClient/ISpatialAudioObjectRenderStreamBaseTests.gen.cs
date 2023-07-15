// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/SpatialAudioClient.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISpatialAudioObjectRenderStreamBase"/> struct.</summary>
public static unsafe partial class ISpatialAudioObjectRenderStreamBaseTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISpatialAudioObjectRenderStreamBase"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISpatialAudioObjectRenderStreamBase).GUID, Is.EqualTo(IID_ISpatialAudioObjectRenderStreamBase));
    }

    /// <summary>Validates that the <see cref = "ISpatialAudioObjectRenderStreamBase"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISpatialAudioObjectRenderStreamBase>(), Is.EqualTo(sizeof(ISpatialAudioObjectRenderStreamBase)));
    }

    /// <summary>Validates that the <see cref = "ISpatialAudioObjectRenderStreamBase"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISpatialAudioObjectRenderStreamBase).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISpatialAudioObjectRenderStreamBase"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISpatialAudioObjectRenderStreamBase), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISpatialAudioObjectRenderStreamBase), Is.EqualTo(4));
        }
    }
}