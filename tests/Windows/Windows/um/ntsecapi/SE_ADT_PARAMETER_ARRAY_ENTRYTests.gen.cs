// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.
// Ported from um/ntsecapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.
using NUnit.Framework;
using System;
using System.Runtime.InteropServices;

namespace Silk.NET.Windows.UnitTests;
/// <summary>Provides validation of the <see cref = "SE_ADT_PARAMETER_ARRAY_ENTRY"/> struct.</summary>
public static unsafe partial class SE_ADT_PARAMETER_ARRAY_ENTRYTests
{
    /// <summary>Validates that the <see cref = "SE_ADT_PARAMETER_ARRAY_ENTRY"/> struct is blittable.</summary>
    [Test]
    public static void IsBlittableTest()
    {
        Assert.That(Marshal.SizeOf<SE_ADT_PARAMETER_ARRAY_ENTRY>(), Is.EqualTo(sizeof(SE_ADT_PARAMETER_ARRAY_ENTRY)));
    }

    /// <summary>Validates that the <see cref = "SE_ADT_PARAMETER_ARRAY_ENTRY"/> struct has the right <see cref = "LayoutKind"/>.</summary>
    [Test]
    public static void IsLayoutSequentialTest()
    {
        Assert.That(typeof(SE_ADT_PARAMETER_ARRAY_ENTRY).IsLayoutSequential, Is.True);
    }

    /// <summary>Validates that the <see cref = "SE_ADT_PARAMETER_ARRAY_ENTRY"/> struct has the correct size.</summary>
    [Test]
    public static void SizeOfTest()
    {
        if (Environment.Is64BitProcess)
        {
            Assert.That(sizeof(SE_ADT_PARAMETER_ARRAY_ENTRY), Is.EqualTo(32));
        }
        else
        {
            Assert.That(sizeof(SE_ADT_PARAMETER_ARRAY_ENTRY), Is.EqualTo(20));
        }
    }
}