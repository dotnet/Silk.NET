// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "CodecAPIEventData"/> struct.</summary>
public static unsafe partial class CodecAPIEventDataTests
{
    /// <summary>Validates that the <see cref = "CodecAPIEventData"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<CodecAPIEventData>(), Is.EqualTo(sizeof(CodecAPIEventData)));
    }

    /// <summary>Validates that the <see cref = "CodecAPIEventData"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(CodecAPIEventData).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "CodecAPIEventData"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(CodecAPIEventData), Is.EqualTo(32));
    }
}