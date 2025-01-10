// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.26100.0
// Original source is Copyright © Microsoft. All rights reserved.
using System;
using System.Runtime.InteropServices;
using NUnit.Framework;
#pragma warning disable CS1589, CS0419, CA1416, CS0618
namespace Silk.NET.Windows.UnitTests;

/// <summary>Provides validation of the <see cref = "SE_ADT_PARAMETER_ARRAY_EX"/> struct.</summary>
public static unsafe partial class SE_ADT_PARAMETER_ARRAY_EXTests
{
    /// <summary>Validates that the <see cref = "SE_ADT_PARAMETER_ARRAY_EX"/> struct is blittable.</summary>

    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(
            Marshal.SizeOf<SE_ADT_PARAMETER_ARRAY_EX>(),
            Is.EqualTo(sizeof(SE_ADT_PARAMETER_ARRAY_EX))
        );
    }

    /// <summary>Validates that the <see cref = "SE_ADT_PARAMETER_ARRAY_EX"/> struct has the right <see cref = "LayoutKind"/>.</summary>

    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SE_ADT_PARAMETER_ARRAY_EX).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SE_ADT_PARAMETER_ARRAY_EX"/> struct has the correct size.</summary>

    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SE_ADT_PARAMETER_ARRAY_EX), Is.EqualTo(1056));
        }
        else
        {
            Assert.That(sizeof(SE_ADT_PARAMETER_ARRAY_EX), Is.EqualTo(668));
        }
    }
}
