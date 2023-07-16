// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/MLOperatorAuthor.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;
using static Silk.NET.Windows.IID;

namespace Silk.NET.WinRT.UnitTests;
/// <summary>Provides validation of the <see cref = "IMLOperatorTypeInferenceContext"/> struct.</summary>
public static unsafe partial class IMLOperatorTypeInferenceContextTests
{
    /// <summary>Validates that the <see cref = "Guid"/> of the <see cref = "IMLOperatorTypeInferenceContext"/> struct is correct.</summary>
    [Test]
    public static void GuidOfTest()
    {
        Assert.That(typeof(IMLOperatorTypeInferenceContext).GUID, Is.EqualTo(IID_IMLOperatorTypeInferenceContext));
    }

    /// <summary>Validates that the <see cref = "IMLOperatorTypeInferenceContext"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<IMLOperatorTypeInferenceContext>(), Is.EqualTo(sizeof(IMLOperatorTypeInferenceContext)));
    }

    /// <summary>Validates that the <see cref = "IMLOperatorTypeInferenceContext"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(IMLOperatorTypeInferenceContext).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "IMLOperatorTypeInferenceContext"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(IMLOperatorTypeInferenceContext), Is.EqualTo(8));
        }
        else
        {
            Assert.That(sizeof(IMLOperatorTypeInferenceContext), Is.EqualTo(4));
        }
    }
}