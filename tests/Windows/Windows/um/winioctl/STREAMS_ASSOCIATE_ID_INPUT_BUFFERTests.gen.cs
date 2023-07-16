// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "STREAMS_ASSOCIATE_ID_INPUT_BUFFER"/> struct.</summary>
public static unsafe partial class STREAMS_ASSOCIATE_ID_INPUT_BUFFERTests
{
    /// <summary>Validates that the <see cref = "STREAMS_ASSOCIATE_ID_INPUT_BUFFER"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<STREAMS_ASSOCIATE_ID_INPUT_BUFFER>(), Is.EqualTo(sizeof(STREAMS_ASSOCIATE_ID_INPUT_BUFFER)));
    }

    /// <summary>Validates that the <see cref = "STREAMS_ASSOCIATE_ID_INPUT_BUFFER"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(STREAMS_ASSOCIATE_ID_INPUT_BUFFER).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "STREAMS_ASSOCIATE_ID_INPUT_BUFFER"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        Assert.That(sizeof(STREAMS_ASSOCIATE_ID_INPUT_BUFFER), Is.EqualTo(8));
    }
}