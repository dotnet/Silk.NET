// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "ISpeechRecoContext"/> struct.</summary>
public static unsafe partial class ISpeechRecoContextTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "ISpeechRecoContext"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(ISpeechRecoContext).GUID, Is.EqualTo(IID_ISpeechRecoContext));
    }

    /// <summary>Validates that the <see cref = "ISpeechRecoContext"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<ISpeechRecoContext>(), Is.EqualTo(sizeof(ISpeechRecoContext)));
    }

    /// <summary>Validates that the <see cref = "ISpeechRecoContext"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(ISpeechRecoContext).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "ISpeechRecoContext"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(ISpeechRecoContext), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(ISpeechRecoContext), Is.EqualTo(4));
        }
    }
}