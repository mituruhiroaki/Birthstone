using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using sc = System.Console;

namespace Birthstone {
    public partial class Form1 : Form {


        public Form1() {
            InitializeComponent();
        }


        void FindOut_button_Click(object sender, EventArgs e) {

            //プログラムを終了させるための変数を宣言(必要ないかも)
            DialogResult close = default;

            //コンボボックスjewelryBoxの選択されたキーナンバーを取得
            int number = jewelryBox.SelectedIndex;

            //キーナンバーが[0](空白)でないことを確認
            //[number - 1]は、jewelryBoxが[1]で始まるため、位置調整で使用
            //MessageBox.Showで結果を表示　OKボタンの出力をresultに代入
            if(number >= 1 && number <= 12) {
                DialogResult result = MessageBox.Show($"{number}月の誕生石は" + jewelry.Jl[number - 1].Sng(),
                                                      "結果", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //"結果"メッセージにOKが返されたら実行　OKボタンの出力をcloseに代入
                if(result == DialogResult.OK) {
                    close = MessageBox.Show("石言葉は" + jewelry.Jl[number - 1].Slag(),
                                            "石言葉", MessageBoxButtons.OK, MessageBoxIcon.None);
                }

                sc.WriteLine($"{number}月の誕生石は" + jewelry.Jl[number - 1].Sng());
                sc.WriteLine("石言葉は" + jewelry.Jl[number - 1].Slag());
            }

            //this.Close()でﾌﾟﾛｸﾞﾗﾑを終了
            if(close == DialogResult.OK) {
                this.Close();
            }

        }


    }
}
