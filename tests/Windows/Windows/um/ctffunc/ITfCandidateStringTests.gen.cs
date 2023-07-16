// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ctffunc.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ITfCandidateString"/> struct.</summary>
public static unsafe partial class ITfCandidateStringTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ITfCandidateString"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ITfCandidateString).GUID, Is.EqualTo(IID_ITfCandidateString));
    }

    /// <summary>Validates that the <see cref = "ITfCandidateString"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ITfCandidateString>(), Is.EqualTo(sizeof(ITfCandidateString)));
    }

    /// <summary>Validates that the <see cref = "ITfCandidateString"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ITfCandidateString).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ITfCandidateString"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ITfCandidateString), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ITfCandidateString), Is.EqualTo(4));
        }
    }
}