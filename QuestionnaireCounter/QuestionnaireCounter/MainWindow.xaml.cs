using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace QuestionnaireCounter
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        common cls_comm = new common();
        bool blRunSts = false;

        //*************************************************************************
        public MainWindow()
        {
            InitializeComponent();
            //コントロールをディスエーブル
            CtrlEn(false);

            SetList(ref cls_comm.LstAnswer, 10, 5);
        }




        //*************************************************************************
        private void Click_BTN(object sender, RoutedEventArgs e)
        {
            Button btn = (Button)sender;
            switch (btn.Tag)
            {
                case "1":
                    MessageBox.Show("1 click");
                    break;
                case "2":
                    MessageBox.Show("2 click");
                    break;
                case "3":
                    MessageBox.Show("3 click");
                    break;
                case "4":
                    MessageBox.Show("4 click");
                    break;
                case "5":
                    MessageBox.Show("5 click");
                    break;
            }
        }

        //*************************************************************************
        private void SetList(ref List<int[]> lst, int ix, int iy)
        {
            int[] ary_int_val;

            ary_int_val = new int[iy];
            for (int i = 0; i < iy; i++)
                ary_int_val[i] = 0;

            for (int i = 0; i < ix; i++)
            {
                lst.Add(ary_int_val);
            }
        }


        //*************************************************************************
        public void CtrlEn(bool bl_Enable)
        {
            GridAnswerBtn.IsEnabled = bl_Enable;
            GridList.IsEnabled = bl_Enable;
            GridUpDown.IsEnabled = bl_Enable;

            blRunSts = bl_Enable;
        }



        //*************************************************************************
        private void Click_Debug(object sender, RoutedEventArgs e)
        {
            //SetList(ref cls_comm.LstAnswer, 10, 5);
            CtrlEn(!GridAnswerBtn.IsEnabled);
        }
    }
}
//*************************************************************************
