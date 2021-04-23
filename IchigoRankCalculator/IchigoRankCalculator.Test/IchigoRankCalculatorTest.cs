using System;
using Xunit;

namespace IchigoRankCalculator.Test
{
    public class いちごの作成
    {
        [Fact]
        public void 品種にあまおう_サイズにSを与えていちごを作成する()
        {
            Ichigo ichigo = new Ichigo(breed: "あまおう", size: "S");

            // Assert.NotNull(ichigo);
            Assert.Equal("あまおう", ichigo.Breed);
            Assert.Equal("S", ichigo.Size);
        }
    }
}
