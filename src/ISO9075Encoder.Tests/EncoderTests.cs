using System;
using Xunit;
using System.Linq;

namespace ISO9075Encoder.Tests
{
    public class EncoderTests
    {
        [Fact]
        public void Encode()
        {
            var text = "Hello & World 123";
            var expect = "Hello_x0020__x0026__x0020_World_x0020_123";
            Assert.Equal(expect, Encoder.Encode(text));
        }

        [Fact]
        public void Decode()
        {
            var encoded = "Hello_x0020__x0026__x0020_World_x0020_123";
            var text = "Hello & World 123";
            Assert.Equal(text, Encoder.Decode(encoded));
        }

        [Fact]
        public void Path()
        {
            var text = "/Test1/Test & 2".Split("/").Select(Encoder.Encode);
            var expect = "/Test1/Test_x0020__x0026__x0020_2";
            var rs = string.Join("/", text);
            Assert.Equal(expect, rs);
        }
    }
}
