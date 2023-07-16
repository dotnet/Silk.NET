// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/msctf.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfInputProcessorProfileActivationSink"/> struct.</summary>
public static unsafe partial class ITfInputProcessorProfileActivationSinkTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfInputProcessorProfileActivationSink"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfInputProcessorProfileActivationSink).GUID, Is.EqualTo(IID_ITfInputProcessorProfileActivationSink));
    }

    /// <summary>Validates that the <see cref = "ITfInputProcessorProfileActivationSink"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfInputProcessorProfileActivationSink>(), Is.EqualTo(sizeof(ITfInputProcessorProfileActivationSink)));
    }

    /// <summary>Validates that the <see cref = "ITfInputProcessorProfileActivationSink"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfInputProcessorProfileActivationSink).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfInputProcessorProfileActivationSink"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfInputProcessorProfileActivationSink), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfInputProcessorProfileActivationSink), Is.EqualTo(4));
        }
    }
}