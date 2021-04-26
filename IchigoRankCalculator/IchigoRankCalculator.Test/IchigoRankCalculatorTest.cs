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

            Assert.Equal("あまおう", ichigo.Breed);
            Assert.Equal("S", ichigo.Size);
        }

        [Fact]
        public void 品種にとちおとめ_サイズにMを与えていちごを作成する()
        {
            Ichigo ichigo = new Ichigo(breed: "とちおとめ", size: "M");

            Assert.Equal("とちおとめ", ichigo.Breed);
            Assert.Equal("M", ichigo.Size);
        }
    }

    public class いちごを文字列表現に変換する
    {
        [Fact(DisplayName = "あまおうのSサイズは\"あまおう: S\"になる")]
        public void あまおうのSサイズ()
        {
            var ichigo = new Ichigo(breed: "あまおう", size: "S");
            Assert.Equal("あまおう: S", ichigo.ToString());
        }
    }
}
