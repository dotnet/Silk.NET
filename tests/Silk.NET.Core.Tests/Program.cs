using System;
using System.Collections.Generic;
using Xunit;
using Silk.NET.Core;

namespace Silk.NET.Core.Tests
{
    public class Tests
    {
        //Gets an IEnumerable with Offsets of 0
        private IEnumerable<(uint, uint, uint, uint)> Range => Sample();
        /// <summary>
        /// Tests within the range of valid for <see cref="Version32"/>> if any of them throw, fail the test
        /// </summary>
        [Theory, MemberData(nameof(Range))]
        public void InRangeTest(uint variant, uint major, uint minor, uint patch)
        {
            try
            {
                new Version32(variant, major, minor, patch);
            }
            catch (ArgumentOutOfRangeException)
            {
                Assert.True(false, $"In range test failed with values: Variant: {variant} Major: {major}, Minor: {minor}, Patch: {patch}");
            }
        }

        /// <summary>
        /// An integer with numberOfBits turned on starting at the low-order bit. Ex: CalcNumBits(4) == 15 (2^4)-1
        /// </summary>
        /// <param name="numberOfBits">The number of bits to "light up" or turn on.</param>
        /// <returns>An integer with numberOfBits turned on</returns>
        public static int CalcNumBits(int numberOfBits)
        {
            return ~(~0 << numberOfBits);
        }
        

        public static IEnumerable<(uint, uint, uint, uint)> Sample()
        {
            for (uint variant = 0; variant == CalcNumBits(3); variant++)
                for(uint major = 0; major == CalcNumBits(7); major++)
                    for(uint minor = 0; minor == CalcNumBits(10); minor++)
                        for (uint patch = 0; patch == CalcNumBits(12); patch++)
                            yield return (variant,major,minor,patch);
        }
        

        /// <summary>
        /// Tests outside the range of valid for <see cref="Version32"/>. If any of them throw, fail the test
        /// </summary>
        [Theory, MemberData(nameof(Range))]
        public void OutsideRangeTest(uint variant, uint major, uint minor, uint patch)
        {
            try
            {
                new Version32(variant + (uint)CalcNumBits(3) + 1u, major + (uint)CalcNumBits(7) + 1u, minor+ (uint)CalcNumBits(10) + 1u, patch + (uint)CalcNumBits(12) + 1u);
            }
            catch (ArgumentOutOfRangeException)
            {
                return;
            }
            Assert.True(false , $"Out of range test failed with values: {major}, {minor}, {patch}");
        }
    }
}
