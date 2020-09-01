using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Birthstone {
    class jewelry {


        #region<インスタンスフィールド>
        string Sn = null;
        string[] Sl = null;
        #endregion


        #region<コンストラクタ>
        jewelry(string name, string[] language) {
            Sn = name;
            Sl = language;
        }
        #endregion


        #region<クラスフィールド>
        //constの代わりとして、クラスフィールドにも使えるreadonlyを使用
        internal readonly static jewelry[] Jl = {new jewelry("ガーネット", new string[]{"情熱", "友愛", "実り"}),
                                                 new jewelry("アメジスト", new string[]{"高貴", "知性", "誠実"}),
                                                 new jewelry("アクアマリン", new string[]{"沈着", "聡明", "勇気"}), 
                                                 new jewelry("ダイヤモンド", new string[]{"純潔", "純愛", "永遠の絆"}),
                                                 new jewelry("エメラルド", new string[]{"幸運", "幸福", "愛"}),
                                                 new jewelry("ムーンストーン", new string[]{"健康", "純愛", "母性本能"}),
                                                 new jewelry("ルビー", new string[]{"情熱", "純愛", "威厳"}),
                                                 new jewelry("ペリドット", new string[]{"夫婦愛", "和愛", "運命の絆"}),
                                                 new jewelry("サファイア", new string[]{"誠実", "慈愛", "徳望"}),
                                                 new jewelry("オパール", new string[]{"幸運", "歓喜", "希望"}),
                                                 new jewelry("トパーズ", new string[]{"友情", "潔白", "希望"}),
                                                 new jewelry("ターコイズ", new string[]{"成功", "繁栄", "健康"})};
        #endregion


        #region<ゲッター>
        public string Sng() {
            return this.Sn;
        }

        public string Slag() {
            string all = null;
            foreach(string word in this.Sl) {
                all += $"\"{word}\"" + " ";
            }
            return all;
        }
        #endregion


    }
}
