using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLServer_Lesson
{
    // 継承しないクラスにはsealedをつけたほうが良い
    public sealed class ProductEntity
    {
        // Ctrl + Tabキー2回でコンストラクターが作れる
        // コンストラクターの引数は命名規約上、先頭の文字は小文字にする
        public ProductEntity(
            int productId,
            string productName,
            int price)
        {
            ProductId = productId;
            ProductName = productName;
            Price = price;
        }

        // select文で取得したものを格納する
        // 型はデータベースの型と合わせる
        public int ProductId  { get; }
        public string ProductName { get; }
        public int Price { get; }
    }
}
