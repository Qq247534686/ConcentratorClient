using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 集中器控制客户端.HandleClass.reportModels
{
    public class ComBoxDataSource
    {
        public string Text { get; set; }

        public object Value { get; set; }
        public static List<ComBoxDataSource> btnSendZiLingComBox()
        {
            List<ComBoxDataSource> theComBoxDataSource = new List<ComBoxDataSource>(){
                new ComBoxDataSource(){ Text="总召",Value=0x09 },
                new ComBoxDataSource(){ Text = "对时", Value = 0x20 },
                new ComBoxDataSource(){ Text = "实时遥测", Value = 0x19 }
            };
            return theComBoxDataSource;
        }
        //6011,6012,6013,6021,6022,6023,6031,6032,6033,6100,6101,6102,6103,6104,6105
        public static List<ComBoxDataSource> btnSendYaoKongDiZhiComBox()
        {
            string str = "6011,6012,6013,6021,6022,6023,6031,6032,6033,6100,6101,6102,6103,6104,6105";
            List<ComBoxDataSource> theComBoxDataSource = new List<ComBoxDataSource>();
            List<string> listStr = str.Split(',').ToList();
            for (int i = 0; i < listStr.Count; i++)
            {
                ComBoxDataSource comBoxDataSource = new ComBoxDataSource();
                comBoxDataSource.Text = listStr[i];
                comBoxDataSource.Value = listStr[i];
                theComBoxDataSource.Add(comBoxDataSource);
            }
            return theComBoxDataSource;
        }
        public static List<ComBoxDataSource> btnSendYaoKongZhiLingComBox()
        {
            List<ComBoxDataSource> theComBoxDataSource = new List<ComBoxDataSource>(){
                new ComBoxDataSource(){ Text="00",Value="00" },
                new ComBoxDataSource(){ Text = "01", Value = "01" }
            };
            return theComBoxDataSource;
        }
        public static List<ComBoxDataSource> btnSendZhaoHuanMuLuComBox()
        {
            List<ComBoxDataSource> theComBoxDataSource = new List<ComBoxDataSource>(){
                new ComBoxDataSource(){ Text="历史负荷数据",Value = new byte[4] { 0x06, 0x68, 0x00, 0x00 } },
                new ComBoxDataSource(){ Text = "Log文件", Value = new byte[4] { 0x07, 0x68, 0x00, 0x00 } },
                new ComBoxDataSource(){ Text="录波文件",Value = new byte[4] { 0x0a, 0x68, 0x00, 0x00 } },
                new ComBoxDataSource(){ Text = "预留1", Value = new byte[4] { 0x08, 0x68, 0x00, 0x00 } },
                new ComBoxDataSource(){ Text = "预留2", Value =new byte[4] { 0x09, 0x68, 0x00, 0x00 } }
            };
            return theComBoxDataSource;
        }

        internal static List<ComBoxDataSource> btnSendTongXinFanShiComBox()
        {
            List<ComBoxDataSource> theComBoxDataSource = new List<ComBoxDataSource>(){
                new ComBoxDataSource(){ Text="GPRS常在线",Value =0x00 },
                new ComBoxDataSource(){ Text = "短信模式在线", Value =0x01 },
                new ComBoxDataSource(){ Text="呼叫上线模式",Value =0x02 }
            };
            return theComBoxDataSource;
        }

        internal static List<ComBoxDataSource> btnSendGPRSOnLineComBox()
        {
            List<ComBoxDataSource> theComBoxDataSource = new List<ComBoxDataSource>(){
                new ComBoxDataSource(){ Text="常在线",Value =0x00 },
                new ComBoxDataSource(){ Text = "时间区段在线", Value =0x01 }
            };
            return theComBoxDataSource;
        }
        internal static List<ComBoxDataSource> btnSendGPRSToIPComBox()
        {
            List<ComBoxDataSource> theComBoxDataSource = new List<ComBoxDataSource>(){
                new ComBoxDataSource(){ Text="启用主IP",Value =0x00 },
                new ComBoxDataSource(){ Text = "启用备用IP", Value =0x01 }
            };
            return theComBoxDataSource;
        }

        internal static object btnSendGongHaoMoShiComBox()
        {
            List<ComBoxDataSource> theComBoxDataSource = new List<ComBoxDataSource>(){
                new ComBoxDataSource(){ Text="正常模式",Value =0x00 },
                new ComBoxDataSource(){ Text = "低功耗模式", Value =0x01 }
            };
            return theComBoxDataSource;
        }

        internal static List<ComBoxDataSource> btnSendJianCeXiangBieComBox()
        {
            List<ComBoxDataSource> theComBoxDataSource = new List<ComBoxDataSource>(){
                new ComBoxDataSource(){ Text="A",Value =0x00 },
                new ComBoxDataSource(){ Text = "B", Value =0x01 },
                new ComBoxDataSource(){ Text = "C", Value =0x02 }
            };
            return theComBoxDataSource;
        }

        internal static List<ComBoxDataSource> btnSendJieDiXiTongComBox()
        {
            List<ComBoxDataSource> theComBoxDataSource = new List<ComBoxDataSource>(){
                new ComBoxDataSource(){ Text="大电流接地系统",Value =0x00 },
                new ComBoxDataSource(){ Text = "小电流接地系统", Value =0x01 }
            };
            return theComBoxDataSource;
        }

        
    }
}
