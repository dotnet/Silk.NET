// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SE_ADT_PARAMETER_ARRAY"/> struct.</summary>
public static unsafe partial class SE_ADT_PARAMETER_ARRAYTests
{
    /// <summary>Validates that the <see cref = "SE_ADT_PARAMETER_ARRAY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SE_ADT_PARAMETER_ARRAY>(), Is.EqualTo(sizeof(SE_ADT_PARAMETER_ARRAY)));
    }

    /// <summary>Validates that the <see cref = "SE_ADT_PARAMETER_ARRAY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SE_ADT_PARAMETER_ARRAY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SE_ADT_PARAMETER_ARRAY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SE_ADT_PARAMETER_ARRAY), Is.EqualTo(1048));
        }
        else
        {
            Assert.That(sizeof(SE_ADT_PARAMETER_ARRAY), Is.EqualTo(664));
        }
    }
}